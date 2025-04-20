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
    }
}
