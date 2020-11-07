using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201104_Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Feltoltes();
        }
        private string strParatlan = "Páratlan elemek összege: ";
        private string strFoatlo = "Főátló elemeinek összege: ";
        private string strSorok = "Sorok összege: ";
        private string strOszlopok = "Oszlopok összege: ";

        private int meret = 3;

        Random rnd = new Random();

        private void Feltoltes()
        {
            labelParatlan .Text = strParatlan;
            labelFoatlo.Text = strFoatlo;
            labelSorok.Text = strSorok;
            labelOszlopok.Text = strOszlopok;
        }

        private void dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mniGen_Click(object sender, EventArgs e)
        {
            int szam;
            dgw1.Rows.Clear();
            for (int i = 0; i < meret; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                for (int j = 0; j < meret; j++)
                {
                    szam = rnd.Next(10) + 10;
                    DataGridViewCell dc = new DataGridViewTextBoxCell();
                    dc.Value = szam;
                    r.Cells.Add(dc);
                }

                dgw1.Rows.Add(r);
            }
        }

        private void mniParatlan_Click(object sender, EventArgs e)
        {
            int paratlan = 0, szam;
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    szam = (int)dgw1.Rows[j].Cells[i].Value;
                    if (szam % 2 == 0)
                    {
                        paratlan += szam;
                    }
                }
            }
        }

        private void mniFoatlo_Click(object sender, EventArgs e)
        {
            int p = 0;
            for (int i = 0; i < meret; i++)
            {
                p += (int)dgw1.Rows[i].Cells[i].Value;
            }
            //Főátló összegének kiíratása
        }

        private void mniSorok_Click(object sender, EventArgs e)
        {
            int paratlan = 0, szam;
            for (int i = 0; i < meret; i++)
            {
                paratlan = 0;
                for (int j = 0; j < meret; j++)
                {
                    paratlan += (int)dgw1.Rows[i].Cells[j].Value;
                }
                //Kiíratás a sor összegének
            }
        }

        private void mniOszlopok_Click(object sender, EventArgs e)
        {
            int paratlan = 0, szam;
            for (int i = 0; i < meret; i++)
            {
                paratlan = 0;
                for (int j = 0; j < meret; j++)
                {
                    paratlan += (int)dgw1.Rows[j].Cells[i].Value;
                }
                //Kiíratás az oszlop összegének
            }
        }

        private void mniTransz_Click(object sender, EventArgs e)
        {
            int[,] tomb = new int[meret, meret];
            //Tömb feltöltése és visszafelé kiíratás a dataGridView-ba
        }
    }
}
