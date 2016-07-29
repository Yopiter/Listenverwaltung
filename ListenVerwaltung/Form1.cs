using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ListenVerwaltung
{
    public partial class Form1 : Form
    {
        int KNummer;
        List<String> ImportList;
        int rowNum;
        public Form1()
        {
            InitializeComponent();
            KNummer = (int)NKFach.Value;
            TableAkt();
        }

        private void Import()
        {
            if(File.Exists("Data/" + KNummer.ToString() + ".dat")) ImportList = File.ReadAllLines("Data/" + KNummer.ToString() + ".dat").ToList();
        }

        private void TableAkt()
        {
            Import();
            Tb.Rows.Clear();
            foreach (String str in ImportList)
            {
                if(str!="|||")Tb.Rows.Add(str.Split('|'));
            }
        }

        private void NKFach_ValueChanged(object sender, EventArgs e)
        {
            KNummer = (int)NKFach.Value;
            TableAkt();
        }

        private void BT_down_Click(object sender, EventArgs e)
        {
            NKFach.DownButton();
        }

        private void BT_up_Click(object sender, EventArgs e)
        {
            NKFach.UpButton();
        }

        private void Save()
        {
            File.Delete("Data/" + KNummer.ToString() + ".dat");
            List<String> SaveList = new List<string>();
            foreach (DataGridViewRow row in Tb.Rows)
            {
                SaveList.Add(row.Cells[0].Value + "|" + row.Cells[1].Value + "|" + row.Cells[2].Value+"|"+row.Cells[3].Value);
            }
            File.WriteAllLines("Data/" + KNummer.ToString() + ".dat", SaveList);
        }

        private void Tb_Leave(object sender, EventArgs e)
        {
            Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Tb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowNum = e.RowIndex;
                AnzAnzeigen();
            }
        }

        private void AnzAnzeigen()
        {
            try
            {
                LBAnz.Text = (string)Tb.Rows[rowNum].Cells[2].Value.ToString();
            }
            catch (Exception ex) { ex.GetType(); }
        }

        private void BT_use_Click(object sender, EventArgs e)
        {
            try{
                Tb.Rows[rowNum].Cells[2].Value= int.Parse(Tb.Rows[rowNum].Cells[2].Value.ToString())-1;
                if (int.Parse(Tb.Rows[rowNum].Cells[2].Value.ToString()) < 1) { Tb.Rows.RemoveAt(rowNum); }
            }
            catch(Exception ex){MessageBox.Show("Fehler beim Abziehen: "+ex.Message);}
            AnzAnzeigen();
            Save();
        }

        private void BT_store_Click(object sender, EventArgs e)
        {
            try
            {
                Tb.Rows[rowNum].Cells[2].Value = int.Parse(Tb.Rows[rowNum].Cells[2].Value.ToString()) + 1;
            }
            catch (Exception ex) { MessageBox.Show("Fehler beim Zugeben: " + ex.Message); }
            AnzAnzeigen();
            Save();
        }
    }
}
