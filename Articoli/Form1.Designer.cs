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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.pos_textbox = new System.Windows.Forms.TextBox();
            this.prezzo_button = new System.Windows.Forms.Button();
            this.ordina_button = new System.Windows.Forms.Button();
            this.codice_textbox = new System.Windows.Forms.TextBox();
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
            this.label4.Location = new System.Drawing.Point(379, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Riciclabile";
            // 
            // riciclabile_checkbox
            // 
            this.riciclabile_checkbox.AutoSize = true;
            this.riciclabile_checkbox.Location = new System.Drawing.Point(398, 156);
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add artFresco";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Add artNonAlimentare";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(93, 278);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 140);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Posizione";
            // 
            // pos_textbox
            // 
            this.pos_textbox.Location = new System.Drawing.Point(398, 297);
            this.pos_textbox.Name = "pos_textbox";
            this.pos_textbox.Size = new System.Drawing.Size(100, 20);
            this.pos_textbox.TabIndex = 18;
            // 
            // prezzo_button
            // 
            this.prezzo_button.Location = new System.Drawing.Point(523, 297);
            this.prezzo_button.Name = "prezzo_button";
            this.prezzo_button.Size = new System.Drawing.Size(92, 23);
            this.prezzo_button.TabIndex = 20;
            this.prezzo_button.Text = "Controlla prezzo";
            this.prezzo_button.UseVisualStyleBackColor = true;
            // 
            // ordina_button
            // 
            this.ordina_button.Location = new System.Drawing.Point(93, 249);
            this.ordina_button.Name = "ordina_button";
            this.ordina_button.Size = new System.Drawing.Size(105, 23);
            this.ordina_button.TabIndex = 21;
            this.ordina_button.Text = "Ordina per prezzo";
            this.ordina_button.UseVisualStyleBackColor = true;
            // 
            // codice_textbox
            // 
            this.codice_textbox.Location = new System.Drawing.Point(398, 69);
            this.codice_textbox.Name = "codice_textbox";
            this.codice_textbox.Size = new System.Drawing.Size(100, 20);
            this.codice_textbox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codice_textbox);
            this.Controls.Add(this.ordina_button);
            this.Controls.Add(this.prezzo_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pos_textbox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pos_textbox;
        private System.Windows.Forms.Button prezzo_button;
        private System.Windows.Forms.Button ordina_button;
        private System.Windows.Forms.TextBox codice_textbox;
    }
}

