using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel.Konfiguracja.Ustawienia.Dzialy
{
    public partial class DzialyChangeForm : Form
    {
        public bool czyZmodyfikowano;
        private string DZI_DziId;

        public DzialyChangeForm()
        {
            InitializeComponent();
        }

        public DzialyChangeForm(string dZI_DziId, string dZI_Nazwa, string dZI_Archiwalny)
        {
            InitializeComponent();

            this.Text = "Edytuj dział";

            DZI_DziId = dZI_DziId;
            nazwaTB.Text = dZI_Nazwa;

            if(dZI_Archiwalny == "1")
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

                if(db.DzialyChangeForm_AddDzial(nazwaTB.Text, archiwalny, ref result))
                {
                    czyZmodyfikowano = true;
                    MessageBox.Show("Nowy dział został dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawnia nowego działu. Prosze spróbować ponownie.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if(db.DzialyChangeForm_ChangeDzial(DZI_DziId, nazwaTB.Text, archiwalny, ref result))
                {
                    czyZmodyfikowano = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji działu. Prosze spróbować ponownie.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nazwa nie może być pusta!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
