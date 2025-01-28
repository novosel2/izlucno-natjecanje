namespace IzlucnoNatjecanje
{
    partial class ProizvodiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dataProizvodi = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotkategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medjuzupanijsko2024_v3DataSet = new IzlucnoNatjecanje.Medjuzupanijsko2024_v3DataSet();
            this.lblLoading = new System.Windows.Forms.Label();
            this.proizvodTableAdapter = new IzlucnoNatjecanje.Medjuzupanijsko2024_v3DataSetTableAdapters.ProizvodTableAdapter();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrikazano = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuzupanijsko2024_v3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
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
            // dataProizvodi
            // 
            this.dataProizvodi.AllowUserToAddRows = false;
            this.dataProizvodi.AllowUserToDeleteRows = false;
            this.dataProizvodi.AllowUserToResizeColumns = false;
            this.dataProizvodi.AllowUserToResizeRows = false;
            this.dataProizvodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataProizvodi.AutoGenerateColumns = false;
            this.dataProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataProizvodi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataProizvodi.BackgroundColor = System.Drawing.Color.Gray;
            this.dataProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.brojDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.PotkategorijaId});
            this.dataProizvodi.DataSource = this.proizvodBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProizvodi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataProizvodi.GridColor = System.Drawing.Color.DimGray;
            this.dataProizvodi.Location = new System.Drawing.Point(187, 127);
            this.dataProizvodi.Name = "dataProizvodi";
            this.dataProizvodi.Size = new System.Drawing.Size(500, 250);
            this.dataProizvodi.TabIndex = 2;
            this.dataProizvodi.Visible = false;
            this.dataProizvodi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataProizvodi_DataBindingComplete);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 59;
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "Broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            this.brojDataGridViewTextBoxColumn.Width = 50;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.Width = 53;
            // 
            // PotkategorijaId
            // 
            this.PotkategorijaId.DataPropertyName = "PotkategorijaId";
            this.PotkategorijaId.HeaderText = "Potkategorija";
            this.PotkategorijaId.Name = "PotkategorijaId";
            this.PotkategorijaId.Width = 94;
            // 
            // proizvodBindingSource1
            // 
            this.proizvodBindingSource1.DataMember = "Proizvod";
            this.proizvodBindingSource1.DataSource = this.medjuzupanijsko2024_v3DataSet;
            // 
            // medjuzupanijsko2024_v3DataSet
            // 
            this.medjuzupanijsko2024_v3DataSet.DataSetName = "Medjuzupanijsko2024_v3DataSet";
            this.medjuzupanijsko2024_v3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblLoading.Location = new System.Drawing.Point(344, 164);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(89, 22);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataSource = typeof(IzlucnoNatjecanje.Data.Proizvod);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(313, 37);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(166, 20);
            this.txtFilter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtriranje naziva: ";
            // 
            // lblPrikazano
            // 
            this.lblPrikazano.AutoSize = true;
            this.lblPrikazano.Location = new System.Drawing.Point(219, 75);
            this.lblPrikazano.Name = "lblPrikazano";
            this.lblPrikazano.Size = new System.Drawing.Size(205, 13);
            this.lblPrikazano.TabIndex = 5;
            this.lblPrikazano.Text = "Prikazano je {1} od ukupno {2} proizvoda.";
            this.lblPrikazano.Visible = false;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(500, 35);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 6;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // ProizvodiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.lblPrikazano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dataProizvodi);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnPovratak);
            this.Name = "ProizvodiForm";
            this.Text = "Proizvodi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProizvodiForm_FormClosed);
            this.Load += new System.EventHandler(this.ProizvodiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuzupanijsko2024_v3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dataProizvodi;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private System.Windows.Forms.Label lblLoading;
        private Medjuzupanijsko2024_v3DataSet medjuzupanijsko2024_v3DataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource1;
        private Medjuzupanijsko2024_v3DataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotkategorijaId;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrikazano;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}