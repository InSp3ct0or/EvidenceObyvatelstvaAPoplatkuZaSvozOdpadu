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
            Obyvatel newObyvatel = new Obyvatel
            {
                Jmeno = txtJmeno.Text,
                Prijmeni = txtPrijmeni.Text,
                BytovaJednotkaId = int.Parse(txtIdBytovaJednotka.Text)
            };

            obyvatele.Add(newObyvatel);
            obyvatelController.Create(newObyvatel);

            txtJmeno.Text = "";
            txtPrijmeni.Text = "";
            txtIdBytovaJednotka.Text = "";

            UpdateList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            obyvatele = obyvatelController.GetAll();
            UpdateList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listObyvatele.SelectedIndex != -1)
            {
                Obyvatel selectedObyvatel = obyvatele[listObyvatele.SelectedIndex];
                selectedObyvatel.Jmeno = txtJmeno.Text;
                selectedObyvatel.Prijmeni = txtPrijmeni.Text;
                selectedObyvatel.BytovaJednotkaId = int.Parse(txtIdBytovaJednotka.Text);

                obyvatelController.Update(selectedObyvatel.Id, selectedObyvatel);

                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                txtIdBytovaJednotka.Text = "";

                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listObyvatele.SelectedIndex != -1)
            {
                Obyvatel selectedObyvatel = obyvatele[listObyvatele.SelectedIndex];
                obyvatele.RemoveAt(listObyvatele.SelectedIndex);
                obyvatelController.Delete(selectedObyvatel.Id);

                UpdateList();
            }
        }

        private void UpdateList()
        {
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
