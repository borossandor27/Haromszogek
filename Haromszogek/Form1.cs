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
                            DHaromszog uj = new DHaromszog(sr.ReadLine(), ++ssz);
                            Haromszogek.Add(uj);
                            if (uj.EllDerekszogu && uj.EllMegszerkesztheto && uj.EllNovekvosorrend && uj.a > 0 && uj.b > 0 && uj.c > 0)
                            {
                                listBox_Derekszogek.Items.Add(string.Join(" ", string.Format("{0,4}", uj.SorSzama) + ". sor: a=", uj.a.ToString(maszk), "b=", uj.b.ToString(maszk), "c=", uj.c.ToString(maszk)));
                            }
                            else
                            {
                                listBox_Hibak.Items.Add(Hibaszoveg(uj));
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

        private string Hibaszoveg(DHaromszog hibas)
        {
            string szoveg = string.Format("{0,3}", hibas.SorSzama) + ". sor: ";
            if (!hibas.EllDerekszogu)
            {
                szoveg += "A háromszög nem derékszögű!";
            }
            else if (hibas.a <= 0)
            {
                szoveg += "Az 'a' oldal nem lehet nulla vagy negatív!";
            }
            else if (hibas.b <= 0)
            {
                szoveg += "A 'b' oldal nem lehet nulla vagy negatív!";
            }
            else if (hibas.c <= 0)
            {
                szoveg += "A 'c' oldal nem lehet nulla vagy negatív!";
            }
            else if (!hibas.EllMegszerkesztheto)
            {
                szoveg += "A háromszöget nem lehet megszerkeszteni!";
            }
            else if (!hibas.EllNovekvosorrend)
            {
                szoveg += "Az adatok nincsenek növekvő sorrendben!";
            }
            return szoveg;
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
