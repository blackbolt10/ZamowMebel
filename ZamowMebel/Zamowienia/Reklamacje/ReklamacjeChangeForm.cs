using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel.Zamowienia.Reklamacje
{
    public partial class ReklamacjeChangeForm : Form
    {
        public bool czyDodano;
        String idReklamacji;
        private DataTable statusyDT;

        public ReklamacjeChangeForm()
        {
            InitializeComponent();

            ZaladujStatusyCB();

        }

        public ReklamacjeChangeForm(String idReklamacji, String numer, String nazwaKontrahenta, String status)
        {
            InitializeComponent();
            this.Text = "Edycja reklamacji nr. " + numer;

            ZaladujStatusyCB();
            UstawStatus(status);

            this.idReklamacji = idReklamacji;
            nrTB.Text = numer;
            kontrahentTB.Text = nazwaKontrahenta;
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

        private void ZaladujStatusyCB()
        {
            statusyDT = new DataTable();
            statusCB.Items.Clear();
            DBRepository db = new DBRepository();
            String result = "";

            if(db.ReklamacjeForm_ZaladujStatusyCB(ref statusyDT, ref result))
            {
                for(int i = 0; i < statusyDT.Rows.Count; i++)
                {
                    statusCB.Items.Add(statusyDT.Rows[i]["Nazwa statusu"].ToString());
                }

                if(statusCB.Items.Count>0)
                {
                    statusCB.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy statusów:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UstawStatus(string status)
        {
            for(int i = 0; i < statusCB.Items.Count; i++)
            {
                if(statusCB.Items[i].ToString() == status)
                {
                    statusCB.SelectedIndex = i;
                    break;
                }
            }
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            if(statusCB.SelectedIndex != -1)
            {
                if(kontrahentTB.Text != "")
                {
                    if(opisRTB.Text != "")
                    {
                        DBRepository db = new DBRepository();
                        String result = "";

                        if(db.ReklamacjeChangeForm_ZapiszReklamacje(ref result))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Wystapił błąd podczas zaisu nowej reklamacji:\n"+result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Opis nie może być pusty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kontrahent nie może być pusty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Status nie może być pusty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kontrahentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
