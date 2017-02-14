using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel.Konfiguracja.Ustawienia.Operatorzy
{
    public partial class OperatorzyChangeForm : Form
    {
        public Boolean czyZmodyfikowano = false;
        private String OPR_OprId;
        DataTable dzialyDT;

        public OperatorzyChangeForm()
        {
            InitializeComponent();
            uprawnieniaCB.SelectedIndex = 0;

            ZaladujDzialyCB();
        }

        public OperatorzyChangeForm(String opr_OprId, String opr_Imie, String opr_Nazwisko, String OPR_Dzial, String opr_Uprawnienia, String opr_Archiwalny)
        {
            InitializeComponent();

            this.Text = "Edytuj operatora";

            OPR_OprId = opr_OprId;
            imieTB.Text = opr_Imie;
            nazwiskoTB.Text = opr_Nazwisko;

            uprawnieniaCB.SelectedIndex = 0;
            AktualizujUprawnieniaCB(opr_Uprawnienia);

            ZaladujDzialyCB();
            dzialCB.SelectedIndex = 0;
            AktualizujDzialyCB(OPR_Dzial);

            if(opr_Archiwalny == "1")
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

        private void ZaladujDzialyCB()
        {
            DBRepository db = new DBRepository();
            String result = "";

            dzialyDT = new DataTable();
            dzialCB.Items.Clear();

            if(db.OperatorzyChangeForm_ZaladujDzialyCB(ref dzialyDT, ref result))
            {
                for(int i = 0; i < dzialyDT.Rows.Count; i++)
                {
                    dzialCB.Items.Add(dzialyDT.Rows[i]["DZI_Nazwa"].ToString());
                }

                if(dzialCB.Items.Count>0)
                {
                    dzialCB.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy działów.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujUprawnieniaCB(string opr_Uprawnienia)
        {
            try
            {
                Int32 uprawnieniaID = Convert.ToInt32(opr_Uprawnienia);
                if(uprawnieniaID > -1 && uprawnieniaID < 3)
                {
                    uprawnieniaCB.SelectedIndex = uprawnieniaID + 1;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Wystapił błąd podczas wczytywania pola uprawnienia. Proszę o wskazanie uprawnień ręcznie.\n\nBłąd:" + exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujDzialyCB(string opr_Dzialy)
        {
            try
            {
                for(int i = 0; i < dzialyDT.Rows.Count; i++)
                {
                    if(opr_Dzialy == dzialyDT.Rows[i]["DZI_DziId"].ToString())
                    {
                        dzialCB.SelectedIndex = i;
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Wystapił błąd podczas wczytywania pola działy. Proszę o wskazanie działu ręcznie.\n\nBłąd:" + exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void akceptujButton_Click(object sender, EventArgs e)
        {
            if(imieTB.Text != "" && nazwiskoTB.Text != "")
            {
                DBRepository db = new DBRepository();
                String result = "";
                String archiwalny = "0";
                String dziId = dzialyDT.Rows[dzialCB.SelectedIndex]["DZI_DziId"].ToString();

                if(archiwalnyCB.Checked)
                {
                    archiwalny = "1";
                }

                if(db.OperatorzyChangeForm_AddNewOperator(imieTB.Text, nazwiskoTB.Text, dziId, (uprawnieniaCB.SelectedIndex - 1), archiwalny, ref result))
                {
                    czyZmodyfikowano = true;
                    MessageBox.Show("Nowy operator został dodany. Logowanie odbywa się bez podawania hasła.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawnia nowego operatora. Prosze spróbować ponownie.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Imię i nazwisko nie mogą być puste!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zmienButton_Click(object sender, EventArgs e)
        {
            if(imieTB.Text != "" && nazwiskoTB.Text != "")
            {
                DBRepository db = new DBRepository();
                String result = "";
                String archiwalny = "0";
                String dziId = dzialyDT.Rows[dzialCB.SelectedIndex]["DZI_DziId"].ToString();

                if(archiwalnyCB.Checked)
                {
                    archiwalny = "1";
                }

                if(db.OperatorzyChangeForm_ChangeOperator(OPR_OprId, imieTB.Text, nazwiskoTB.Text, dziId, (uprawnieniaCB.SelectedIndex - 1), archiwalny, ref result))
                {
                    czyZmodyfikowano = true;
                    MessageBox.Show("Operator został zmodyfikowany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas edycji operatora. Prosze spróbować ponownie.\n\nBłąd:" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Imię i nazwisko nie mogą być puste!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
