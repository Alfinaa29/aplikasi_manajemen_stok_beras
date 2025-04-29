using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplikasi_Manajemen_Stok_Beras
{
    public partial class FormDaftarStokBeras2 : Form
    {
        private string connectionString = "server=localhost;database=aplikasi_manajemen_stok_beras;uid=root;pwd=;";

        public FormDaftarStokBeras2()
        {
            InitializeComponent();
            TampilkanDataStokBeras(); // Tetap dipanggil saat awal buka form
        }

        private void TampilkanDataStokBeras()
        {
            // Menambahkan indikator loading (opsional)
            Cursor.Current = Cursors.WaitCursor;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama_beras, harga_beli, harga_jual, jumlah_stok FROM stok_beras";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Reset isi DataGridView
                        dgvStokBeras.DataSource = null;
                        dgvStokBeras.Columns.Clear();

                        dgvStokBeras.DataSource = dt;

                        // Ganti nama header kolom
                        dgvStokBeras.Columns[0].HeaderText = "Nama Beras";
                        dgvStokBeras.Columns[1].HeaderText = "Harga Beli";
                        dgvStokBeras.Columns[2].HeaderText = "Harga Jual";
                        dgvStokBeras.Columns[3].HeaderText = "Jumlah Stok";

                        // Sembunyikan kolom tambahan jika ada
                        if (dgvStokBeras.Columns.Count > 4)
                        {
                            for (int i = 4; i < dgvStokBeras.Columns.Count; i++)
                            {
                                dgvStokBeras.Columns[i].Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        // ✅ Ini tetap untuk refresh saat dipanggil dari luar form
        public void LoadData()
        {
            TampilkanDataStokBeras();
        }

        // ✅ Refresh otomatis saat form diaktifkan kembali
        private void FormDaftarStokBeras2_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        // ✅ Diperlukan agar Designer tidak error
        private void gbDataStokBeras_Enter(object sender, EventArgs e)
        {
            // Biarkan kosong, ini hanya placeholder
        }

        private void FormDaftarStokBeras2_Load(object sender, EventArgs e)
        {
            // Tidak digunakan saat ini
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            // Buka FormInputDataBeras
            FormInputDataBeras formInput = new FormInputDataBeras(this);

            // Refresh data setelah form input ditutup
            formInput.FormClosed += (s, args) => LoadData();

            formInput.ShowDialog(); // Tampilkan form input sebagai dialog
        }

        // Tambahan untuk Button Perbarui
        private void btnPerbaruiData_Click(object sender, EventArgs e)
        {
            // Debugging: Tampilkan jumlah baris yang dipilih
            Console.WriteLine($"Jumlah baris yang dipilih: {dgvStokBeras.SelectedRows.Count}");

            // Pastikan hanya satu baris yang dipilih
            if (dgvStokBeras.SelectedRows.Count == 1)
            {
                var namaBeras = dgvStokBeras.SelectedRows[0].Cells[0].Value?.ToString();

                // Debugging: Tampilkan nilai nama beras
                Console.WriteLine($"Nama beras yang dipilih: {namaBeras}");

                if (!string.IsNullOrEmpty(namaBeras))
                {
                    // Buka form input untuk memperbarui data
                    FormInputDataBeras formInput = new FormInputDataBeras(this, namaBeras);
                    formInput.FormClosed += (s, args) => LoadData(); // Refresh data setelah form input ditutup
                    formInput.ShowDialog(); // Tampilkan form input sebagai dialog
                }
                else
                {
                    MessageBox.Show("Pilih data yang valid untuk diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih satu data yang valid untuk diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tambahan untuk Button Hapus
        private void btnHapusData_Click(object sender, EventArgs e)
        {
            // Debugging: Tampilkan jumlah baris yang dipilih
            Console.WriteLine($"Baris yang dipilih: {dgvStokBeras.SelectedRows.Count}");

            if (dgvStokBeras.SelectedRows.Count == 1) // Pastikan hanya satu baris yang dipilih
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string namaBeras = dgvStokBeras.SelectedRows[0].Cells["nama_beras"].Value.ToString();

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM stok_beras WHERE nama_beras = @nama_beras";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@nama_beras", namaBeras);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh data setelah hapus
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih satu data yang ingin dihapus terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kataKunci = txtCari.Text.Trim();

            if (string.IsNullOrEmpty(kataKunci))
            {
                TampilkanDataStokBeras(); // Tampilkan semua data kalau kosong
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama_beras, harga_beli, harga_jual, jumlah_stok FROM stok_beras WHERE nama_beras LIKE @kataKunci";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@kataKunci", "%" + kataKunci + "%");

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStokBeras.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mencari data: " + ex.Message);
                }
            }
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCari.PerformClick();
            }
        }


    }
}

