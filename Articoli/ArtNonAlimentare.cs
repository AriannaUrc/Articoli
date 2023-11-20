using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class ArtNonAlimentare : Art
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

        public override void sconto(bool fedelty)
        {
            base.sconto(fedelty);
            if(Riciclabile)
            {
                Prezzo -= Prezzo / 100 * 20;
            }

        }

    }
}
