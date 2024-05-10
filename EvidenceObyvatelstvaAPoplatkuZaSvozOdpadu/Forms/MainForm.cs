using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    public partial class MainForm : Form
    {
        private string connectionString = @"Data Source=C:\Users\Volodymyr\Source\Repos\EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu\EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu\DataBase\DataBase.db;Version=3;";


        public MainForm()
        {
            InitializeComponent();

            FillDataGridView(ZaplacenePoplatkyDataGridView, "SELECT * FROM ZaplacenePoplatky");
            ZaplacenePoplatkyDataGridView.CellEndEdit += (sender, e) => UpdateCellInDatabase(ZaplacenePoplatkyDataGridView, "ZaplacenePoplatky");

            FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
            BytovaJednotkaDataGridView.CellEndEdit += (sender, e) => UpdateCellInDatabase(BytovaJednotkaDataGridView, "BytovaJednotka");

            FillDataGridView(ObyvatelDataGridView, "SELECT * FROM Obyvatel");
            ObyvatelDataGridView.CellEndEdit += (sender, e) => UpdateCellInDatabase(ObyvatelDataGridView, "Obyvatel");

            LoadDataToNezaplaceneDataGridView();


            ZaplacenePoplatkyDeleteButton.Click += (sender, e) => DeleteSelectedRow(ZaplacenePoplatkyDataGridView, "ZaplacenePoplatky", "BytovaJednotkaId");
            BytovaJednotkaDeleteButton.Click += (sender, e) => DeleteSelectedRow(BytovaJednotkaDataGridView, "BytovaJednotka", "BytovaJednotkaId");
            ObyvatelDeleteButton.Click += (sender, e) => DeleteSelectedRow(ObyvatelDataGridView, "Obyvatel", "ObyvatelId");

        }

        private void UpdateCellInDatabase(DataGridView dataGridView, string tableName)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int columnIndex = dataGridView.CurrentCell.ColumnIndex;
            string columnName = dataGridView.Columns[columnIndex].Name;
            string newValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            string query;
            int id;
            if (tableName == "Obyvatel")
            {
                int idColumnIndex = dataGridView.Columns["ObyvatelId"].Index;
                id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[idColumnIndex].Value);
                query = $"UPDATE {tableName} SET {columnName} = @newValue WHERE ObyvatelId = @id";
            }
            else
            {
                int idColumnIndex = dataGridView.Columns["BytovaJednotkaId"].Index;
                id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[idColumnIndex].Value);
                query = $"UPDATE {tableName} SET {columnName} = @newValue WHERE BytovaJednotkaId = @id";
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void FillDataGridView(DataGridView dataGridView, string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private void LoadDataToNezaplaceneDataGridView()
        {
            string query = @"
        SELECT 
            BytovaJednotka.BytovaJednotkaId,
            BytovaJednotka.Adresa,
            Obyvatel.Jmeno,
            Obyvatel.Prijmeni,
            ZaplacenePoplatky.RokPoplatku,
            ZaplacenePoplatky.DatumUhrady
        FROM 
            BytovaJednotka
        LEFT JOIN 
            Obyvatel ON BytovaJednotka.BytovaJednotkaId = Obyvatel.BytovaJednotkaId
        LEFT JOIN 
            ZaplacenePoplatky ON BytovaJednotka.BytovaJednotkaId = ZaplacenePoplatky.BytovaJednotkaId";

            FillDataGridView(NezaplaceneDataGridView, query);
        }

        private void DeleteSelectedRow(DataGridView dataGridView, string tableName, string columnName)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView.Rows[selectedIndex].Cells[columnName].Value);

                string query = $"DELETE FROM {tableName} WHERE {columnName} = @id";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }

                FillDataGridView(dataGridView, $"SELECT * FROM {tableName}");
            }
            else
            {
                MessageBox.Show("Vyberte řádek k odstranění.");
            }
        }


        private void ChangeAllButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ChangeSum.Text, out int newSum))
            {
                List<int> visibleIds = GetVisibleIds(BytovaJednotkaDataGridView);
                UpdateAllVyskaPoplatkuZaObyvatele(newSum, visibleIds);
            }
            else
            {
                MessageBox.Show("Zadejte platné číslo.");
            }
        }

        private List<int> GetVisibleIds(DataGridView dataGridView)
        {
            List<int> visibleIds = new List<int>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.Visible) continue;
                int id = Convert.ToInt32(row.Cells["BytovaJednotkaId"].Value);
                visibleIds.Add(id);
            }
            return visibleIds;
        }

        private void UpdateAllVyskaPoplatkuZaObyvatele(int newSum, List<int> visibleIds)
        {
            string query = "UPDATE BytovaJednotka SET VyskaPoplatkuZaObyvatele = @newSum WHERE BytovaJednotkaId IN (" +
                            string.Join(",", visibleIds) + ")";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newSum", newSum);
                    command.ExecuteNonQuery();
                }
            }

            FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string searchValue = EnterNameStreetTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
            }
            else
            {
                string query = $"SELECT * FROM BytovaJednotka WHERE Adresa LIKE '%{searchValue}%'";
                FillDataGridView(BytovaJednotkaDataGridView, query);
            }
        }


        private void EnterNameStreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateButton_Click(sender, e);
            }
        }



    }
}
