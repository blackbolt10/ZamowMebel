using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel.Konfiguracja.Ustawienia.Statusy
{
    public partial class StatusyChangeForm : Form
    {
        public bool czyZmodyfikowano;
        private string STT_SttId;

        public StatusyChangeForm()
        {
            InitializeComponent();
        }

        public StatusyChangeForm(string sTT_SttId, string sTT_Nazwa, string sTT_Archiwalny)
        {
            InitializeComponent();

            this.Text = "Edytuj status";

            STT_SttId = sTT_SttId;
            nazwaTB.Text = sTT_Nazwa;

            if(sTT_Archiwalny == "1")
            {
                archiwalnyCB.Checked = true;
            }

            akceptujButton.Click -= akceptujButton_Click;
            akceptujButton.Click += zmienButton_Click;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //zamknięcie aktywnego okna
        {
            if(keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void akceptujButton_Click(object sender, EventArgs e)
        {
            if(nazwaTB.Text != "")
            {
                DBRepository db = new DBRepository();
                String result = "";
                String archiwalny = "0";

                if(archiwalnyCB.Checked)
                {
                    archiwalny = "1";
                }

                if(db.StatusyChangeForm_AddAkord(nazwaTB.Text, archiwalny, ref result))
                {
                    czyZmodyfikowano = true;
                    MessageBox.Show("Nowy status został dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawnia nowego statusu. Prosze spróbować ponownie.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nazwa nie może być pusta!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zmienButton_Click(object sender, EventArgs e)
        {
            if(nazwaTB.Text != "")
            {
                DBRepository db = new DBRepository();
                String result = "";
                String archiwalny = "0";

                if(archiwalnyCB.Checked)
                {
                    archiwalny = "1";
                }

                if(db.StatusyChangeForm_ChangeAkord(STT_SttId, nazwaTB.Text, archiwalny, ref result))
                {
                    czyZmodyfikowano = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji statusu. Prosze spróbować ponownie.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nazwa nie może być pusta!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
