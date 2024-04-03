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
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dataGridView1.Columns.Add("Home");
            dataGridView1.Columns.Add("Human");
            dataGridView1.Columns.Add("Date");
        }

        private void btnBytovaJednotka_Click(object sender, EventArgs e)
        {
            BytovaJednotkaForm bytovaJednotkaForm = new BytovaJednotkaForm();
            bytovaJednotkaForm.Show();
        }

        private void btnObyvatel_Click(object sender, EventArgs e)
        {
            ObyvatelForm obyvatelForm = new ObyvatelForm();
            obyvatelForm.Show();
        }

        private void btnZaplacenePoplatky_Click(object sender, EventArgs e)
        {
            ZaplacenePoplatkyForm zaplacenePoplatkyForm = new ZaplacenePoplatkyForm();
            zaplacenePoplatkyForm.Show();
        }

        private void btnObyvatel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
