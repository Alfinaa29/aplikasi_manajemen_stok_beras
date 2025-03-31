namespace Manajemen_Stok_Beras
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbInputDataBeras = new System.Windows.Forms.GroupBox();
            this.btnTambahBeras = new System.Windows.Forms.Button();
            this.cmbSatuanStok = new System.Windows.Forms.ComboBox();
            this.txtJumlahStok = new System.Windows.Forms.TextBox();
            this.lblJumlahStok = new System.Windows.Forms.Label();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.lblHargaJual = new System.Windows.Forms.Label();
            this.cmbSatuanBeli = new System.Windows.Forms.ComboBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.lblHargaBeli = new System.Windows.Forms.Label();
            this.cmbNamaBeras = new System.Windows.Forms.ComboBox();
            this.txtNamaBeras = new System.Windows.Forms.TextBox();
            this.pilBeras = new System.Windows.Forms.RadioButton();
            this.gbDataStokBeras = new System.Windows.Forms.GroupBox();
            this.dgvStokBeras = new System.Windows.Forms.DataGridView();
            this.namaberas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahstok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInputDataBeras.SuspendLayout();
            this.gbDataStokBeras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBeras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Stok Beras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbInputDataBeras
            // 
            this.gbInputDataBeras.Controls.Add(this.btnTambahBeras);
            this.gbInputDataBeras.Controls.Add(this.cmbSatuanStok);
            this.gbInputDataBeras.Controls.Add(this.txtJumlahStok);
            this.gbInputDataBeras.Controls.Add(this.lblJumlahStok);
            this.gbInputDataBeras.Controls.Add(this.txtHargaJual);
            this.gbInputDataBeras.Controls.Add(this.lblHargaJual);
            this.gbInputDataBeras.Controls.Add(this.cmbSatuanBeli);
            this.gbInputDataBeras.Controls.Add(this.txtHargaBeli);
            this.gbInputDataBeras.Controls.Add(this.lblHargaBeli);
            this.gbInputDataBeras.Controls.Add(this.cmbNamaBeras);
            this.gbInputDataBeras.Controls.Add(this.txtNamaBeras);
            this.gbInputDataBeras.Controls.Add(this.pilBeras);
            this.gbInputDataBeras.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputDataBeras.Location = new System.Drawing.Point(12, 77);
            this.gbInputDataBeras.Name = "gbInputDataBeras";
            this.gbInputDataBeras.Size = new System.Drawing.Size(381, 500);
            this.gbInputDataBeras.TabIndex = 1;
            this.gbInputDataBeras.TabStop = false;
            this.gbInputDataBeras.Text = "Input Data Beras";
            // 
            // btnTambahBeras
            // 
            this.btnTambahBeras.Location = new System.Drawing.Point(5, 429);
            this.btnTambahBeras.Name = "btnTambahBeras";
            this.btnTambahBeras.Size = new System.Drawing.Size(292, 53);
            this.btnTambahBeras.TabIndex = 11;
            this.btnTambahBeras.Text = "Tambah Beras";
            this.btnTambahBeras.UseVisualStyleBackColor = true;
            this.btnTambahBeras.Click += new System.EventHandler(this.btnTambahBeras_Click);
            // 
            // cmbSatuanStok
            // 
            this.cmbSatuanStok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatuanStok.FormattingEnabled = true;
            this.cmbSatuanStok.Location = new System.Drawing.Point(12, 354);
            this.cmbSatuanStok.Name = "cmbSatuanStok";
            this.cmbSatuanStok.Size = new System.Drawing.Size(142, 35);
            this.cmbSatuanStok.TabIndex = 10;
            // 
            // txtJumlahStok
            // 
            this.txtJumlahStok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahStok.Location = new System.Drawing.Point(200, 354);
            this.txtJumlahStok.Name = "txtJumlahStok";
            this.txtJumlahStok.Size = new System.Drawing.Size(141, 35);
            this.txtJumlahStok.TabIndex = 9;
            // 
            // lblJumlahStok
            // 
            this.lblJumlahStok.AutoSize = true;
            this.lblJumlahStok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahStok.Location = new System.Drawing.Point(0, 307);
            this.lblJumlahStok.Name = "lblJumlahStok";
            this.lblJumlahStok.Size = new System.Drawing.Size(146, 27);
            this.lblJumlahStok.TabIndex = 8;
            this.lblJumlahStok.Text = "Jumlah Stok";
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaJual.Location = new System.Drawing.Point(200, 243);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(142, 35);
            this.txtHargaJual.TabIndex = 7;
            // 
            // lblHargaJual
            // 
            this.lblHargaJual.AutoSize = true;
            this.lblHargaJual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaJual.Location = new System.Drawing.Point(7, 243);
            this.lblHargaJual.Name = "lblHargaJual";
            this.lblHargaJual.Size = new System.Drawing.Size(129, 27);
            this.lblHargaJual.TabIndex = 6;
            this.lblHargaJual.Text = "Harga Jual";
            // 
            // cmbSatuanBeli
            // 
            this.cmbSatuanBeli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatuanBeli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbSatuanBeli.FormattingEnabled = true;
            this.cmbSatuanBeli.Location = new System.Drawing.Point(12, 185);
            this.cmbSatuanBeli.Name = "cmbSatuanBeli";
            this.cmbSatuanBeli.Size = new System.Drawing.Size(142, 35);
            this.cmbSatuanBeli.TabIndex = 5;
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaBeli.Location = new System.Drawing.Point(200, 185);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(141, 35);
            this.txtHargaBeli.TabIndex = 4;
            this.txtHargaBeli.TextChanged += new System.EventHandler(this.txtHargaBeli_TextChanged);
            // 
            // lblHargaBeli
            // 
            this.lblHargaBeli.AutoSize = true;
            this.lblHargaBeli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaBeli.Location = new System.Drawing.Point(7, 138);
            this.lblHargaBeli.Name = "lblHargaBeli";
            this.lblHargaBeli.Size = new System.Drawing.Size(124, 27);
            this.lblHargaBeli.TabIndex = 3;
            this.lblHargaBeli.Text = "Harga Beli";
            // 
            // cmbNamaBeras
            // 
            this.cmbNamaBeras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamaBeras.FormattingEnabled = true;
            this.cmbNamaBeras.Location = new System.Drawing.Point(200, 80);
            this.cmbNamaBeras.Name = "cmbNamaBeras";
            this.cmbNamaBeras.Size = new System.Drawing.Size(142, 35);
            this.cmbNamaBeras.TabIndex = 2;
            // 
            // txtNamaBeras
            // 
            this.txtNamaBeras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBeras.Location = new System.Drawing.Point(12, 80);
            this.txtNamaBeras.Name = "txtNamaBeras";
            this.txtNamaBeras.Size = new System.Drawing.Size(141, 35);
            this.txtNamaBeras.TabIndex = 1;
            this.txtNamaBeras.Text = "Nama Beras";
            // 
            // pilBeras
            // 
            this.pilBeras.AutoSize = true;
            this.pilBeras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilBeras.Location = new System.Drawing.Point(12, 43);
            this.pilBeras.Name = "pilBeras";
            this.pilBeras.Size = new System.Drawing.Size(152, 31);
            this.pilBeras.TabIndex = 0;
            this.pilBeras.TabStop = true;
            this.pilBeras.Text = "Pilih Beras";
            this.pilBeras.UseVisualStyleBackColor = true;
            // 
            // gbDataStokBeras
            // 
            this.gbDataStokBeras.Controls.Add(this.dgvStokBeras);
            this.gbDataStokBeras.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataStokBeras.Location = new System.Drawing.Point(465, 91);
            this.gbDataStokBeras.Name = "gbDataStokBeras";
            this.gbDataStokBeras.Size = new System.Drawing.Size(736, 486);
            this.gbDataStokBeras.TabIndex = 2;
            this.gbDataStokBeras.TabStop = false;
            this.gbDataStokBeras.Text = "Daftar Stok Beras";
            // 
            // dgvStokBeras
            // 
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
            this.dgvStokBeras.Location = new System.Drawing.Point(6, 66);
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
            this.dgvStokBeras.Size = new System.Drawing.Size(724, 414);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 589);
            this.Controls.Add(this.gbDataStokBeras);
            this.Controls.Add(this.gbInputDataBeras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInputDataBeras.ResumeLayout(false);
            this.gbInputDataBeras.PerformLayout();
            this.gbDataStokBeras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBeras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInputDataBeras;
        private System.Windows.Forms.Label lblHargaBeli;
        private System.Windows.Forms.ComboBox cmbNamaBeras;
        private System.Windows.Forms.TextBox txtNamaBeras;
        private System.Windows.Forms.RadioButton pilBeras;
        private System.Windows.Forms.ComboBox cmbSatuanBeli;
        private System.Windows.Forms.TextBox txtHargaBeli;
        private System.Windows.Forms.TextBox txtJumlahStok;
        private System.Windows.Forms.Label lblJumlahStok;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Label lblHargaJual;
        private System.Windows.Forms.Button btnTambahBeras;
        private System.Windows.Forms.ComboBox cmbSatuanStok;
        private System.Windows.Forms.GroupBox gbDataStokBeras;
        private System.Windows.Forms.DataGridView dgvStokBeras;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaberas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahstok;
    }
}

