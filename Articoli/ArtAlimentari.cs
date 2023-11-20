using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class ArtAlimentari : Art
    {
        protected DateTime _scadenza;
        public DateTime Scadenza { get { return _scadenza; } set { _scadenza = value; } }

        public ArtAlimentari() : base()
        {
            Scadenza = new DateTime(0, 0, 0);
        }

        public ArtAlimentari(int day, int month, int year, string codice, string des, float prezzo) : base(codice, des, prezzo)
        {
            Scadenza = new DateTime(day, month, year);
        }

        public override void sconto(bool fedelty)
        {
            base.sconto(fedelty);  

            if(Scadenza.Year - DateTime.Now.Year == 0)
            {
                Prezzo -= Prezzo / 100 * 20;
            }
        }

    }
}
