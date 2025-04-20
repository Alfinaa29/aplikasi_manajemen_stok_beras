namespace Aplikasi_Manajemen_Stok_Beras
{
    partial class FormDaftarStokBeras2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDataStokBeras = new System.Windows.Forms.GroupBox();
            this.dgvStokBeras = new System.Windows.Forms.DataGridView();
            this.namaberas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahstok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.gbDataStokBeras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBeras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDataStokBeras
            // 
            this.gbDataStokBeras.Controls.Add(this.btnTambahData);
            this.gbDataStokBeras.Controls.Add(this.dgvStokBeras);
            this.gbDataStokBeras.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataStokBeras.Location = new System.Drawing.Point(46, 45);
            this.gbDataStokBeras.Name = "gbDataStokBeras";
            this.gbDataStokBeras.Size = new System.Drawing.Size(707, 426);
            this.gbDataStokBeras.TabIndex = 0;
            this.gbDataStokBeras.TabStop = false;
            this.gbDataStokBeras.Text = "Daftar Stok Beras";
            this.gbDataStokBeras.Enter += new System.EventHandler(this.gbDataStokBeras_Enter);
            // 
            // dgvStokBeras
            // 
            this.dgvStokBeras.AllowUserToAddRows = false;
            this.dgvStokBeras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokBeras.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokBeras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStokBeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokBeras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaberas,
            this.hargabeli,
            this.hargajual,
            this.jumlahstok});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStokBeras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStokBeras.Location = new System.Drawing.Point(32, 68);
            this.dgvStokBeras.Name = "dgvStokBeras";
            this.dgvStokBeras.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokBeras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStokBeras.RowHeadersWidth = 62;
            this.dgvStokBeras.RowTemplate.Height = 28;
            this.dgvStokBeras.Size = new System.Drawing.Size(586, 289);
            this.dgvStokBeras.TabIndex = 0;
            // 
            // namaberas
            // 
            this.namaberas.HeaderText = "Nama Beras";
            this.namaberas.MinimumWidth = 8;
            this.namaberas.Name = "namaberas";
            this.namaberas.ReadOnly = true;
            // 
            // hargabeli
            // 
            this.hargabeli.HeaderText = "Harga Beli";
            this.hargabeli.MinimumWidth = 8;
            this.hargabeli.Name = "hargabeli";
            this.hargabeli.ReadOnly = true;
            // 
            // hargajual
            // 
            this.hargajual.HeaderText = "Harga Jual";
            this.hargajual.MinimumWidth = 8;
            this.hargajual.Name = "hargajual";
            this.hargajual.ReadOnly = true;
            // 
            // jumlahstok
            // 
            this.jumlahstok.HeaderText = "Jumlah Stok";
            this.jumlahstok.MinimumWidth = 8;
            this.jumlahstok.Name = "jumlahstok";
            this.jumlahstok.ReadOnly = true;
            // 
            // btnTambahData
            // 
            this.btnTambahData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahData.Location = new System.Drawing.Point(487, 363);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(205, 57);
            this.btnTambahData.TabIndex = 1;
            this.btnTambahData.Text = "Tambah Data";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // FormDaftarStokBeras2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.gbDataStokBeras);
            this.Name = "FormDaftarStokBeras2";
            this.Text = "FormDaftarStokBeras2";
            this.Load += new System.EventHandler(this.FormDaftarStokBeras2_Load);
            this.gbDataStokBeras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBeras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataStokBeras;
        private System.Windows.Forms.DataGridView dgvStokBeras;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaberas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahstok;
        private System.Windows.Forms.Button btnTambahData;
    }
}