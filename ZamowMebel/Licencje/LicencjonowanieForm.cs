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
                if(tempDT.Rows.Count > 0)
                {
                    raportDGV.DataSource = tempDT;

                    raportDGV.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                    raportDGV.Columns["User"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                    raportDGV.Columns["Start"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                    raportDGV.Columns["Czas przeterminowania (s)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

                    raportDGV.CurrentCell = raportDGV.Rows[0].Cells[0];
                }
            }
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            if(raportDGV.CurrentCell != null)
            {
                DBRepository db = new DBRepository();
                String result = "";

                if(db.LicencjonowanieForm_CutInactiveSessions(ref result))
                {
                    LoadLicenceRaportDGV();

                    MessageBox.Show("Sesje nieaktywne zostały usunięte", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas wycinania sesji nieaktywnych:\n" + result);
                }
            }
        }
    }
}
