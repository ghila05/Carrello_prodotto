using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrello_prodotto
{
     public class Carrello
     {
        private string _id;
        private Prodotto[] prodotti; 
        private int counter;

        public Carrello(string id)
        {
            Id = id;
            prodotti = new Prodotto[999];
        }

        public string Id
        {
            get { 
                return _id; 
            }
            set { 
                _id = value; 
            }
        }

        public void Aggiungi(Prodotto p)
        {
            prodotti[counter]=p;
            counter++;
        }
        public void Rimuovi(Prodotto p)
        {
            for(int i=0; i <prodotti.Length; i++)
            {
                if (prodotti[i] == p)
                {
                    prodotti[i] = null;
                }

            }

            counter--;
        }
        public int getProdotti()
        {
            return counter;
        }
        public void Svuota()
        {
            for (int i = 0; i < counter; i++)
                prodotti[i] = null;
            counter = 0;
        }

    }
}
