using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace HarjoitusTyo2
{
    /// <summary>
    /// Formi 3 on loggeri formi.
    /// Ohjelman data kirjoitetaan erilliseen ja loki tiedosto ladataan aina kun formi aukeaa.
    /// </summary>
    /// 
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataTable poyta = new DataTable();
        private void Form3_Load(object sender, EventArgs e)
        {//Koodi kesken
            /*
                        var lines = File.ReadAllLines("temp_lokitiedosto.txt");
                        if (lines.Count() > 0)
                        {
                            foreach (var columnName in lines.FirstOrDefault()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                            {
                                dataGridViewLoki.Columns.Add(columnName, columnName);
                            }
                            foreach (var cellValues in lines.Skip(1))
                            {
                                var cellArray = cellValues
                                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                if (cellArray.Length == dataGridViewLoki.Columns.Count)
                                    dataGridViewLoki.Rows.Add(cellArray);
                            }
                        }*/

            poyta.Columns.Add("Milloin teki");
            poyta.Columns.Add("Kuka teki");
            poyta.Columns.Add("Mitä teki");
            dataGridViewLoki.DataSource = poyta;
            string[] rivit = File.ReadAllLines(@"temp_lokitiedosto.txt");
            string[] arvot;
            for (int i = 0; i < rivit.Length; i++)
            {
                arvot = rivit[i].ToString().Split('/');
                string[] linja = new string[arvot.Length];

                for (int j = 0; j < arvot.Length; j++)
                {
                    linja[j] = arvot[j].Trim();
                }

               poyta.Rows.Add(linja);
            }
            dataGridViewLoki.Columns[0].Width = 250;
            dataGridViewLoki.Columns[1].Width = 250;
            dataGridViewLoki.Columns[2].Width = 500;
        }

        private void btnLogger_Click(object sender, EventArgs e)
        {

        }
    }
    }




            //if (File.Exists("temp_lokitiedosto.txt"))
            //{
            //    DataTable lokiPoyta = new DataTable();

            //    lokiPoyta.Columns.Add("Päivä", typeof(int));
            //    lokiPoyta.Columns.Add("Käyttäjä", typeof(string));
            //    lokiPoyta.Columns.Add("Viesti", typeof(string));

            //    dataGridViewLoki.DataSource = lokiPoyta;


                //string[] rivit = File.ReadAllLines(@"temp_lokitiedosto.txt");
                //string[] arvot;

                //for (int i = 0; i < rivit.Length; i++)
                //{
                //    arvot = rivit[i].ToString().Split(' ');
                //    string[] linja = new string[arvot.Length];

                //    for (int j = 0; j < arvot.Length; j++)
                //    {
                //        linja[j] = arvot[j].Trim();
                //    }

                //    lokiPoyta.Rows.Add(linja);
                //}
