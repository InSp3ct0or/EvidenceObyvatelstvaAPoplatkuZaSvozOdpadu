
namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    partial class BytovaJednotkaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBytoveJednotky = new ListBox();
            txtAdresa = new TextBox();
            txtPoplatek = new TextBox();
            label1 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            Poplatek = new Label();
            Adresa = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBytoveJednotky
            // 
            listBytoveJednotky.FormattingEnabled = true;
            listBytoveJednotky.ItemHeight = 15;
            listBytoveJednotky.Location = new Point(12, 18);
            listBytoveJednotky.Name = "listBytoveJednotky";
            listBytoveJednotky.Size = new Size(318, 289);
            listBytoveJednotky.TabIndex = 0;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(512, 148);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(251, 23);
            txtAdresa.TabIndex = 1;
            txtAdresa.TextChanged += txtAdresa_TextChanged;
            // 
            // txtPoplatek
            // 
            txtPoplatek.Location = new Point(512, 48);
            txtPoplatek.Name = "txtPoplatek";
            txtPoplatek.Size = new Size(251, 23);
            txtPoplatek.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 15);
            label1.TabIndex = 3;
            label1.Text = "Displaying the list of living quarters\n";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 313);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "btnCreate";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(174, 313);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(93, 313);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 6;
            btnRead.Text = "btnRead";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // Poplatek
            // 
            Poplatek.AutoSize = true;
            Poplatek.Location = new Point(512, 30);
            Poplatek.Name = "Poplatek";
            Poplatek.Size = new Size(238, 15);
            Poplatek.TabIndex = 7;
            Poplatek.Text = "Enter the amount of payment for a resident.";
            // 
            // Adresa
            // 
            Adresa.AutoSize = true;
            Adresa.Location = new Point(512, 130);
            Adresa.Name = "Adresa";
            Adresa.Size = new Size(241, 15);
            Adresa.TabIndex = 8;
            Adresa.Text = "Enter the address of the residential premises.";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // BytovaJednotkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 435);
            Controls.Add(btnDelete);
            Controls.Add(Adresa);
            Controls.Add(Poplatek);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(txtPoplatek);
            Controls.Add(txtAdresa);
            Controls.Add(listBytoveJednotky);
            Name = "BytovaJednotkaForm";
            Text = "BytovaJednotkaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private ListBox listBytoveJednotky;
        private TextBox txtAdresa;
        private TextBox txtPoplatek;
        private Label label1;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnRead;
        private Label Poplatek;
        private Label Adresa;
        private Button btnDelete;
    }
}