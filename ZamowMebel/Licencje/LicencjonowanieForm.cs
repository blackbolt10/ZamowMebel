using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace ZamowMebel.Licencje
{
    public partial class LicencjonowanieForm : Form
    {
        public LicencjonowanieForm()
        {
            InitializeComponent();

            LoadLicenceRaportDGV();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLicenceRaportDGV()
        {
            DBRepository db = new DBRepository();
            DataTable tempDT = new DataTable();
            String result = "";        

            raportDGV.DataSource = null;
            raportDGV.Rows.Clear();

            if(db.LicencjonowanieForm_LoadLicenceRaportDGV(ref tempDT, ref result))
            {
                /*
                try
                {
                    DataTable pomDataTable = new DataTable();
                    String zapytanieString = "select SES_XlLogin [Login], SES_WindowsUser [User], convert(smalldatetime, SES_DataOd) [Start], datediff(s, ses_dataAkt, getdate()) [Czas przeterminowania (s)] from gal.Sesje_new where SES_DataDO is null and datediff(s, ses_dataAkt, getdate())>300";
                    SqlDataAdapter da = polecenieBD_Galsoft(zapytanieString);
                    da.Fill(pomDataTable);

                    if(pomDataTable.Rows.Count > 0)
                    {
                        raportDGV.DataSource = pomDataTable;
                        raportDGV.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                        raportDGV.Columns["User"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                        raportDGV.Columns["Start"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                        raportDGV.Columns["Czas przeterminowania (s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                        raportDGV.CurrentCell = raportDGV.Rows[0].Cells[0];
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Wystąpił błąd funkcji zaladujraportDGV :" + Environment.NewLine + exc.Message);
                    MainForm.raportBledu("LogowanieLicencjeOkno", "zaladujraportDGV() " + exc.Message);
                }
                */
            }
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                DataTable pomDataTable = new DataTable();
                String zapytanieString = "update gal.Sesje_new set SES_DataDO=getdate(), SES_Aktywna=3 where SES_DataDO is null and datediff(s, ses_dataAkt, getdate())>300";
                SqlDataAdapter da = polecenieBD_Galsoft(zapytanieString);
                da.Fill(pomDataTable);

                MessageBox.Show("Sesje nieaktywne zostały usunięte", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Wystąpił błąd funkcji wytnijButton_Click :" + Environment.NewLine + exc.Message);
                glowneOkno.raportBledu("LogowanieLicencjeOkno", "wytnijButton_Click() " + exc.Message);
            }
            */
        }
    }
}
