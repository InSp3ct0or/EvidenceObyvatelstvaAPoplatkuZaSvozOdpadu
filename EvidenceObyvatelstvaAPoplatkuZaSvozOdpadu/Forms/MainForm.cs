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
            FillDataGridView(BytovaJednotkaDataGridView, "SELECT * FROM BytovaJednotka");
            FillDataGridView(ObyvatelDataGridView, "SELECT * FROM Obyvatel");

            // Привязка обработчиков событий выбора строки в DataGridView
            ZaplacenePoplatkyDataGridView.SelectionChanged += DataGridView_SelectionChanged;
            BytovaJednotkaDataGridView.SelectionChanged += DataGridView_SelectionChanged;
            ObyvatelDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Заполнение textBox данными из выбранной строки
                textBoxRokPoplatku.Text = selectedRow.Cells["RokPoplatku"].Value?.ToString();
                textBoxObyvatelId.Text = selectedRow.Cells["ObyvatelId"].Value?.ToString();
                textBoxDatumUhrady.Text = selectedRow.Cells["DatumUhrady"].Value?.ToString();
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
    }
}
