using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class ArtNonAlimentare : Articolo
    {
        private bool _riciclabile;
        public bool Riciclabile { get { return _riciclabile; } set { _riciclabile = value; } }

        public ArtNonAlimentare() : base() 
        {
            _riciclabile = false;
        }

        public ArtNonAlimentare(bool ric, string codice, string des, float prezzo) : base(codice, des, prezzo)
        {
            Riciclabile = ric;
        }

        new public object Clone()
        {
            return this.MemberwiseClone();
        }


        //metodi equals e cmp
        public bool Equals(ArtNonAlimentare cmp)
        {
            if (Codice == cmp.Codice && Descrizione == cmp.Descrizione && Prezzo == cmp.Prezzo && Riciclabile == cmp.Riciclabile)
            {
                return true;
            }
            return false;
        }

        // Overriding the Equals(Object) method from the Object class
        public override bool Equals(object obj)
        {
            // Comparison of current data with the obj
            if (obj is ArtNonAlimentare)
                return Equals((ArtNonAlimentare)obj);
            return false;
        }

        // Overriding the GetHashCode() method from the Object class
        public override int GetHashCode()
        {
            return Prezzo.GetHashCode() + Descrizione.GetHashCode() + Codice.GetHashCode() + Riciclabile.GetHashCode();
        }


        public override string to_string()
        {
            return Prezzo + " " + Descrizione + " " + Codice + " " + Riciclabile;
        }


        public override float sconto(bool fedelty)
        {

            int sconto = 0;

            if (fedelty)
            {
                sconto = 5;
            }

            if (Riciclabile)
            {
                return Prezzo - Prezzo / 100 * (20 + sconto);
            }

            if (fedelty) { return Prezzo - Prezzo / 100 * sconto; }

            return Prezzo;

        }

    }
}
