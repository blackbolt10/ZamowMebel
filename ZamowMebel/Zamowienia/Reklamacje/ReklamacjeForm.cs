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
    public partial class ReklamacjeForm : Form
    {
        private DataTable kontrahenciDT;
        private DataTable statusyDT;

        public ReklamacjeForm()
        {
            InitializeComponent();

            ZaladujKontrahenciCB();
            ZaladujStatusyCB();
            ZaladujReklamacjeDGV();
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

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ZaladujReklamacjeDGV();
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
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy statusów:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZaladujKontrahenciCB()
        {
            kontrahenciDT = new DataTable();
            kontrahenciCB.Items.Clear();
            DBRepository db = new DBRepository();
            String result = "";

            if(db.ReklamacjeForm_ZaladujKontrahenciCB(ref kontrahenciDT, ref result))
            {
                for(int i = 0; i < kontrahenciDT.Rows.Count; i++)
                {
                    kontrahenciCB.Items.Add(kontrahenciDT.Rows[i]["Nazwa statusu"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy kontrahentów:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZaladujReklamacjeDGV()
        {
            reklamacjeDGV.DataSource = null;
            reklamacjeDGV.Rows.Clear();
            reklamacjeDGV.Columns.Clear();
            changeButton.Enabled = false;

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            String TrN_PodID = "";

            if(kontrahenciCB.SelectedIndex > 0)
            {
                TrN_PodID = kontrahenciDT.Rows[kontrahenciCB.SelectedIndex]["trn_podid"].ToString();
            }

            String dataOd = dataOdDTP.Value.ToShortDateString();
            String dataDo = dataDoDTP.Value.ToShortDateString();

            if(db.ZamowieniaForm_ZaladujReklamacjeDGV(TrN_PodID, dataOd, dataDo, ref pomDataTable, ref result))
            {
                reklamacjeDGV.DataSource = pomDataTable;

                if(reklamacjeDGV.Columns.Count > 0)
                {
                    /*
                    reklamacjeDGV.Columns["ZamID"].Visible = false;
                    reklamacjeDGV.Columns["kolor"].Visible = false;
                    reklamacjeDGV.Columns["procent"].Visible = false;
                    reklamacjeDGV.Columns["Dokument"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    reklamacjeDGV.Columns["Kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    reklamacjeDGV.Columns["Nazwa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    reklamacjeDGV.Columns["Stan Optima"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    reklamacjeDGV.Columns["Pozostaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    reklamacjeDGV.Columns["Data Realizacji"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    reklamacjeDGV.Columns["Data zamówienia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    */
                }

                if(reklamacjeDGV.Rows.Count > 0)
                {
                    //FormatujZamowieniaDGV();

                    reklamacjeDGV.CurrentCell = reklamacjeDGV.Rows[0].Cells["Dokument"];
                    changeButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy reklamacji:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataOdDTP_ValueChanged(object sender, EventArgs e)
        {
            if(dataOdDTP.Value > dataDoDTP.Value)
            {
                dataDoDTP.Value = dataOdDTP.Value;
            }
        }

        private void dataDoDTP_ValueChanged(object sender, EventArgs e)
        {
            if(dataDoDTP.Value < dataOdDTP.Value)
            {
                dataOdDTP.Value = dataDoDTP.Value;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReklamacjeChangeForm reklamacjeChForm = new ReklamacjeChangeForm();
            reklamacjeChForm.ShowDialog();
            if(reklamacjeChForm.czyDodano)
            {
                ZaladujReklamacjeDGV();
            }

            reklamacjeChForm.Dispose();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(reklamacjeDGV.CurrentCell != null)
            {
                String idReklamacji = "";
                String numer = "";
                String nazwaKontrahenta = "";
                String status = "";

                ReklamacjeChangeForm reklamacjeChForm = new ReklamacjeChangeForm(idReklamacji, numer, nazwaKontrahenta, status);
                reklamacjeChForm.ShowDialog();
                if(reklamacjeChForm.czyDodano)
                {
                    ZaladujReklamacjeDGV();
                }

                reklamacjeChForm.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
