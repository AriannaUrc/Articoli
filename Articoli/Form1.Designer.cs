namespace Articoli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.prezzo_textbox = new System.Windows.Forms.TextBox();
            this.des_textbox = new System.Windows.Forms.TextBox();
            this.Prezzo_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.riciclabile_checkbox = new System.Windows.Forms.CheckBox();
            this.scadenza_textbox = new System.Windows.Forms.MaskedTextBox();
            this.add_art_button = new System.Windows.Forms.Button();
            this.add_art_alimentare_button = new System.Windows.Forms.Button();
            this.add_articoloFresco_button = new System.Windows.Forms.Button();
            this.art_non_alimentare_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ordina_button = new System.Windows.Forms.Button();
            this.codice_textbox = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.fedelity_check = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tot_button1 = new System.Windows.Forms.Button();
            this.quantita_textbox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prezzo_textbox
            // 
            this.prezzo_textbox.Location = new System.Drawing.Point(125, 70);
            this.prezzo_textbox.Name = "prezzo_textbox";
            this.prezzo_textbox.Size = new System.Drawing.Size(100, 20);
            this.prezzo_textbox.TabIndex = 0;
            // 
            // des_textbox
            // 
            this.des_textbox.Location = new System.Drawing.Point(258, 70);
            this.des_textbox.Name = "des_textbox";
            this.des_textbox.Size = new System.Drawing.Size(100, 20);
            this.des_textbox.TabIndex = 1;
            // 
            // Prezzo_label
            // 
            this.Prezzo_label.AutoSize = true;
            this.Prezzo_label.Location = new System.Drawing.Point(150, 54);
            this.Prezzo_label.Name = "Prezzo_label";
            this.Prezzo_label.Size = new System.Drawing.Size(39, 13);
            this.Prezzo_label.TabIndex = 3;
            this.Prezzo_label.Text = "Prezzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrizione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scadenza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Riciclabile";
            // 
            // riciclabile_checkbox
            // 
            this.riciclabile_checkbox.AutoSize = true;
            this.riciclabile_checkbox.Location = new System.Drawing.Point(364, 156);
            this.riciclabile_checkbox.Name = "riciclabile_checkbox";
            this.riciclabile_checkbox.Size = new System.Drawing.Size(15, 14);
            this.riciclabile_checkbox.TabIndex = 10;
            this.riciclabile_checkbox.UseVisualStyleBackColor = true;
            // 
            // scadenza_textbox
            // 
            this.scadenza_textbox.Location = new System.Drawing.Point(183, 156);
            this.scadenza_textbox.Mask = "00/00/0000";
            this.scadenza_textbox.Name = "scadenza_textbox";
            this.scadenza_textbox.Size = new System.Drawing.Size(100, 20);
            this.scadenza_textbox.TabIndex = 11;
            this.scadenza_textbox.ValidatingType = typeof(System.DateTime);
            // 
            // add_art_button
            // 
            this.add_art_button.Location = new System.Drawing.Point(569, 44);
            this.add_art_button.Name = "add_art_button";
            this.add_art_button.Size = new System.Drawing.Size(125, 23);
            this.add_art_button.TabIndex = 13;
            this.add_art_button.Text = "Add Articolo";
            this.add_art_button.UseVisualStyleBackColor = true;
            this.add_art_button.Click += new System.EventHandler(this.add_art_button_Click);
            // 
            // add_art_alimentare_button
            // 
            this.add_art_alimentare_button.Location = new System.Drawing.Point(569, 94);
            this.add_art_alimentare_button.Name = "add_art_alimentare_button";
            this.add_art_alimentare_button.Size = new System.Drawing.Size(125, 23);
            this.add_art_alimentare_button.TabIndex = 14;
            this.add_art_alimentare_button.Text = "Add artAlimentare";
            this.add_art_alimentare_button.UseVisualStyleBackColor = true;
            this.add_art_alimentare_button.Click += new System.EventHandler(this.add_art_alimentare_button_Click);
            // 
            // add_articoloFresco_button
            // 
            this.add_articoloFresco_button.Location = new System.Drawing.Point(569, 147);
            this.add_articoloFresco_button.Name = "add_articoloFresco_button";
            this.add_articoloFresco_button.Size = new System.Drawing.Size(125, 23);
            this.add_articoloFresco_button.TabIndex = 15;
            this.add_articoloFresco_button.Text = "Add artFresco";
            this.add_articoloFresco_button.UseVisualStyleBackColor = true;
            this.add_articoloFresco_button.Click += new System.EventHandler(this.add_articoloFresco_button_Click);
            // 
            // art_non_alimentare_button
            // 
            this.art_non_alimentare_button.Location = new System.Drawing.Point(569, 195);
            this.art_non_alimentare_button.Name = "art_non_alimentare_button";
            this.art_non_alimentare_button.Size = new System.Drawing.Size(125, 23);
            this.art_non_alimentare_button.TabIndex = 16;
            this.art_non_alimentare_button.Text = "Add artNonAlimentare";
            this.art_non_alimentare_button.UseVisualStyleBackColor = true;
            this.art_non_alimentare_button.Click += new System.EventHandler(this.art_non_alimentare_button_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(93, 254);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 140);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // ordina_button
            // 
            this.ordina_button.Location = new System.Drawing.Point(468, 249);
            this.ordina_button.Name = "ordina_button";
            this.ordina_button.Size = new System.Drawing.Size(105, 23);
            this.ordina_button.TabIndex = 21;
            this.ordina_button.Text = "Ordina per prezzo";
            this.ordina_button.UseVisualStyleBackColor = true;
            this.ordina_button.Click += new System.EventHandler(this.ordina_button_Click);
            // 
            // codice_textbox
            // 
            this.codice_textbox.Location = new System.Drawing.Point(398, 69);
            this.codice_textbox.Name = "codice_textbox";
            this.codice_textbox.Size = new System.Drawing.Size(100, 20);
            this.codice_textbox.TabIndex = 22;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(468, 278);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(246, 140);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // fedelity_check
            // 
            this.fedelity_check.AutoSize = true;
            this.fedelity_check.Location = new System.Drawing.Point(468, 156);
            this.fedelity_check.Name = "fedelity_check";
            this.fedelity_check.Size = new System.Drawing.Size(15, 14);
            this.fedelity_check.TabIndex = 25;
            this.fedelity_check.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fedelity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Scontrino";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(194, 409);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(145, 29);
            this.listView3.TabIndex = 27;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // tot_button1
            // 
            this.tot_button1.Location = new System.Drawing.Point(345, 409);
            this.tot_button1.Name = "tot_button1";
            this.tot_button1.Size = new System.Drawing.Size(80, 23);
            this.tot_button1.TabIndex = 28;
            this.tot_button1.Text = "Totale";
            this.tot_button1.UseVisualStyleBackColor = true;
            this.tot_button1.Click += new System.EventHandler(this.tot_button1_Click);
            // 
            // quantita_textbox
            // 
            this.quantita_textbox.Location = new System.Drawing.Point(51, 156);
            this.quantita_textbox.Mask = "99999";
            this.quantita_textbox.Name = "quantita_textbox";
            this.quantita_textbox.Size = new System.Drawing.Size(100, 20);
            this.quantita_textbox.TabIndex = 29;
            this.quantita_textbox.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quantità";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantita_textbox);
            this.Controls.Add(this.tot_button1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fedelity_check);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.codice_textbox);
            this.Controls.Add(this.ordina_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.art_non_alimentare_button);
            this.Controls.Add(this.add_articoloFresco_button);
            this.Controls.Add(this.add_art_alimentare_button);
            this.Controls.Add(this.add_art_button);
            this.Controls.Add(this.scadenza_textbox);
            this.Controls.Add(this.riciclabile_checkbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prezzo_label);
            this.Controls.Add(this.des_textbox);
            this.Controls.Add(this.prezzo_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prezzo_textbox;
        private System.Windows.Forms.TextBox des_textbox;
        private System.Windows.Forms.Label Prezzo_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox riciclabile_checkbox;
        private System.Windows.Forms.MaskedTextBox scadenza_textbox;
        private System.Windows.Forms.Button add_art_button;
        private System.Windows.Forms.Button add_art_alimentare_button;
        private System.Windows.Forms.Button add_articoloFresco_button;
        private System.Windows.Forms.Button art_non_alimentare_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ordina_button;
        private System.Windows.Forms.TextBox codice_textbox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.CheckBox fedelity_check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button tot_button1;
        private System.Windows.Forms.MaskedTextBox quantita_textbox;
        private System.Windows.Forms.Label label7;
    }
}

