
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

namespace STA_PROJECT
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=DB_SAT;Integrated Security=True";

        //====by//
        public Form1()
        {

            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadData();


            // Subscribe to the event

        }



        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify the SQL query to select all columns from your table
                    string query = "SELECT * FROM Karyawan";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Data Source = (localdb)\MSSqlLocalDb; Initial Catalog = DB_SAT; Integrated Security = True

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.FormClosed += Form2_FormClosed;

            form2.Show();
        }
        //=======by
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reload data when Form2 is closed
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (dataGridView1.Rows[selectedRowIndex].Cells["IDKaryawan"].Value != null &&
                    dataGridView1.Rows[selectedRowIndex].Cells["NmKaryawan"].Value != null &&
                    dataGridView1.Rows[selectedRowIndex].Cells["TglMasukKerja"].Value != null &&
                    dataGridView1.Rows[selectedRowIndex].Cells["Usia"].Value != null)
                {
                    string id = dataGridView1.Rows[selectedRowIndex].Cells["IDKaryawan"].Value.ToString();
                    string nama = dataGridView1.Rows[selectedRowIndex].Cells["NmKaryawan"].Value.ToString();
                    string tanggalMasuk = dataGridView1.Rows[selectedRowIndex].Cells["TglMasukKerja"].Value.ToString();
                    string usia = dataGridView1.Rows[selectedRowIndex].Cells["Usia"].Value.ToString();

                    Form2 form2 = new Form2(id, nama, tanggalMasuk, usia);

                    form2.FormClosed += Form2_FormClosed;
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Data yang dipilih bermasalah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data yang di pilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (dataGridView1.Rows[selectedRowIndex].Cells["IDKaryawan"].Value != null)
                {
                    string id = dataGridView1.Rows[selectedRowIndex].Cells["IDKaryawan"].Value.ToString();

                    DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus.?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteRecordFromDatabase(id);

                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data yang dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteRecordFromDatabase(string id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM Karyawan WHERE IDKaryawan = '{id}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil di hapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat hapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}