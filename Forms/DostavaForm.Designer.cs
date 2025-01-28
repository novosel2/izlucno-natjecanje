namespace IzlucnoNatjecanje.assets
{
    partial class DostavaForm
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.comboMetode = new System.Windows.Forms.ComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSucceed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnPovratak.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnPovratak.ForeColor = System.Drawing.Color.Black;
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(126, 46);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // comboMetode
            // 
            this.comboMetode.FormattingEnabled = true;
            this.comboMetode.Location = new System.Drawing.Point(214, 129);
            this.comboMetode.Name = "comboMetode";
            this.comboMetode.Size = new System.Drawing.Size(363, 21);
            this.comboMetode.TabIndex = 1;
            this.comboMetode.Text = "Odaberi metodu dostave...";
            this.comboMetode.SelectedIndexChanged += new System.EventHandler(this.comboMetode_SelectedIndexChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblLoading.Location = new System.Drawing.Point(335, 129);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(89, 22);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(214, 201);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(172, 20);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Visible = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(171, 204);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv:";
            this.lblNaziv.Visible = false;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(401, 204);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 6;
            this.lblCijena.Text = "Cijena:";
            this.lblCijena.Visible = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(446, 201);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(131, 20);
            this.txtCijena.TabIndex = 5;
            this.txtCijena.Visible = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnSpremi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(214, 249);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(363, 37);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi promjene";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Visible = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metoda Dostave:";
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(171, 233);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(450, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "error text";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblSucceed
            // 
            this.lblSucceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(120)))));
            this.lblSucceed.Location = new System.Drawing.Point(171, 289);
            this.lblSucceed.Name = "lblSucceed";
            this.lblSucceed.Size = new System.Drawing.Size(450, 13);
            this.lblSucceed.TabIndex = 4;
            this.lblSucceed.Text = "Promjene spremljene!";
            this.lblSucceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSucceed.Visible = false;
            // 
            // DostavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSucceed);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.comboMetode);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnPovratak);
            this.Name = "DostavaForm";
            this.Text = "Dostava";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DostavaForm_FormClosed);
            this.Load += new System.EventHandler(this.DostavaForm_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.ComboBox comboMetode;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSucceed;
    }
}