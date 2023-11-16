using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class Art
    {
        protected string _codice;
        protected string _descrizione;
        protected float _prezzo;

        public string Codice { get { return _codice; } set {_codice = value; } }
        public string Descrizione { get { return _descrizione; } set { _descrizione = value; } }

        public float Prezzo { get { return _prezzo; } set { if (_prezzo >= 0) { _prezzo = value; } else { _prezzo = 0; } } }


        public Art() 
        {
            Codice= "";
            Descrizione = "";
            Prezzo= 0;
        }

        public Art(string codice, string des, float prezzo)
        {
            Codice = codice;
            Descrizione = des;
            Prezzo = prezzo;
        }

        public bool Equals(Art cmp)
        {
            _codice = cmp._codice;

            return true;

        }


        public virtual void sconto(bool fedelty)
        {
            if(fedelty)
            {
                Prezzo -= Prezzo / 100 * 5;
            }
        }
    }
}
