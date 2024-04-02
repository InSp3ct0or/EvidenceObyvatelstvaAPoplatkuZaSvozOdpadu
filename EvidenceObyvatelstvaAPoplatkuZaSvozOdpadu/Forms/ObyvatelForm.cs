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

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    public partial class ObyvatelForm : Form
    {
        private ObyvatelController obyvatelController;
        private List<Obyvatel> obyvatele;

        public ObyvatelForm()
        {
            InitializeComponent();
            obyvatelController = new ObyvatelController();
            obyvatele = new List<Obyvatel>();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Создание нового объекта Obyvatel
            Obyvatel newObyvatel = new Obyvatel
            {
                Jmeno = txtJmeno.Text,
                Prijmeni = txtPrijmeni.Text,
                BytovaJednotkaId = int.Parse(txtIdBytovaJednotka.Text)
            };

            // Добавление в список и вызов контроллера для создания
            obyvatele.Add(newObyvatel);
            obyvatelController.Create(newObyvatel);

            // Очистка полей после создания
            txtJmeno.Text = "";
            txtPrijmeni.Text = "";
            txtIdBytovaJednotka.Text = "";

            // Обновление списка
            UpdateList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Вызов метода контроллера для получения списка
            obyvatele = obyvatelController.GetAll();

            // Обновление списка
            UpdateList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listObyvatele.SelectedIndex != -1)
            {
                // Получение выбранного объекта и обновление его значений
                Obyvatel selectedObyvatel = obyvatele[listObyvatele.SelectedIndex];
                selectedObyvatel.Jmeno = txtJmeno.Text;
                selectedObyvatel.Prijmeni = txtPrijmeni.Text;
                selectedObyvatel.BytovaJednotkaId = int.Parse(txtIdBytovaJednotka.Text);

                // Вызов метода контроллера для обновления
                obyvatelController.Update(selectedObyvatel.Id, selectedObyvatel);

                // Очистка полей после обновления
                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                txtIdBytovaJednotka.Text = "";

                // Обновление списка
                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listObyvatele.SelectedIndex != -1)
            {
                // Удаление выбранного объекта из списка и вызов контроллера для удаления
                Obyvatel selectedObyvatel = obyvatele[listObyvatele.SelectedIndex];
                obyvatele.RemoveAt(listObyvatele.SelectedIndex);
                obyvatelController.Delete(selectedObyvatel.Id);

                // Обновление списка
                UpdateList();
            }
        }

        private void UpdateList()
        {
            // Очистка списка и добавление всех элементов из списка obyvatele
            listObyvatele.Items.Clear();
            foreach (var obyvatel in obyvatele)
            {
                listObyvatele.Items.Add($"{obyvatel.Jmeno} {obyvatel.Prijmeni}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdBytovaJednotka_Click(object sender, EventArgs e)
        {

        }

        private void Jmeno_Click(object sender, EventArgs e)
        {

        }
    }
}
