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

        elScontrino[] scontrino;
        int numElementi;

        public Form1()
        {
            InitializeComponent();
            scontrino= new elScontrino[10000];
            numElementi=0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void add_art_button_Click(object sender, EventArgs e)
        {
            Articolo art = new Articolo(codice_textbox.Text, des_textbox.Text, float.Parse(prezzo_textbox.Text));
            elScontrino tempEl = new elScontrino();
            numElementi++;
            //scontrino.Add(tempEl);
        }
    }

    
}
