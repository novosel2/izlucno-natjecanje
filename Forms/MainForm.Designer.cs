namespace IzlucnoNatjecanje
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuDostava = new System.Windows.Forms.MenuItem();
            this.menuProizvodi = new System.Windows.Forms.MenuItem();
            this.menuKupci = new System.Windows.Forms.MenuItem();
            this.menuIzvjestaji = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKupci = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnDostava = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDostava,
            this.menuProizvodi,
            this.menuKupci,
            this.menuIzvjestaji});
            // 
            // menuDostava
            // 
            this.menuDostava.Index = 0;
            this.menuDostava.Text = "Dostava";
            this.menuDostava.Click += new System.EventHandler(this.menuDostava_Click);
            // 
            // menuProizvodi
            // 
            this.menuProizvodi.Index = 1;
            this.menuProizvodi.Text = "Proizvodi";
            this.menuProizvodi.Click += new System.EventHandler(this.menuProizvodi_Click);
            // 
            // menuKupci
            // 
            this.menuKupci.Index = 2;
            this.menuKupci.Text = "Kupci";
            this.menuKupci.Click += new System.EventHandler(this.menuKupci_Click);
            // 
            // menuIzvjestaji
            // 
            this.menuIzvjestaji.Index = 3;
            this.menuIzvjestaji.Text = "Izvještaji";
            this.menuIzvjestaji.Click += new System.EventHandler(this.menuIzvjestaji_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(120)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 72);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dobro došli u naš informacijski sustav. \r\nOdaberite opciju za početak rada";
            // 
            // btnKupci
            // 
            this.btnKupci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnKupci.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupci.ForeColor = System.Drawing.Color.Black;
            this.btnKupci.Image = global::IzlucnoNatjecanje.Properties.Resources.kupci;
            this.btnKupci.Location = new System.Drawing.Point(12, 223);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(100, 96);
            this.btnKupci.TabIndex = 8;
            this.btnKupci.Text = "Kupci";
            this.btnKupci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKupci.UseVisualStyleBackColor = false;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnIzvjestaji.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.Black;
            this.btnIzvjestaji.Image = global::IzlucnoNatjecanje.Properties.Resources.racuni;
            this.btnIzvjestaji.Location = new System.Drawing.Point(12, 325);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(100, 96);
            this.btnIzvjestaji.TabIndex = 7;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzvjestaji.UseVisualStyleBackColor = false;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // btnDostava
            // 
            this.btnDostava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnDostava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDostava.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDostava.ForeColor = System.Drawing.Color.Black;
            this.btnDostava.Image = global::IzlucnoNatjecanje.Properties.Resources.dostava;
            this.btnDostava.Location = new System.Drawing.Point(12, 19);
            this.btnDostava.Name = "btnDostava";
            this.btnDostava.Size = new System.Drawing.Size(100, 96);
            this.btnDostava.TabIndex = 6;
            this.btnDostava.Text = "Dostava";
            this.btnDostava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDostava.UseVisualStyleBackColor = false;
            this.btnDostava.Click += new System.EventHandler(this.btnDostava_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnProizvodi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProizvodi.ForeColor = System.Drawing.Color.Black;
            this.btnProizvodi.Image = global::IzlucnoNatjecanje.Properties.Resources.proizvodi;
            this.btnProizvodi.Location = new System.Drawing.Point(12, 121);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(100, 96);
            this.btnProizvodi.TabIndex = 5;
            this.btnProizvodi.Text = "Proizvodi";
            this.btnProizvodi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProizvodi.UseVisualStyleBackColor = false;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(826, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.btnDostava);
            this.Controls.Add(this.btnProizvodi);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuDostava;
        private System.Windows.Forms.MenuItem menuProizvodi;
        private System.Windows.Forms.MenuItem menuKupci;
        private System.Windows.Forms.MenuItem menuIzvjestaji;
        private System.Windows.Forms.Button btnDostava;
        private System.Windows.Forms.Button btnKupci;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Label label1;
    }
}

