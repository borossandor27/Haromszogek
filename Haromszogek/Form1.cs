using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
    public partial class Form1 : Form
    {
        List<DHaromszog> Haromszogek = new List<DHaromszog>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Adatbetoltes_Click(object sender, EventArgs e)
        {
            //-- Az elemek nullázása ---------------------------------------------------------
            Haromszogek.Clear();
            listBox_Derekszogek.Items.Clear();
            listBox_Hibak.Items.Clear();
            label_Kerulet.Text = "Kerület = ";
            label_Terulet.Text = "Terület = ";
            
            //-- Szövegállomány megnyitása ---------------------------------------------------
            openFileDialog1.Filter = "Minden fájl (*.*)|*.*|Szövegfájlok (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = "haromszogek.txt";
            //openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"\..\..";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //-- a fájl tartalmának beolvasása
                try
                {
                    int ssz = 0;
                    string maszk= "#,##0.00";   //-- a listában az oladalk hossza két tizedessel jelenjen meg!
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        while (!sr.EndOfStream)
                        {
                            try
                            {
                                DHaromszog uj = new DHaromszog(sr.ReadLine(), ++ssz);
                                Haromszogek.Add(uj);    //-- Csak hibátlan elemeket kell tárolni! --------------------
                                listBox_Derekszogek.Items.Add(string.Join(" ", string.Format("{0,4}", uj.SorSzama) + ". sor: a=", uj.a.ToString(maszk), "b=", uj.b.ToString(maszk), "c=", uj.c.ToString(maszk)));
                            }
                            catch (SajatHibakezelo ex)
                            {
                                listBox_Hibak.Items.Add(ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBox_Derekszogek_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ssz = int.Parse(listBox_Derekszogek.SelectedItem.ToString().Split('.')[0].Trim());
            DHaromszog kivalasztott = Haromszogek.Find(h => h.SorSzama == ssz);
            label_Kerulet.Text = "Kerület = " + kivalasztott.Kerulet.ToString("0.00");
            label_Terulet.Text = "Terület = " + kivalasztott.Terulet.ToString("0.00");
        }
    }
}
