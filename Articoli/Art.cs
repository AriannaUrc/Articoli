﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli
{
    internal class Art : ICloneable
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


        public object Clone()
        {
            return this.MemberwiseClone();
        }


        //metodi equals e cmp
        public bool Equals(Art cmp)
        {
            if(Codice == cmp.Codice && Descrizione == cmp.Descrizione && Prezzo == cmp.Prezzo)
            {
                return true;
            }
            return false;
        }

        // Overriding the Equals(Object) method from the Object class
        public override bool Equals(object obj)
        {
            // Comparison of current data with the obj
            if (obj is Art)
                return Equals((Art)obj);
            return false;
        }

        // Overriding the GetHashCode() method from the Object class
        public override int GetHashCode()
        {
            return Prezzo.GetHashCode() + Descrizione.GetHashCode() + Codice.GetHashCode();
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
