using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel.Konfiguracja.Ustawienia.Statusy
{
    public partial class StatusyForm : Form
    {
        public StatusyForm()
        {
            InitializeComponent();

            ZaladujStatusyDGV();
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
            ZaladujStatusyDGV();
        }

        private void ZaladujStatusyDGV()
        {
            statusyDGV.DataSource = null;
            statusyDGV.Rows.Clear();
            statusyDGV.Columns.Clear();

            changeButton.Enabled = false;
            delButton.Enabled = false;

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            if(db.StatusyForm_ZaladujStatusyDGV(ref pomDataTable, archiwalneCHB.Checked, ref result))
            {
                if(pomDataTable.Rows.Count > 0)
                {
                    statusyDGV.DataSource = pomDataTable;

                    statusyDGV.Columns["STT_SttId"].Visible = false;
                    statusyDGV.Columns["STT_DataDodania"].Visible = false;
                    statusyDGV.Columns["STT_Nazwa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    statusyDGV.Columns["STT_Archiwalny"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    statusyDGV.CurrentCell = statusyDGV.Rows[0].Cells["STT_Nazwa"];

                    changeButton.Enabled = true;
                    delButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy statusów:\n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if(statusyDGV.CurrentCell != null)
            {
                String nazwaStatusu = statusyDGV.CurrentRow.Cells["STT_Nazwa"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wskazany status '" + nazwaStatusu + "'?", "Zapytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.OK)
                {
                    DBRepository db = new DBRepository();
                    String result = "";
                    if(db.StatusyForm_UsunStatus(statusyDGV.CurrentRow.Cells["STT_SttId"].Value.ToString(), ref result))
                    {
                        MessageBox.Show("Usunięto '" + nazwaStatusu + "'.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZaladujStatusyDGV();
                    }
                    else
                    {
                        MessageBox.Show("Wystapił błąd podczas usuwania statusu '" + nazwaStatusu + "': " + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(statusyDGV.CurrentCell != null)
            {
                String STT_SttId = statusyDGV.CurrentRow.Cells["STT_SttId"].Value.ToString();
                String STT_Nazwa = statusyDGV.CurrentRow.Cells["STT_Nazwa"].Value.ToString();
                String STT_Archiwalny = statusyDGV.CurrentRow.Cells["STT_Archiwalny"].Value.ToString();

                StatusyChangeForm statusyChangeForm = new StatusyChangeForm(STT_SttId, STT_Nazwa, STT_Archiwalny);
                statusyChangeForm.ShowDialog();

                if(statusyChangeForm.czyZmodyfikowano)
                {
                    ZaladujStatusyDGV();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StatusyChangeForm akrChangeForm = new StatusyChangeForm();
            akrChangeForm.ShowDialog();

            if(akrChangeForm.czyZmodyfikowano)
            {
                ZaladujStatusyDGV();
            }
        }
    }
}
