using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Spire.Barcode;
using System.Drawing.Drawing2D;

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

            zamowieniaDGV.AutoGenerateColumns = false;
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

            if(kontrahenciCB.SelectedIndex > 0)
            {
                TrN_PodID = kontrahenciDT.Rows[kontrahenciCB.SelectedIndex]["trn_podid"].ToString();
            }

            String dataOd = dataOdDTP.Value.ToShortDateString();
            String dataDo = dataDoDTP.Value.ToShortDateString();

            if(db.ZamowieniaForm_ZaladujZamowieniaDGV(TrN_PodID, dataOd, dataDo, ref pomDataTable, ref result))
            {
                zamowieniaDGV.DataSource = pomDataTable;

                if(zamowieniaDGV.Columns.Count>0)
                {
                    zamowieniaDGV.Columns["ZamID"].Visible = false;
                    zamowieniaDGV.Columns["kolor"].Visible = false;
                    zamowieniaDGV.Columns["procent"].Visible = false;
                    zamowieniaDGV.Columns["Dokument"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Nazwa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    zamowieniaDGV.Columns["Stan Optima"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Pozostaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Data Realizacji"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    zamowieniaDGV.Columns["Data zamówienia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                if(zamowieniaDGV.Rows.Count > 0)
                {
                    FormatujZamowieniaDGV();

                    zamowieniaDGV.CurrentCell = zamowieniaDGV.Rows[0].Cells["Dokument"];
                    changeButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy zamówień:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatujZamowieniaDGV()
        {
            for(int i = 0; i < zamowieniaDGV.Rows.Count; i++)
            {
                
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
                    kontrahenciCB.Items.Add(kontrahenciDT.Rows[i]["Trn_PodNazwa"].ToString());
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
                ZamowieniaSzczegolyForm zamSzczegForm = new ZamowieniaSzczegolyForm();
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

        private void zamowieniaDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if(e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if(IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = zamowieniaDGV.AdvancedCellBorderStyle.Top;
            }
        }
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = zamowieniaDGV[column, row];
            DataGridViewCell cell2 = zamowieniaDGV[column, row - 1];
            if(cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void zamowieniaDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex == 0)
                return;
            if(IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        void generujkodkreskowy()
        {
            BarcodeSettings settings = new BarcodeSettings();

            string data = "0123456789123";
            settings.Data2D = data;
            settings.Data = "0123456789123";

            settings.Type = (BarCodeType)Enum.Parse(typeof(BarCodeType), "EAN13");


            settings.HasBorder = true;
            settings.BorderDashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), "Solid");

            short fontSize = 8;
            string font = "SimSun";
            settings.TextFont = new System.Drawing.Font(font, fontSize, FontStyle.Bold);
            
            short barHeight = 15;
            settings.BarHeight = barHeight;

            settings.ShowText = true;
            settings.ShowCheckSumChar = true;
            string foreColor = Color.Black.ToString();
            settings.ForeColor = Color.FromName(foreColor);



            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image barcode = generator.GenerateImage();

            //save the barcode as an image
            barcode.Save(@"..\barcode.png");

            //launch the generated barcode image
            System.Diagnostics.Process.Start(@"..\barcode.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generujkodkreskowy();
        }
    }
}
