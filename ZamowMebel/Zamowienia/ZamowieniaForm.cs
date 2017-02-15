using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel.Zamowienia
{
    public partial class ZamowieniaForm : Form
    {
        private DataTable kontrahenciDT;

        public ZamowieniaForm()
        {
            InitializeComponent();

            ZaladujKontrahenciCB();
            ZaladujZamowieniaDGV();
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
            ZaladujZamowieniaDGV();
        }

        private void ZaladujZamowieniaDGV()
        {
            zamowieniaDGV.DataSource = null;
            zamowieniaDGV.Rows.Clear();
            zamowieniaDGV.Columns.Clear();
            changeButton.Enabled = false;

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            String TrN_PodID = "";
            String TrN_PodmiotTyp = "";

            if(kontrahenciCB.SelectedIndex > 0)
            {
                TrN_PodID = kontrahenciDT.Rows[kontrahenciCB.SelectedIndex]["trn_podid"].ToString();
                TrN_PodmiotTyp = kontrahenciDT.Rows[kontrahenciCB.SelectedIndex]["trn_Podmiottyp"].ToString();
            }

            String dataOd = dataOdDTP.Value.ToShortDateString();
            String dataDo = dataDoDTP.Value.ToShortDateString();

            if(db.ZamowieniaForm_ZaladujZamowieniaDGV(TrN_PodID, TrN_PodmiotTyp, dataOd, dataDo, ref pomDataTable, ref result))
            {
                zamowieniaDGV.DataSource = pomDataTable;

                if(zamowieniaDGV.Columns.Count>0)
                {
                    zamowieniaDGV.Columns["Trn_TrNID"].Visible = false;
                    zamowieniaDGV.Columns["TrN_PodmiotTyp"].Visible = false;
                    zamowieniaDGV.Columns["TrN_PodID"].Visible = false;
                    zamowieniaDGV.Columns["Trn_NumerPelny"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Trn_PodNazwa1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Trn_DataDok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Trn_DataWys"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["TRK_Tresc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                if(zamowieniaDGV.Rows.Count > 0)
                {
                    zamowieniaDGV.CurrentCell = zamowieniaDGV.Rows[0].Cells["Trn_NumerPelny"];
                    changeButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy zamówień:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZaladujKontrahenciCB()
        {
            kontrahenciCB.Items.Clear();

            DBRepository db = new DBRepository();
            String result = "";
            kontrahenciDT = new DataTable();

            if(db.ZamowieniaForm_ZaladujKontrahenciCB(ref kontrahenciDT, ref result))
            {
                for(int i = 0; i < kontrahenciDT.Rows.Count; i++)
                {
                    kontrahenciCB.Items.Add(kontrahenciDT.Rows[i]["Trn_PodNazwa1"].ToString());
                }
                if(kontrahenciCB.Items.Count>0)
                {
                    kontrahenciCB.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy kontrahentów:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(zamowieniaDGV.CurrentCell != null)
            {
                String Trn_TrNID = zamowieniaDGV.CurrentRow.Cells["Trn_TrNID"].Value.ToString();
                String TrN_PodmiotTyp = zamowieniaDGV.CurrentRow.Cells["TrN_PodmiotTyp"].Value.ToString();
                String TrN_PodID = zamowieniaDGV.CurrentRow.Cells["TrN_PodID"].Value.ToString();
                String Trn_NumerPelny = zamowieniaDGV.CurrentRow.Cells["Trn_NumerPelny"].Value.ToString();
                String Trn_PodNazwa1 = zamowieniaDGV.CurrentRow.Cells["Trn_PodNazwa1"].Value.ToString();
                String Trn_DataDok = zamowieniaDGV.CurrentRow.Cells["Trn_DataDok"].Value.ToString();
                String Trn_DataWys = zamowieniaDGV.CurrentRow.Cells["Trn_DataWys"].Value.ToString();
                String TRK_Tresc = zamowieniaDGV.CurrentRow.Cells["TRK_Tresc"].Value.ToString();

                ZamowieniaSzczegolyForm zamSzczegForm = new ZamowieniaSzczegolyForm(Trn_TrNID, TrN_PodmiotTyp, TrN_PodID, Trn_NumerPelny, Trn_PodNazwa1, Trn_DataDok, Trn_DataWys, TRK_Tresc);
                zamSzczegForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainForm.mdiChild_FormClosing);
                zamSzczegForm.Shown += new System.EventHandler(MainForm.mdiChild_Activate);
                zamSzczegForm.MdiParent = this.MdiParent;
                zamSzczegForm.Dock = DockStyle.Fill;
                zamSzczegForm.Show();                
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
    }
}
