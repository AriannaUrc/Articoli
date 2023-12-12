using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class ArtAlimentari : Articolo
    {
        protected DateTime _scadenza;
        public DateTime Scadenza { get { return _scadenza; } set { _scadenza = value; } }

        public ArtAlimentari() : base()
        {
            Scadenza = new DateTime(0, 0, 0);
        }

        public ArtAlimentari(int day, int month, int year, string codice, string des, float prezzo, int quantita) : base(codice, des, prezzo, quantita)
        {
            Scadenza = new DateTime(year, month, day);
        }


        
        new public object Clone()
        {
            return this.MemberwiseClone();
        }


        //metodi equals e cmp
        public bool Equals(ArtAlimentari cmp)
        {
            if (Codice == cmp.Codice && Descrizione == cmp.Descrizione && Prezzo == cmp.Prezzo && Scadenza == cmp.Scadenza)
            {
                return true;
            }
            return false;
        }

        // Overriding the Equals(Object) method from the Object class
        public override bool Equals(object obj)
        {
            // Comparison of current data with the obj
            if (obj is ArtAlimentari)
                return Equals((ArtAlimentari)obj);
            return false;
        }

        // Overriding the GetHashCode() method from the Object class
        public override int GetHashCode()
        {
            return Prezzo.GetHashCode() + Descrizione.GetHashCode() + Codice.GetHashCode() + Scadenza.GetHashCode();
        }

        public override string ToString()
        {
            return Prezzo + " " + Descrizione + " " + Codice + " " + Scadenza;
        }

        public override float sconto(bool fedelty)
        {
            int sconto = 0;

            if (fedelty)
            {
                sconto = 5;
            }

            if (Scadenza.Year - DateTime.Now.Year == 0)
            {
                return Prezzo - (Prezzo / 100 * (20 + sconto));
            }

            if (fedelty) { return Prezzo - Prezzo / 100 * sconto; }

            return Prezzo;
        }

    }
}
