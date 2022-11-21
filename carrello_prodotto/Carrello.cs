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
        private Prodotto[] prodotti = new Prodotto[100];
        private int counter;

        public Carrello(string id)
        {
            Id = id;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Aggiungi(Prodotto p)
        {
            p.Id = prodotti[counter].Id;
            counter++;
        }
        public void Rimuovi(Prodotto p)
        {
            p.Id = prodotti[counter].Id;
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
