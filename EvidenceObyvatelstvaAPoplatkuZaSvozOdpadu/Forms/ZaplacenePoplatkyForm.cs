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
    public partial class ZaplacenePoplatkyForm : Form
    {
        private ZaplacenePoplatkyController zaplacenePoplatkyController;
        private List<ZaplacenePoplatky> zaplacenePoplatky;

        public ZaplacenePoplatkyForm()
        {
            InitializeComponent();
            zaplacenePoplatkyController = new ZaplacenePoplatkyController();
            zaplacenePoplatky = new List<ZaplacenePoplatky>();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Создание нового объекта ZaplacenePoplatky
            ZaplacenePoplatky newZaplacenePoplatky = new ZaplacenePoplatky
            {
                DatumUhrady = datePickerDatumUhrady.Value,
                ObyvatelId = int.Parse(txtIdObyvatel.Text)
            };

            // Добавление в список и вызов контроллера для создания
            zaplacenePoplatky.Add(newZaplacenePoplatky);
            zaplacenePoplatkyController.Create(newZaplacenePoplatky);

            // Очистка полей после создания
            txtIdObyvatel.Text = "";

            // Обновление списка
            UpdateList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Вызов метода контроллера для получения списка
            zaplacenePoplatky = zaplacenePoplatkyController.GetAll();

            // Обновление списка
            UpdateList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listZaplacenePoplatky.SelectedIndex != -1)
            {
                // Получение выбранного объекта и обновление его значений
                ZaplacenePoplatky selectedZaplacenePoplatky = zaplacenePoplatky[listZaplacenePoplatky.SelectedIndex];
                selectedZaplacenePoplatky.DatumUhrady = datePickerDatumUhrady.Value;
                selectedZaplacenePoplatky.ObyvatelId = int.Parse(txtIdObyvatel.Text);

                // Вызов метода контроллера для обновления
                zaplacenePoplatkyController.Update(selectedZaplacenePoplatky.Id, selectedZaplacenePoplatky);

                // Очистка полей после обновления
                txtIdObyvatel.Text = "";

                // Обновление списка
                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listZaplacenePoplatky.SelectedIndex != -1)
            {
                // Удаление выбранного объекта из списка и вызов контроллера для удаления
                ZaplacenePoplatky selectedZaplacenePoplatky = zaplacenePoplatky[listZaplacenePoplatky.SelectedIndex];
                zaplacenePoplatky.RemoveAt(listZaplacenePoplatky.SelectedIndex);
                zaplacenePoplatkyController.Delete(selectedZaplacenePoplatky.Id);

                // Обновление списка
                UpdateList();
            }
        }

        private void UpdateList()
        {
            // Очистка списка и добавление всех элементов из списка zaplacenePoplatky
            listZaplacenePoplatky.Items.Clear();
            foreach (var zaplacenePoplatky in zaplacenePoplatky)
            {
                listZaplacenePoplatky.Items.Add(zaplacenePoplatky.DatumUhrady.ToShortDateString());
            }
        }
    }
}
