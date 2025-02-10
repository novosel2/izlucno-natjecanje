namespace IzlucnoNatjecanje.Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridProizvodi = new System.Windows.Forms.DataGridView();
            this.lblLoading = new System.Windows.Forms.Label();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potkategorijaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.lblFiltered = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(193)))), ((int)(((byte)(78)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridProizvodi
            // 
            this.dataGridProizvodi.AutoGenerateColumns = false;
            this.dataGridProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.brojDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.potkategorijaIdDataGridViewTextBoxColumn});
            this.dataGridProizvodi.DataSource = this.proizvodBindingSource;
            this.dataGridProizvodi.Location = new System.Drawing.Point(171, 172);
            this.dataGridProizvodi.Name = "dataGridProizvodi";
            this.dataGridProizvodi.Size = new System.Drawing.Size(444, 178);
            this.dataGridProizvodi.TabIndex = 1;
            this.dataGridProizvodi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridProizvodi_DataBindingComplete);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(362, 246);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "Broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // potkategorijaIdDataGridViewTextBoxColumn
            // 
            this.potkategorijaIdDataGridViewTextBoxColumn.DataPropertyName = "Potkategorija";
            this.potkategorijaIdDataGridViewTextBoxColumn.HeaderText = "Potkategorija";
            this.potkategorijaIdDataGridViewTextBoxColumn.Name = "potkategorijaIdDataGridViewTextBoxColumn";
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataSource = typeof(IzlucnoNatjecanje.Data.Proizvod);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(315, 99);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(184, 20);
            this.txtFilter.TabIndex = 3;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(183, 98);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(126, 19);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filtriranje naziva:";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnFiltriraj.Location = new System.Drawing.Point(518, 97);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(99, 23);
            this.btnFiltriraj.TabIndex = 5;
            this.btnFiltriraj.Text = "filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // lblFiltered
            // 
            this.lblFiltered.AutoSize = true;
            this.lblFiltered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltered.Location = new System.Drawing.Point(183, 132);
            this.lblFiltered.Name = "lblFiltered";
            this.lblFiltered.Size = new System.Drawing.Size(280, 19);
            this.lblFiltered.TabIndex = 6;
            this.lblFiltered.Text = "Prikazano je {1} od ukupno {2} proizvoda";
            this.lblFiltered.Visible = false;
            // 
            // ProizvodiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFiltered);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.dataGridProizvodi);
            this.Controls.Add(this.button1);
            this.Name = "ProizvodiForm";
            this.Text = "ProizvodiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProizvodiForm_FormClosed);
            this.Load += new System.EventHandler(this.ProizvodiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridProizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potkategorijaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Label lblFiltered;
    }
}