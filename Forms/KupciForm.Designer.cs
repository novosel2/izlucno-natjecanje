namespace IzlucnoNatjecanje.Forms
{
    partial class KupciForm
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medjuzupanijsko2024_v3DataSet6 = new IzlucnoNatjecanje.Medjuzupanijsko2024_v3DataSet6();
            this.kupacTableAdapter = new IzlucnoNatjecanje.Medjuzupanijsko2024_v3DataSet6TableAdapters.KupacTableAdapter();
            this.btnNovi = new System.Windows.Forms.LinkLabel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dataGridKupci = new System.Windows.Forms.DataGridView();
            this.kupacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuzupanijsko2024_v3DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.btnPovratak.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnPovratak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(120)))));
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(126, 46);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "Kupac";
            this.kupacBindingSource.DataSource = this.medjuzupanijsko2024_v3DataSet6;
            // 
            // medjuzupanijsko2024_v3DataSet6
            // 
            this.medjuzupanijsko2024_v3DataSet6.DataSetName = "Medjuzupanijsko2024_v3DataSet6";
            this.medjuzupanijsko2024_v3DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // btnNovi
            // 
            this.btnNovi.AutoSize = true;
            this.btnNovi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovi.Location = new System.Drawing.Point(37, 125);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(72, 13);
            this.btnNovi.TabIndex = 3;
            this.btnNovi.TabStop = true;
            this.btnNovi.Text = "NOVI KUPAC";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(366, 221);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "Loading...";
            // 
            // dataGridKupci
            // 
            this.dataGridKupci.AllowUserToAddRows = false;
            this.dataGridKupci.AllowUserToDeleteRows = false;
            this.dataGridKupci.AutoGenerateColumns = false;
            this.dataGridKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kupacIdDataGridViewTextBoxColumn,
            this.titulaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn});
            this.dataGridKupci.DataSource = this.kupacBindingSource1;
            this.dataGridKupci.Location = new System.Drawing.Point(28, 141);
            this.dataGridKupci.Name = "dataGridKupci";
            this.dataGridKupci.ReadOnly = true;
            this.dataGridKupci.Size = new System.Drawing.Size(751, 150);
            this.dataGridKupci.TabIndex = 2;
            this.dataGridKupci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKupci_CellContentClick);
            // 
            // kupacIdDataGridViewTextBoxColumn
            // 
            this.kupacIdDataGridViewTextBoxColumn.DataPropertyName = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.HeaderText = "KupacId";
            this.kupacIdDataGridViewTextBoxColumn.Name = "kupacIdDataGridViewTextBoxColumn";
            this.kupacIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulaDataGridViewTextBoxColumn
            // 
            this.titulaDataGridViewTextBoxColumn.DataPropertyName = "Titula";
            this.titulaDataGridViewTextBoxColumn.HeaderText = "Titula";
            this.titulaDataGridViewTextBoxColumn.Name = "titulaDataGridViewTextBoxColumn";
            this.titulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Izdani računi";
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kupacBindingSource1
            // 
            this.kupacBindingSource1.DataSource = typeof(IzlucnoNatjecanje.Data.Kupac);
            // 
            // KupciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.dataGridKupci);
            this.Controls.Add(this.btnPovratak);
            this.Name = "KupciForm";
            this.Text = "Kupci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KupciForm_FormClosed);
            this.Load += new System.EventHandler(this.KupciForm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuzupanijsko2024_v3DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private Medjuzupanijsko2024_v3DataSet6 medjuzupanijsko2024_v3DataSet6;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private Medjuzupanijsko2024_v3DataSet6TableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource kupacBindingSource1;
        private System.Windows.Forms.LinkLabel btnNovi;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.DataGridView dataGridKupci;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunDataGridViewTextBoxColumn;
    }
}