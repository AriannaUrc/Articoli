using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class Scontrino
    {
        public Articolo[] articoli;
        int dim = 0;

        public Scontrino()
        {
            articoli= new Articolo[100];
        }

        public Scontrino(int dimensione)
        {
            articoli = new Articolo[dimensione];
        }

        public void Aggiungi(Articolo art)
        {
            articoli[dim] = art;
            dim++;
        }

        public float Totale()
        {
            float tot = 0;

            for (int i = 0; i < dim; i++)
            {
                tot = articoli[i].Prezzo;
            }

            return tot;
        }


        public override string ToString()
        {
            string ret = "";

            for (int i = 0; i < dim; i++)
            {
                ret+= articoli[i].ToString() + ";";
            }

            return ret;
        }
    }
}
