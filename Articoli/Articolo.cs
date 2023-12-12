using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    
    internal class Articolo : ICloneable
    {
        private string _codice;
        private string _descrizione;
        private float _prezzo;
        private int _quantita;


        public string Codice { get { return _codice; } set {_codice = value; } }
        public string Descrizione { get { return _descrizione; } set { _descrizione = value; } }
        public int Quantita { get { return _quantita; } set { if (value > 0) { _quantita = value; } else { _quantita = 0; } } }

        public float Prezzo { get { return _prezzo; } set { if (_prezzo >= 0) { _prezzo = value; } else { _prezzo = 0; } } }


        public Articolo() 
        {
            Codice= "";
            Descrizione = "";
            Prezzo= 0;
            Quantita = 0;
        }

        public Articolo(string codice, string des, float prezzo, int quantita)
        {
            Codice = codice;
            Descrizione = des;
            Prezzo = prezzo;
            Quantita= quantita;

        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int Compare(Articolo obj)
        {
            if(Prezzo*Quantita < obj.Prezzo * obj._quantita) { return -1; }
            else if(Prezzo*Prezzo > obj.Prezzo * obj._quantita) { return 1; }
            return 0;
        }

        //metodi equals e cmp
        public bool Equals(Articolo cmp)
        {
            if(Codice == cmp.Codice && Descrizione == cmp.Descrizione && Prezzo == cmp.Prezzo)
            {
                return true;
            }
            return false;
        }

        // Overriding the Equals(Object) method from the Object class
        public override bool Equals(object obj)
        {
            // Comparison of current data with the obj
            if (obj is Articolo)
                return Equals((Articolo)obj);
            return false;
        }

        // Overriding the GetHashCode() method from the Object class
        public override int GetHashCode()
        {
            return Prezzo.GetHashCode() + Descrizione.GetHashCode() + Codice.GetHashCode();
        }

        public override string ToString()
        {
            return Prezzo + " " + Descrizione + " " + Codice;
        }

        public virtual float sconto(bool fedelty)
        {
            if(fedelty)
            {
                 return Prezzo - ( Prezzo / 100 * 5);
            }
            return Prezzo;
        }
    }
}
