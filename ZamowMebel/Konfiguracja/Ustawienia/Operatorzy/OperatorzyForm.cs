﻿using System;
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
    public partial class OperatorzyForm : Form
    {
        public OperatorzyForm()
        {
            InitializeComponent();

            ZaladujOperatorzyDGV();
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

        private void archiwalniCHB_CheckedChanged(object sender, EventArgs e)
        {
            ZaladujOperatorzyDGV();
        }

        private void ZaladujOperatorzyDGV()
        {
            operatorzyDGV.DataSource = null;
            operatorzyDGV.Rows.Clear();
            operatorzyDGV.Columns.Clear();

            changeButton.Enabled = false;
            delButton.Enabled = false;
            unlockButton.Enabled = false;

            DBRepository db = new DBRepository();
            String result = "";
            DataTable pomDataTable = new DataTable();

            if(db.OperatorzyForm_ZaladujOperatorzyDGV(ref pomDataTable, archiwalniCHB.Checked, ref result))
            {
                if(pomDataTable.Rows.Count > 0)
                {
                    operatorzyDGV.DataSource = pomDataTable;

                    operatorzyDGV.Columns["OPR_OprId"].Visible = false;
                    operatorzyDGV.Columns["OPR_Haslo"].Visible = false;
                    operatorzyDGV.CurrentCell = operatorzyDGV.Rows[0].Cells["OPR_Imie"];

                    changeButton.Enabled = true;
                    delButton.Enabled = true;
                    unlockButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania listy operatorów: " + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if(operatorzyDGV.CurrentCell != null)
            {
                String nazwaOperatora = operatorzyDGV.CurrentRow.Cells["OPR_Nazwisko"].Value.ToString() + " " + operatorzyDGV.CurrentRow.Cells["OPR_Imie"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć operatora '" + nazwaOperatora + "'?", "Zapytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.OK)
                {
                    DBRepository db = new DBRepository();
                    String result = "";
                    if(db.OperatorzyForm_UsunOperatora(operatorzyDGV.CurrentRow.Cells["OPR_OprId"].Value.ToString(), ref result))
                    {
                        MessageBox.Show("Usunięto '" + nazwaOperatora + "'.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZaladujOperatorzyDGV();
                    }
                    else
                    {
                        MessageBox.Show("Wystapił błąd podczas usuwania operatora '" + nazwaOperatora + "': " + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OperatorzyChangeForm oprChangeForm = new OperatorzyChangeForm();
            oprChangeForm.ShowDialog();

            if(oprChangeForm.czyZmodyfikowano)
            {
                ZaladujOperatorzyDGV();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(operatorzyDGV.CurrentCell != null)
            {
                String Opr_OprId = operatorzyDGV.CurrentRow.Cells["Opr_OprId"].Value.ToString();
                String Opr_Imie = operatorzyDGV.CurrentRow.Cells["Opr_Imie"].Value.ToString();
                String Opr_Nazwisko = operatorzyDGV.CurrentRow.Cells["Opr_Nazwisko"].Value.ToString();
                String Opr_Dzialy = operatorzyDGV.CurrentRow.Cells["OPR_Dzial"].Value.ToString();
                String Opr_Uprawnienia = operatorzyDGV.CurrentRow.Cells["OPR_Uprawnienia"].Value.ToString();
                String Opr_Archiwalny = operatorzyDGV.CurrentRow.Cells["Opr_Archiwalny"].Value.ToString();

                OperatorzyChangeForm oprChangeForm = new OperatorzyChangeForm(Opr_OprId, Opr_Imie, Opr_Nazwisko, Opr_Dzialy, Opr_Uprawnienia, Opr_Archiwalny);
                oprChangeForm.ShowDialog();

                if(oprChangeForm.czyZmodyfikowano)
                {
                    ZaladujOperatorzyDGV();
                }
            }
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            if(operatorzyDGV.CurrentCell != null)
            {
                String Opr_OprId = operatorzyDGV.CurrentRow.Cells["Opr_OprId"].Value.ToString();
                String result = "";
                DBRepository db = new DBRepository();

                if(db.OperatorzyForm_UsunHasloOperatora(Opr_OprId, ref result))
                {
                    ZaladujOperatorzyDGV();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podzczas kasowania hasła operatora: \n" + result, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano pracownika.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
