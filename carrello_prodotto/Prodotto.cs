using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrello_prodotto
{
     public class Prodotto
     {
        private string _id, _nome, _produttore, _descrizione;
        private float _prezzo;

        public Prodotto(string id, string nome, string produttore, string descrizione)
        {
            Id = id;
            Nome = nome;
            Produttore = produttore;
            Descrizione = descrizione;
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
        public string Nome
        {
            get { 
                return _nome; 
            }
            set { 
                _nome = value; 
            }
        }
        public string Produttore
        {
            get { 
                return _produttore; 
            }
            set { 
                _produttore = value; 
            }
        }
        public string Descrizione
        {
            get { 
                return _descrizione; 
            }
            set { 
                _descrizione = value; 
            }
        }

        public void setPrezzo(float prezzo)
        {
            this._prezzo = prezzo;
        }
    }
}

