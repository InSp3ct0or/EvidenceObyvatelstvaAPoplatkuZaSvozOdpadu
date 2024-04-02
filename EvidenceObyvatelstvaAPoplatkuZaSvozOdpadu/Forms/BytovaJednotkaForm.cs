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
using System.Collections.Generic;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    public partial class BytovaJednotkaForm : Form
    {
        private BytovaJednotkaController bytovaJednotkaController;
        private List<BytovaJednotka> bytoveJednotky;

        public BytovaJednotkaForm()
        {
            InitializeComponent();
            bytovaJednotkaController = new BytovaJednotkaController();
            bytoveJednotky = new List<BytovaJednotka>();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Создание нового объекта BytovaJednotka
            BytovaJednotka newBytovaJednotka = new BytovaJednotka
            {
                Adresa = txtAdresa.Text,
                VyskaPoplatkuZaObyvatele = decimal.Parse(txtPoplatek.Text)
            };

            // Добавление в список и вызов контроллера для создания
            bytoveJednotky.Add(newBytovaJednotka);
            bytovaJednotkaController.Create(newBytovaJednotka);

            // Очистка полей после создания
            txtAdresa.Text = "";
            txtPoplatek.Text = "";

            // Обновление списка
            UpdateList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Вызов метода контроллера для получения списка
            bytoveJednotky = bytovaJednotkaController.GetAll();

            // Обновление списка
            UpdateList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBytoveJednotky.SelectedIndex != -1)
            {
                // Получение выбранного объекта и обновление его значений
                BytovaJednotka selectedBytovaJednotka = bytoveJednotky[listBytoveJednotky.SelectedIndex];
                selectedBytovaJednotka.Adresa = txtAdresa.Text;
                selectedBytovaJednotka.VyskaPoplatkuZaObyvatele = decimal.Parse(txtPoplatek.Text);

                // Вызов метода контроллера для обновления
                bytovaJednotkaController.Update(selectedBytovaJednotka.Id, selectedBytovaJednotka);

                // Очистка полей после обновления
                txtAdresa.Text = "";
                txtPoplatek.Text = "";

                // Обновление списка
                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBytoveJednotky.SelectedIndex != -1)
            {
                // Удаление выбранного объекта из списка и вызов контроллера для удаления
                BytovaJednotka selectedBytovaJednotka = bytoveJednotky[listBytoveJednotky.SelectedIndex];
                bytoveJednotky.RemoveAt(listBytoveJednotky.SelectedIndex);
                bytovaJednotkaController.Delete(selectedBytovaJednotka.Id);

                // Обновление списка
                UpdateList();
            }
        }

        private void UpdateList()
        {
            // Очистка списка и добавление всех элементов из списка bytoveJednotky
            listBytoveJednotky.Items.Clear();
            foreach (var bytovaJednotka in bytoveJednotky)
            {
                listBytoveJednotky.Items.Add(bytovaJednotka.Adresa);
            }
        }
    }
}

