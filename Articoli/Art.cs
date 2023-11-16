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

        public float Prezzo { get { return _prezzo; } set { _prezzo = value; } }
    }
}
