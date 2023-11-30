using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articoli
{
    public partial class Form1 : Form
    {

        public struct elScontrino
        {
            public string nome { get; set; }
            public float prezzo { get; set; }
            public float importo { get; set; }
            public int sconto { get; set; }
        }

        Articolo[] scontrino;
        int numElementi;

        public Form1()
        {
            InitializeComponent();
            scontrino= new Articolo[10000];
            numElementi=0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void add_art_button_Click(object sender, EventArgs e)
        {
            Articolo art = new Articolo(codice_textbox.Text, des_textbox.Text, float.Parse(prezzo_textbox.Text));
            scontrino[numElementi] = new Articolo(art.Codice, art.Descrizione, art.sconto(fedelity_check.Checked));
            numElementi++;
            listView1.Items.Add("Nome: " + scontrino[numElementi-1].Codice + " Prezzo: " + scontrino[numElementi-1].Prezzo + " Sconto: "+ (100 - scontrino[numElementi - 1].sconto(fedelity_check.Checked) * 100 / scontrino[numElementi - 1].Prezzo) + "% Importo: " + scontrino[numElementi - 1].sconto(fedelity_check.Checked));
        }

        private void add_art_alimentare_button_Click(object sender, EventArgs e)
        {
            ArtAlimentari tmp = new ArtAlimentari(int.Parse(scadenza_textbox.Text.Substring(0, 2)), int.Parse(scadenza_textbox.Text.Substring(3, 2)), int.Parse(scadenza_textbox.Text.Substring(6, 4)), codice_textbox.Text, des_textbox.Text, float.Parse(prezzo_textbox.Text));
            scontrino[numElementi] = new Articolo(tmp.Codice, tmp.Descrizione, tmp.sconto(fedelity_check.Checked));
            numElementi++;

            listView1.Items.Add("Nome: " + scontrino[numElementi - 1].Codice + " Prezzo: " + scontrino[numElementi - 1].Prezzo + " Sconto: " + (100 - tmp.sconto(fedelity_check.Checked) * 100 / scontrino[numElementi - 1].Prezzo) + "% Importo: " + tmp.sconto(fedelity_check.Checked));
        }

        private void add_articoloFresco_button_Click(object sender, EventArgs e)
        {
            ArtFresco tmp = new ArtFresco(int.Parse(scadenza_textbox.Text.Substring(0, 2)), int.Parse(scadenza_textbox.Text.Substring(3, 2)), int.Parse(scadenza_textbox.Text.Substring(6, 4)), codice_textbox.Text, des_textbox.Text, float.Parse(prezzo_textbox.Text));
            scontrino[numElementi] = new Articolo(tmp.Codice, tmp.Descrizione, tmp.sconto(fedelity_check.Checked));
            numElementi++;

            listView1.Items.Add("Nome: " + scontrino[numElementi - 1].Codice + " Prezzo: " + scontrino[numElementi - 1].Prezzo + " Sconto: " + (100 - tmp.sconto(fedelity_check.Checked) * 100 / scontrino[numElementi - 1].Prezzo) + "% Importo: " + tmp.sconto(fedelity_check.Checked));
        }

        private void art_non_alimentare_button_Click(object sender, EventArgs e)
        {
            ArtNonAlimentare tmp = new ArtNonAlimentare(riciclabile_checkbox.Checked, codice_textbox.Text, des_textbox.Text, float.Parse(prezzo_textbox.Text));
            scontrino[numElementi] = new Articolo(tmp.Codice, tmp.Descrizione, tmp.sconto(fedelity_check.Checked));
            numElementi++;

            listView1.Items.Add("Nome: " + scontrino[numElementi - 1].Codice + " Prezzo: " + scontrino[numElementi - 1].Prezzo + " Sconto: " + (100 - tmp.sconto(fedelity_check.Checked) * 100 / scontrino[numElementi - 1].Prezzo) + "% Importo: " + tmp.sconto(fedelity_check.Checked));
        }

        private void ordina_button_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            
            int n = numElementi;

            for (int i = 0; i < n - 1; i++)
               for (int j = 0; j < n - i - 1; j++)
                   if (scontrino[j].Compare(scontrino[j + 1]) != 1)
                   {
                       var tempVar = scontrino[j];
                       scontrino[j] = scontrino[j + 1];
                       scontrino[j + 1] = tempVar;
                   }

            for(int i=0;i<n; i++)
            {
                listView2.Items.Add("Nome: " + scontrino[i].Codice + " Prezzo: " + scontrino[i].Prezzo);
            }
            
        }

        private void tot_button1_Click(object sender, EventArgs e)
        {
            float tot = 0;
            for(int i= 0; i<numElementi;i++)
            {
                tot = scontrino[i].Prezzo;
            }

            listView3.Items.Clear();
            listView3.Items.Add("Totale: " + tot.ToString("0.00"));
        }
    }

    
}
