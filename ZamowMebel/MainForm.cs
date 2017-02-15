using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel
{
    public partial class MainForm : Form
    {
        private static List<Form> listaMdiChildForm = new List<Form>();

        private Konfiguracja.Ustawienia.Operatorzy.OperatorzyForm operatorzyForm;
        private Konfiguracja.Ustawienia.Statusy.StatusyForm statusyForm;
        private Konfiguracja.Ustawienia.Dzialy.DzialyForm dzialyForm;
        private Zamowienia.ZamowieniaForm zamowieniaForm;



        private String sciezkaRejestru = "Software\\Galsoft\\ZamowMebel\\MainForm";
        public bool czyZamknac = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(sciezkaRejestru);

            SetDesktopLocation(Convert.ToInt16(key.GetValue("Location.X", Location.X.ToString())), Convert.ToInt16(key.GetValue("Location.Y", Location.Y.ToString())));

            Size = new Size(Convert.ToInt16(key.GetValue("Size.Width", Size.Width.ToString())), Convert.ToInt16(key.GetValue("Size.Height", Size.Height.ToString())));

            key.Close();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(sciezkaRejestru);

            if(WindowState != FormWindowState.Minimized)
            {
                key.SetValue("Location.X", Location.X.ToString());
                key.SetValue("Location.Y", Location.Y.ToString());

                // this.Size.Height .Width
                key.SetValue("Size.Width", Size.Width.ToString());
                key.SetValue("Size.Height", Size.Height.ToString());
            }
            key.Close();
        }

        public static void mdiChild_Activate(object sender, EventArgs e)
        {
            Form form = (Form)sender;

            if(listaMdiChildForm.Contains(form))
            {
                listaMdiChildForm.Remove(form);
            }

            listaMdiChildForm.Add(form);

            aktualizujListeMdiChild();
        }

        private static void aktualizujListeMdiChild()
        {
            oknaCB.Items.Clear();

            for(int i = 0; i < listaMdiChildForm.Count; i++)
            {
                oknaCB.Items.Add(listaMdiChildForm[i].Text);
            }

            if(oknaCB.Items.Count > 0)
            {
                listaMdiChildForm[listaMdiChildForm.Count - 1].Activate();
                oknaCB.SelectedIndex = oknaCB.Items.Count - 1;

                zmienOknoLabel.Visible = true;
                oknaCB.Visible = true;
            }
            else
            {
                zmienOknoLabel.Visible = false;
                oknaCB.Visible = false;
            }
        }


        private void oknaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(oknaCB.Items.Count > 0)
            {
                listaMdiChildForm[oknaCB.SelectedIndex].Focus();
            }

        }

        public static void mdiChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = (Form)sender;

            if(listaMdiChildForm.Contains(form))
            {
                listaMdiChildForm.Remove(form);
            }

            aktualizujListeMdiChild();
        }

        private void operatorzyRibbonButton_Click(object sender, EventArgs e)
        {
            if(operatorzyForm == null || operatorzyForm.IsDisposed)
            {
                operatorzyForm = new Konfiguracja.Ustawienia.Operatorzy.OperatorzyForm();
                operatorzyForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(mdiChild_FormClosing);
                operatorzyForm.Shown += new System.EventHandler(mdiChild_Activate);
                operatorzyForm.MdiParent = this;
                operatorzyForm.Dock = DockStyle.Fill;
                operatorzyForm.Show();
            }
            else
            {
                operatorzyForm.Activate();
            }
        }

        private void logowanieRibbonButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                czyZamknac = false;
                this.Close();
            }
        }

        private void statusyRibbonButton_Click(object sender, EventArgs e)
        {
            if(statusyForm == null || statusyForm.IsDisposed)
            {
                statusyForm = new Konfiguracja.Ustawienia.Statusy.StatusyForm();
                statusyForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(mdiChild_FormClosing);
                statusyForm.Shown += new System.EventHandler(mdiChild_Activate);
                statusyForm.MdiParent = this;
                statusyForm.Dock = DockStyle.Fill;
                statusyForm.Show();
            }
            else
            {
                statusyForm.Activate();
            }
        }

        private void dzialyRibbonButton_Click(object sender, EventArgs e)
        {
            if(dzialyForm == null || dzialyForm.IsDisposed)
            {
                dzialyForm = new Konfiguracja.Ustawienia.Dzialy.DzialyForm();
                dzialyForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(mdiChild_FormClosing);
                dzialyForm.Shown += new System.EventHandler(mdiChild_Activate);
                dzialyForm.MdiParent = this;
                dzialyForm.Dock = DockStyle.Fill;
                dzialyForm.Show();
            }
            else
            {
                dzialyForm.Activate();
            }
        }

        private void zamowieniaRibbonButton_Click(object sender, EventArgs e)
        {
            if(zamowieniaForm == null || zamowieniaForm.IsDisposed)
            {
                zamowieniaForm = new Zamowienia.ZamowieniaForm();
                zamowieniaForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(mdiChild_FormClosing);
                zamowieniaForm.Shown += new System.EventHandler(mdiChild_Activate);
                zamowieniaForm.MdiParent = this;
                zamowieniaForm.Dock = DockStyle.Fill;
                zamowieniaForm.Show();
            }
            else
            {
                zamowieniaForm.Activate();
            }
        }
    }
}
