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
    public partial class ZamowieniaSzczegolyForm : Form
    {
        private string TrN_TrNID;
        private string TrN_PodmiotTyp;
        private string TrN_PodID;

        public ZamowieniaSzczegolyForm()// string trn_TrNID, string trN_PodmiotTyp, string trN_PodID, string trn_NumerPelny, string trn_PodNazwa1, string trn_DataDok, string trn_DataWys, string tRK_Tresc)
        {
            InitializeComponent();
            /*
            this.Text = trn_NumerPelny + "- Szczegóły";

            this.TrN_TrNID = trn_TrNID;
            this.TrN_PodmiotTyp = trN_PodmiotTyp;
            this.TrN_PodID = trN_PodID;

            UstawDaty(trn_DataDok, trn_DataWys);

            ZaladujKontrahentaDGV();
            ZaladujPozycjeDGV();
            */
            testc();
        }

        private void testc()
        {
            Dodatki.DataGridViewProgressColumn column = new Dodatki.DataGridViewProgressColumn();
            column.Name = "Test";
            column.HeaderText = "Test";

            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            DataGridViewColumn column1 = new DataGridViewColumn();
            column1.Name = "Test1";
            column1.HeaderText = "Test1";
            column1.CellTemplate = dataGridViewCell;

            kontrahentaDGV.Columns.Add(column1);
            kontrahentaDGV.Columns.Add(column);

            object[] row1 = new object[] { "test1", 50 };
            object[] row2 = new object[] { "test1", 55 };
            object[] row3 = new object[] { "test1", 22 };
            object[] rows = new object[] { row1, row2, row3 };

            foreach(object[] row in rows)
            {
                kontrahentaDGV.Rows.Add(row);
            }
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

        private void UstawDaty(string trn_DataDok, string trn_DataWys)
        {
            try
            {
                trn_DataDok = trn_DataDok.Split(' ')[0];
                trn_DataWys = trn_DataWys.Split(' ')[0];
            }
            catch(Exception){}

            dataWystL.Text = trn_DataDok;
            dataRezerwL.Text = trn_DataWys;
        }

        private void ZaladujKontrahentaDGV()
        {
            kontrahentaDGV.DataSource = null;
            kontrahentaDGV.Rows.Clear();
            kontrahentaDGV.Columns.Clear();

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            if(db.ZamowieniaSzczegolyForm_ZaladujKontrahentDGV(TrN_PodID, TrN_PodmiotTyp, ref pomDataTable, ref result))
            {
                kontrahentaDGV.DataSource = pomDataTable;

                /*if(kontrahentaDGV.Columns.Count > 0)
                {
                    zamowieniaDGV.Columns["Trn_TrNID"].Visible = false;
                    zamowieniaDGV.Columns["Trn_NumerPelny"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Trn_PodNazwa1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Trn_DataDok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Trn_DataWys"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["TRK_Tresc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }*/

                if(kontrahentaDGV.Rows.Count > 0)
                {
                    kontrahentaDGV.CurrentCell = kontrahentaDGV.Rows[0].Cells["Pod_Kod"];
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych kontrahenta:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZaladujPozycjeDGV()
        {
            pozycjeDGV.DataSource = null;
            pozycjeDGV.Rows.Clear();
            pozycjeDGV.Columns.Clear();

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            if(db.ZamowieniaSzczegolyForm_ZaladujPozycjeDGV(TrN_TrNID, ref pomDataTable, ref result))
            {
                pozycjeDGV.DataSource = pomDataTable;

                if(kontrahentaDGV.Columns.Count > 0)
                {
                    pozycjeDGV.Columns["TrE_TrEID"].Visible = false;
                    pozycjeDGV.Columns["TrE_TwrId"].Visible = false;
                    pozycjeDGV.Columns["TrE_TwrNazwa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                if(pozycjeDGV.Rows.Count > 0)
                {
                    pozycjeDGV.CurrentCell = pozycjeDGV.Rows[0].Cells["TrE_TwrNazwa"];
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania pozycji dokumentu:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ean13GeneratorForm ean = new Ean13GeneratorForm();
            ean.ShowDialog();
            ean.Dispose();
        }
    }
}
