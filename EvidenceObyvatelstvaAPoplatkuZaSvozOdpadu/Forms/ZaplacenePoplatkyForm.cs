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
           
            ZaplacenePoplatky newZaplacenePoplatky = new ZaplacenePoplatky
            {
                DatumUhrady = datePickerDatumUhrady.Value,
                ObyvatelId = int.Parse(txtIdObyvatel.Text)
            };

            
            zaplacenePoplatky.Add(newZaplacenePoplatky);
            zaplacenePoplatkyController.Create(newZaplacenePoplatky);

            
            txtIdObyvatel.Text = "";

            
            UpdateList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            zaplacenePoplatky = zaplacenePoplatkyController.GetAll();


            UpdateList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listZaplacenePoplatky.SelectedIndex != -1)
            {
                
                ZaplacenePoplatky selectedZaplacenePoplatky = zaplacenePoplatky[listZaplacenePoplatky.SelectedIndex];
                selectedZaplacenePoplatky.DatumUhrady = datePickerDatumUhrady.Value;
                selectedZaplacenePoplatky.ObyvatelId = int.Parse(txtIdObyvatel.Text);

               
                zaplacenePoplatkyController.Update(selectedZaplacenePoplatky.Id, selectedZaplacenePoplatky);

               
                txtIdObyvatel.Text = "";

                
                UpdateList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listZaplacenePoplatky.SelectedIndex != -1)
            {
               
                ZaplacenePoplatky selectedZaplacenePoplatky = zaplacenePoplatky[listZaplacenePoplatky.SelectedIndex];
                zaplacenePoplatky.RemoveAt(listZaplacenePoplatky.SelectedIndex);
                zaplacenePoplatkyController.Delete(selectedZaplacenePoplatky.Id);

               
                UpdateList();
            }
        }

        private void UpdateList()
        {
            
            listZaplacenePoplatky.Items.Clear();
            foreach (var zaplacenePoplatky in zaplacenePoplatky)
            {
                listZaplacenePoplatky.Items.Add(zaplacenePoplatky.DatumUhrady.ToShortDateString());
            }
        }
    }
}
