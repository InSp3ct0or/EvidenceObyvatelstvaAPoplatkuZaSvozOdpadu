using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MainForm()
        {
            InitializeComponent();
            CreateColumns(ZaplacenePoplatkyDataGridView, typeof(ZaplacenePoplatky));
            CreateColumns(BytovaJednotkaDataGridView, typeof(BytovaJednotka));
            CreateColumns(ObyvatelDataGridView, typeof(Obyvatel));
        }


        private void CreateColumns(DataGridView dataGridView, Type entityType)
        {
            // Очистка столбцов, если они уже были созданы
            dataGridView.Columns.Clear();

            // Получаем все свойства сущности
            PropertyInfo[] properties = entityType.GetProperties();

            // Добавляем столбцы в DataGridView на основе свойств сущности
            foreach (PropertyInfo property in properties)
            {
                dataGridView.Columns.Add(property.Name, property.Name);
            }
        }

        private void RokPoplatku_Click(object sender, EventArgs e)
        {

        }

    }
}
