using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заполнение DataGridView данными
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            // Предположим, что здесь будет код для заполнения DataGridView данными о домах, жителях и оплатах.
            // Для примера просто добавим заголовки столбцов.
            dataGridView1.Columns.Add("Dom", "Дом");
            dataGridView1.Columns.Add("Chelovek", "Человек (Имя, Фамилия)");
            dataGridView1.Columns.Add("DataOplaty", "Дата оплаты");
        }

        private void btnBytovaJednotka_Click(object sender, EventArgs e)
        {
            // Открытие формы для работы с жилыми помещениями
            BytovaJednotkaForm bytovaJednotkaForm = new BytovaJednotkaForm();
            bytovaJednotkaForm.Show();
        }

        private void btnObyvatel_Click(object sender, EventArgs e)
        {
            // Открытие формы для работы с жителями
            ObyvatelForm obyvatelForm = new ObyvatelForm();
            obyvatelForm.Show();
        }

        private void btnZaplacenePoplatky_Click(object sender, EventArgs e)
        {
            // Открытие формы для работы с оплаченными сборами
            ZaplacenePoplatkyForm zaplacenePoplatkyForm = new ZaplacenePoplatkyForm();
            zaplacenePoplatkyForm.Show();
        }

        private void btnObyvatel_Click_1(object sender, EventArgs e)
        {

        }
    }
}

