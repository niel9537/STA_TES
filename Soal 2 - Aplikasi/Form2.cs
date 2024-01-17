
//by ---- Notice!! perubahan agar tidak berantakan ku tandai by ------
using FontAwesome.Sharp;
//by jika ingin menghilangkan hapus antara by dgn by
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Runtime.InteropServices;
using System.Net;
using System.Windows.Shapes;
using System.Diagnostics;

using System.Net.NetworkInformation;
using Serilog;
using Serilog.Events;
using Serilog.Core;
using Serilog.Sinks.File;
using System.Windows.Markup;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace STA_PROJECT
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=DB_SAT;Integrated Security=True";

        //====by//
        public Form2(string id = "", string nama = "", string tanggalMasuk = "", string usia = "")
        {
            InitializeComponent();

            // Set the textbox values in Form2 only if parameters are provided
            if (!string.IsNullOrEmpty(id))
                txtID.Text = id;
            if (!string.IsNullOrEmpty(nama))
                txtNama.Text = nama;
            if (!string.IsNullOrEmpty(tanggalMasuk))
                txtTanggalMasukKerja.Text = tanggalMasuk;
            if (!string.IsNullOrEmpty(usia))
                txtUsia.Text = usia;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void InsertData()
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtTanggalMasukKerja.Text) || string.IsNullOrEmpty(txtUsia.Text))
                {
                    MessageBox.Show("Silahkan isi semua data terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Karyawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES (@ID, @Name, @TanggalMasuk, @Usia)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", txtID.Text.ToString());
                        command.Parameters.AddWithValue("@Name", txtNama.Text.ToString());
                        command.Parameters.AddWithValue("@TanggalMasuk", txtTanggalMasukKerja.Text.ToString());
                        command.Parameters.AddWithValue("@Usia", txtUsia.Text.ToString());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsIdExists(txtID.Text))
            {
                UpdateData();
            }
            else
            {
                InsertData();
            }
        }
        //=======by

        public void UpdateData()
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtTanggalMasukKerja.Text) || string.IsNullOrEmpty(txtUsia.Text))
                {
                    MessageBox.Show("Silahkan isi semua data terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    if (DateTime.TryParseExact(txtTanggalMasukKerja.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tanggalMasuk))
                    {

                        string query = "UPDATE Karyawan SET NmKaryawan = @Name, TglMasukKerja = @TanggalMasuk, Usia = @Usia WHERE IDKaryawan = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", txtID.Text.ToString());
                            command.Parameters.AddWithValue("@Name", txtNama.Text.ToString());
                            command.Parameters.AddWithValue("@TanggalMasuk", tanggalMasuk); // Use the DateTime object
                            command.Parameters.AddWithValue("@Usia", txtUsia.Text.ToString());

                            command.ExecuteNonQuery();
                            MessageBox.Show("Data berhasil diupdate", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Format tanggal tidak valid. Gunakan format yyyy-MM-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsIdExists(string id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Karyawan WHERE IDKaryawan = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


    }
}