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
    public partial class LoginForm : Form
    {
        public DataTable operatrzyDT;

        private String sciezkaRejestru = "Software\\Galsoft\\ZamowMebel\\LoginForm";
        private String AppVersion = "0.1";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            DBRepository db = null;

            try
            {
                db = new DBRepository();
                String result = "";

                if(db.LoginForm_GetAppVersion(ref result))
                {
                    if(AppVersion == result)
                    {
                        LoadOperatorCB();
                        hasloTB.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Wersja aplikacji jest niezgodna z wersją bazy danych.\nProszę o zaktualizowanie programu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd połączenia z bazą danych.\n\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Wystąpił błąd połączenia z bazą danych.\n" + exc.Message+"\nAplikacja zostanie zmaknięta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZapiszLoginID()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(sciezkaRejestru);

            key.SetValue("LastLoggedID", operatrzyDT.Rows[operatorCB.SelectedIndex]["OPR_OprId"].ToString());

            key.Close();
        }

        private void UstawLoginCB()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(sciezkaRejestru);

            String IDOperatora = key.GetValue("LastLoggedID", "").ToString();

            key.Close();
            int index = 0;

            if(IDOperatora != "" && operatrzyDT != null)
            {
                for(int i = 0; i < operatrzyDT.Rows.Count; i++)
                {
                    if(operatrzyDT.Rows[i]["OPR_OprId"].ToString() == IDOperatora)
                    {
                        index = i;
                    }
                }
            }

            operatorCB.SelectedIndex = index;
        }

        private void LoadOperatorCB()
        {
            operatrzyDT = new DataTable();
            operatorCB.Items.Clear();

            DBRepository db = new DBRepository();
            String result = "";

            if(db.LoginForm_LoadOperatorCB(ref operatrzyDT, ref result))
            {
                if(operatrzyDT.Rows.Count>0)
                {
                    for(int i =0;i<operatrzyDT.Rows.Count;i++)
                    {
                        operatorCB.Items.Add(operatrzyDT.Rows[i]["OPR_Nazwisko"].ToString()+" "+ operatrzyDT.Rows[i]["OPR_Imie"].ToString());
                    }
                    UstawLoginCB();
                }
            }
            else
            {
                MessageBox.Show("Wystapił błąd podczas wczytywania listy operatorów:\n"+result,"Błąd",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            ZapiszLoginID();

            if(hasloTB.Text == operatrzyDT.Rows[operatorCB.SelectedIndex]["OPR_Haslo"].ToString())
            {
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                if(mainForm.czyZamknac)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Podane hasło jest nie prawidłowe!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            hasloTB.Text = "";
        }

        private void hasloTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                logInButton.PerformClick();
            }
        }

        private void operatorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasloTB.Focus();
        }
    }
}
