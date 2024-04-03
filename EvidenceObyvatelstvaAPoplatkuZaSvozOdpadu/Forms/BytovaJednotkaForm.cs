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
            
            BytovaJednotka newBytovaJednotka = new BytovaJednotka
            {
                Adresa = txtAdresa.Text,
                VyskaPoplatkuZaObyvatele = decimal.Parse(txtPoplatek.Text)
            };

          
            bytoveJednotky.Add(newBytovaJednotka);
            bytovaJednotkaController.Create(newBytovaJednotka);

            
            txtAdresa.Text = "";
            txtPoplatek.Text = "";

            
            UpdateList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            bytoveJednotky = bytovaJednotkaController.GetAll();

            
            UpdateList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBytoveJednotky.SelectedIndex != -1)
            {
              
                BytovaJednotka selectedBytovaJednotka = bytoveJednotky[listBytoveJednotky.SelectedIndex];
                selectedBytovaJednotka.Adresa = txtAdresa.Text;
                selectedBytovaJednotka.VyskaPoplatkuZaObyvatele = decimal.Parse(txtPoplatek.Text);

               
                bytovaJednotkaController.Update(selectedBytovaJednotka.Id, selectedBytovaJednotka);

                
                txtAdresa.Text = "";
                txtPoplatek.Text = "";

              
                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBytoveJednotky.SelectedIndex != -1)
            {
                
                BytovaJednotka selectedBytovaJednotka = bytoveJednotky[listBytoveJednotky.SelectedIndex];
                bytoveJednotky.RemoveAt(listBytoveJednotky.SelectedIndex);
                bytovaJednotkaController.Delete(selectedBytovaJednotka.Id);

                
                UpdateList();
            }
        }

        private void UpdateList()
        {
            
            listBytoveJednotky.Items.Clear();
            foreach (var bytovaJednotka in bytoveJednotky)
            {
                listBytoveJednotky.Items.Add(bytovaJednotka.Adresa);
            }
        }
    }
}

