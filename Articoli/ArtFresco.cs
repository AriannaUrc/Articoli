using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class ArtFresco : ArtAlimentari
    {
        public ArtFresco() : base() { }

        public ArtFresco(int day, int month, int year, string codice, string des, float prezzo) : base(day, month, year, codice, des, prezzo) { }


        
        //metodi equals

        // Overriding the Equals(Object) method from the Object class
        public override bool Equals(object obj)
        {
            // Comparison of current data with the obj
            if (obj is ArtFresco)
                return Equals((ArtFresco)obj);
            return false;
        }

        // Overriding the GetHashCode() method from the Object class
        public override int GetHashCode()
        {
            return Prezzo.GetHashCode() + Descrizione.GetHashCode() + Codice.GetHashCode() + Scadenza.GetHashCode();
        }


        public override float sconto(bool fedelty)
        {

            int sconto = 0;

            if (fedelty)
            {
                sconto = 5;
            }

            if (Scadenza.Year == DateTime.Now.Year && Scadenza.Month == DateTime.Now.Month && Scadenza.Day - DateTime.Now.Day <= 5)
            {
                return Prezzo - Prezzo / 100 * ((12 - (Scadenza.Day - DateTime.Now.Day) * 2) + sconto);
            }

            if (fedelty) { return Prezzo - Prezzo / 100 * sconto; }

            return Prezzo;

        }
    }
}
