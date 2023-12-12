using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Articoli.Form1;

namespace Articoli
{
    internal class Scontrino
    {
        public Articolo[] articoli;
        int dim = 0;

        public Scontrino()
        {
            articoli = new Articolo[100];
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
                ret += articoli[i].ToString() + ";";
            }

            return ret;
        }


        private void ordina(object sender, EventArgs e)
        {

            int n = dim;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (articoli[j].Compare(articoli[j + 1]) != 1)
                    {
                        var tempVar = articoli[j];
                        articoli[j] = articoli[j + 1];
                        articoli[j + 1] = tempVar;
                    }
                }

            }

        }


        public int Trova(string cod)
        {
            int ret = -1;

            for (int i = 0; i < dim; i++)
            {
                if(cod == articoli[i].Codice)
                {
                    ret = i;
                    break;
                }
            }
            return ret;
        }

        public float Calcola(string cod)
        {
            float ret = -1;

            for (int i = 0; i < dim; i++)
            {
                if (cod == articoli[i].Codice)
                {
                    ret = articoli[i].Prezzo*articoli[i].Quantita;
                    break;
                }
            }
            return ret;
        }

    }
}
