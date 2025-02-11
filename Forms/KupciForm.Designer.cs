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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridKupci = new System.Windows.Forms.DataGridView();
            this.medjuzupanijsko2024_v3DataSet8 = new IzlucnoNatjecanje.Medjuzupanijsko2024_v3DataSet8();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new IzlucnoNatjecanje.Medjuzupanijsko2024_v3DataSet8TableAdapters.KupacTableAdapter();
            this.titulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuzupanijsko2024_v3DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridKupci
            // 
            this.dataGridKupci.AllowUserToAddRows = false;
            this.dataGridKupci.AllowUserToDeleteRows = false;
            this.dataGridKupci.AutoGenerateColumns = false;
            this.dataGridKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn});
            this.dataGridKupci.DataSource = this.kupacBindingSource;
            this.dataGridKupci.Location = new System.Drawing.Point(111, 112);
            this.dataGridKupci.Name = "dataGridKupci";
            this.dataGridKupci.ReadOnly = true;
            this.dataGridKupci.Size = new System.Drawing.Size(550, 150);
            this.dataGridKupci.TabIndex = 2;
            this.dataGridKupci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKupci_CellContentClick);
            // 
            // medjuzupanijsko2024_v3DataSet8
            // 
            this.medjuzupanijsko2024_v3DataSet8.DataSetName = "Medjuzupanijsko2024_v3DataSet8";
            this.medjuzupanijsko2024_v3DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "Kupac";
            this.kupacBindingSource.DataSource = this.medjuzupanijsko2024_v3DataSet8;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // titulaDataGridViewTextBoxColumn
            // 
            this.titulaDataGridViewTextBoxColumn.DataPropertyName = "Titula";
            this.titulaDataGridViewTextBoxColumn.HeaderText = "Titula";
            this.titulaDataGridViewTextBoxColumn.Name = "titulaDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // KupciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridKupci);
            this.Controls.Add(this.button1);
            this.Name = "KupciForm";
            this.Text = "KupciForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KupciForm_FormClosed);
            this.Load += new System.EventHandler(this.KupciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuzupanijsko2024_v3DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridKupci;
        private Medjuzupanijsko2024_v3DataSet8 medjuzupanijsko2024_v3DataSet8;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private Medjuzupanijsko2024_v3DataSet8TableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
    }
}