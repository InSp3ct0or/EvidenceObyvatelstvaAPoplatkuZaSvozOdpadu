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

            // Заполнение DataGridView и привязка события CellEndEdit
            FillDataGridView(ZaplacenePoplatkyDataGridView, "SELECT * FROM ZaplacenePoplatky");
            ZaplacenePoplatkyDataGridView.CellEndEdit += (sender, e) => UpdateCellInDatabase(ZaplacenePoplatkyDataGridView, "ZaplacenePoplatky");

            FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
            BytovaJednotkaDataGridView.CellEndEdit += (sender, e) => UpdateCellInDatabase(BytovaJednotkaDataGridView, "BytovaJednotka");

            FillDataGridView(ObyvatelDataGridView, "SELECT * FROM Obyvatel");
            ObyvatelDataGridView.CellEndEdit += (sender, e) => UpdateCellInDatabase(ObyvatelDataGridView, "Obyvatel");

            ZaplacenePoplatkyDeleteButton.Click += (sender, e) => DeleteSelectedRow(ZaplacenePoplatkyDataGridView, "ZaplacenePoplatky", "Id");
            BytovaJednotkaDeleteButton.Click += (sender, e) => DeleteSelectedRow(BytovaJednotkaDataGridView, "BytovaJednotka", "Id");
            ObyvatelDeleteButton.Click += (sender, e) => DeleteSelectedRow(ObyvatelDataGridView, "Obyvatel", "ObyvatelId");
        }

        private void UpdateCellInDatabase(DataGridView dataGridView, string tableName)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int columnIndex = dataGridView.CurrentCell.ColumnIndex;
            string columnName = dataGridView.Columns[columnIndex].Name;
            string newValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            // Формируем запрос обновления
            string query;
            int id;
            if (tableName == "Obyvatel")
            {
                // Получаем id строки для таблицы Obyvatel
                int idColumnIndex = dataGridView.Columns["ObyvatelId"].Index;
                id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[idColumnIndex].Value);
                query = $"UPDATE {tableName} SET {columnName} = @newValue WHERE ObyvatelId = @id";
            }
            else
            {
                // Получаем id строки для остальных таблиц
                int idColumnIndex = dataGridView.Columns["Id"].Index;
                id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[idColumnIndex].Value);
                query = $"UPDATE {tableName} SET {columnName} = @newValue WHERE Id = @id";
            }

            // Выполняем запрос к базе данных
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
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

        private void ChangeAllButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ChangeSum.Text, out int newSum))
            {
                // Получаем текущие отображаемые строки DataGridView
                List<int> visibleIds = GetVisibleIds(BytovaJednotkaDataGridView);

                // Обновляем только видимые записи
                UpdateAllVyskaPoplatkuZaObyvatele(newSum, visibleIds);
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private List<int> GetVisibleIds(DataGridView dataGridView)
        {
            List<int> visibleIds = new List<int>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.Visible) continue;
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                visibleIds.Add(id);
            }
            return visibleIds;
        }

        private void UpdateAllVyskaPoplatkuZaObyvatele(int newSum, List<int> visibleIds)
        {
            // Формируем запрос обновления
            string query = "UPDATE BytovaJednotka SET VyskaPoplatkuZaObyvatele = @newSum WHERE Id IN (" +
                            string.Join(",", visibleIds) + ")";

            // Выполняем запрос к базе данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newSum", newSum);
                    command.ExecuteNonQuery();
                }
            }

            // Обновляем DataGridView, чтобы отобразить изменения
            FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string searchValue = EnterNameStreetTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                // Если поле пустое, отображаем всю таблицу
                FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
            }
            else
            {
                // Если поле не пустое, отображаем только строки с соответствующим значением Adresa
                string query = $"SELECT * FROM BytovaJednotka WHERE Adresa LIKE '%{searchValue}%'";
                FillDataGridView(BytovaJednotkaDataGridView, query);
            }
        }


        private void EnterNameStreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // При нажатии клавиши Enter в поле ввода, выполняем поиск и обновляем DataGridView
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateButton_Click(sender, e);
            }
        }



    }
}
