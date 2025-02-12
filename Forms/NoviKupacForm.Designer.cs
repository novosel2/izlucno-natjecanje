namespace IzlucnoNatjecanje.Forms
{
    partial class NoviKupacForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTitula = new System.Windows.Forms.TextBox();
            this.textIme = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTitula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitula
            // 
            this.textTitula.Location = new System.Drawing.Point(170, 125);
            this.textTitula.Name = "textTitula";
            this.textTitula.Size = new System.Drawing.Size(155, 20);
            this.textTitula.TabIndex = 0;
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(118, 161);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(207, 20);
            this.textIme.TabIndex = 2;
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(118, 197);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(207, 20);
            this.textPrezime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titula:";
            // 
            // comboTitula
            // 
            this.comboTitula.FormattingEnabled = true;
            this.comboTitula.Location = new System.Drawing.Point(118, 124);
            this.comboTitula.Name = "comboTitula";
            this.comboTitula.Size = new System.Drawing.Size(46, 21);
            this.comboTitula.TabIndex = 5;
            this.comboTitula.SelectedIndexChanged += new System.EventHandler(this.comboTitula_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(138, 238);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(156, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // NoviKupacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(418, 411);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTitula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.textTitula);
            this.Name = "NoviKupacForm";
            this.Text = "NoviKupacForm";
            this.Load += new System.EventHandler(this.NoviKupacForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitula;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTitula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
    }
}