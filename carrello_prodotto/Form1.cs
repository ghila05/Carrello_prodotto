using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrello_prodotto
{
    public partial class Form1 : Form
    {
        public Prodotto p1;
        public Prodotto p2;
        public Prodotto p3;
        public Carrello C;
        public int primav = 0;
        bool prima = true;


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            p1 = new Prodotto("111", "Cuffie", "Soundcore", "cuffie bluetooth", 59);
            p2 = new Prodotto("222", "Power bank", "Anker", "powerbank ricarica veloce", 15);
            p3 = new Prodotto("333", "Smartwatch", "xiaomi", "smartwatch xiaomi bluetooth", 69);
            C = new Carrello("444");

            C.Aggiungi(p1);
            C.Aggiungi(p2);
            C.Aggiungi(p3); 
           
            if (prima == true)
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;

                listView1.Columns.Add("ID", 60);
                listView1.Columns.Add("NOME", 80);
                listView1.Columns.Add("PRODUTTORE", 100);
                listView1.Columns.Add("DESCRIZIONE", 100);
                listView1.Columns.Add("PREZZO", 60);
                listView1.Columns.Add("QUANTITA'", 70);


            }

            
        }

        private void Riempi(Prodotto v,bool uwu) //riempie listview utente

        {
            if (uwu)
            {
                listView1.Items.Add(Convert.ToString(v.Id));
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.Nome);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.Produttore);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.Descrizione);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString(v.Prezzo + " €"));
            }
            else
            {
                MessageBox.Show($"{listView1.Items.Count}");
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == v.Id)
                    {
                        if (listView1.Items[i].SubItems[listView1.Items[i].SubItems.Count-1].Text == "")
                            listView1.Items[i].SubItems[listView1.Items[i].SubItems.Count - 1].Text = "0"; //ancora da sistemare la quantità di prodotti uguali

                        listView1.Refresh();
                        //listView1.Items[i].SubItems[listView1.Items[i].SubItems.Count - 1].Text = $"{(int.Parse(listView1.Items[i].SubItems[listView1.Items[i].SubItems.Count - 1].Text) + 1)}";
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(primav == 0)
            {
                Riempi(p1, true);
            }
            else
            {
                Riempi(p1, false);
            }
            primav++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Riempi(p2,true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Riempi(p3,true);
        }
    }
}
