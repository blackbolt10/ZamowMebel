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
    public partial class DzialyForm : Form
    {
        public DzialyForm()
        {
            InitializeComponent();

            ZaladujDzialyDGV();
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

        private void archiwalneCHB_CheckedChanged(object sender, EventArgs e)
        {
            ZaladujDzialyDGV();
        }

        private void ZaladujDzialyDGV()
        {
            dzialyDGV.DataSource = null;
            dzialyDGV.Rows.Clear();
            dzialyDGV.Columns.Clear();

            changeButton.Enabled = false;
            delButton.Enabled = false;

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            if(db.DzialyForm_ZaladujDzialyDGV(ref pomDataTable, archiwalneCHB.Checked, ref result))
            {
                if(pomDataTable.Rows.Count > 0)
                {
                    dzialyDGV.DataSource = pomDataTable;

                    dzialyDGV.Columns["DZI_DziId"].Visible = false;
                    dzialyDGV.Columns["DZI_DataDodania"].Visible = false;
                    dzialyDGV.Columns["DZI_Nazwa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dzialyDGV.Columns["DZI_Archiwalny"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    dzialyDGV.CurrentCell = dzialyDGV.Rows[0].Cells["DZI_Nazwa"];

                    changeButton.Enabled = true;
                    delButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy diałów:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if(dzialyDGV.CurrentCell != null)
            {
                String nazwaDzialu = dzialyDGV.CurrentRow.Cells["DZI_Nazwa"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wskazany dział '" + nazwaDzialu + "'?", "Zapytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.OK)
                {
                    DBRepository db = new DBRepository();
                    String result = "";
                    if(db.DzialyForm_UsunDzial(dzialyDGV.CurrentRow.Cells["DZI_DziId"].Value.ToString(), ref result))
                    {
                        MessageBox.Show("Usunięto '" + nazwaDzialu + "'.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZaladujDzialyDGV();
                    }
                    else
                    {
                        MessageBox.Show("Wystapił błąd podczas usuwania działu '" + nazwaDzialu + "': " + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(dzialyDGV.CurrentCell != null)
            {
                String DZI_DziId = dzialyDGV.CurrentRow.Cells["DZI_DziId"].Value.ToString();
                String DZI_Nazwa = dzialyDGV.CurrentRow.Cells["DZI_Nazwa"].Value.ToString();
                String DZI_Archiwalny = dzialyDGV.CurrentRow.Cells["DZI_Archiwalny"].Value.ToString();

                DzialyChangeForm dzialyChangeForm = new DzialyChangeForm(DZI_DziId, DZI_Nazwa, DZI_Archiwalny);
                dzialyChangeForm.ShowDialog();

                if(dzialyChangeForm.czyZmodyfikowano)
                {
                    ZaladujDzialyDGV();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DzialyChangeForm dzialyChangeForm = new DzialyChangeForm();
            dzialyChangeForm.ShowDialog();

            if(dzialyChangeForm.czyZmodyfikowano)
            {
                ZaladujDzialyDGV();
            }
        }
    }
}
