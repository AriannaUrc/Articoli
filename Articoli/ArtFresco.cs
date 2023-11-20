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

        public override void sconto(bool fedelty)
        {
            base.sconto(fedelty);
            if(Scadenza.Year == DateTime.Now.Year && Scadenza.Month == DateTime.Now.Month && Scadenza.Day - DateTime.Now.Day <= 5)
            {
                Prezzo -= Prezzo / 100 * (12 - (Scadenza.Day - DateTime.Now.Day) * 2);
            }
            
        }
    }
}
