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
            this.codice_textbox = new System.Windows.Forms.MaskedTextBox();
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
            // codice_textbox
            // 
            this.codice_textbox.Location = new System.Drawing.Point(398, 70);
            this.codice_textbox.Mask = "99999";
            this.codice_textbox.Name = "codice_textbox";
            this.codice_textbox.Size = new System.Drawing.Size(100, 20);
            this.codice_textbox.TabIndex = 12;
            this.codice_textbox.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codice_textbox);
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
        private System.Windows.Forms.MaskedTextBox codice_textbox;
    }
}

