namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    partial class ObyvatelForm
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
            Jmeno = new Label();
            IdBytovaJednotka = new Label();
            Prijmeni = new Label();
            txtJmeno = new TextBox();
            txtPrijmeni = new TextBox();
            txtIdBytovaJednotka = new TextBox();
            button1 = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            btnCreate = new Button();
            listObyvatele = new ListBox();
            SuspendLayout();
            // 
            // Jmeno
            // 
            Jmeno.AutoSize = true;
            Jmeno.Location = new Point(443, 141);
            Jmeno.Name = "Jmeno";
            Jmeno.Size = new Size(42, 15);
            Jmeno.TabIndex = 0;
            Jmeno.Text = "Jmeno";
            Jmeno.Click += Jmeno_Click;
            // 
            // IdBytovaJednotka
            // 
            IdBytovaJednotka.AutoSize = true;
            IdBytovaJednotka.Location = new Point(443, 18);
            IdBytovaJednotka.Name = "IdBytovaJednotka";
            IdBytovaJednotka.Size = new Size(100, 15);
            IdBytovaJednotka.TabIndex = 1;
            IdBytovaJednotka.Text = "IdBytovaJednotka";
            IdBytovaJednotka.Click += IdBytovaJednotka_Click;
            // 
            // Prijmeni
            // 
            Prijmeni.AutoSize = true;
            Prijmeni.Location = new Point(443, 81);
            Prijmeni.Name = "Prijmeni";
            Prijmeni.Size = new Size(51, 15);
            Prijmeni.TabIndex = 2;
            Prijmeni.Text = "Prijmeni";
            // 
            // txtJmeno
            // 
            txtJmeno.Location = new Point(443, 159);
            txtJmeno.Name = "txtJmeno";
            txtJmeno.Size = new Size(100, 23);
            txtJmeno.TabIndex = 3;
            txtJmeno.Text = "txtJmeno";
            txtJmeno.TextChanged += textBox1_TextChanged;
            // 
            // txtPrijmeni
            // 
            txtPrijmeni.Location = new Point(443, 99);
            txtPrijmeni.Name = "txtPrijmeni";
            txtPrijmeni.Size = new Size(100, 23);
            txtPrijmeni.TabIndex = 4;
            txtPrijmeni.Text = "txtPrijmeni";
            // 
            // txtIdBytovaJednotka
            // 
            txtIdBytovaJednotka.Location = new Point(443, 36);
            txtIdBytovaJednotka.Name = "txtIdBytovaJednotka";
            txtIdBytovaJednotka.Size = new Size(100, 23);
            txtIdBytovaJednotka.TabIndex = 5;
            txtIdBytovaJednotka.Text = "txtIdBytovaJednotka";
            // 
            // button1
            // 
            button1.Location = new Point(246, 313);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "btnDelete";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(163, 313);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(82, 313);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 8;
            btnRead.Text = "btnRead";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 313);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "btnCreate";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // listObyvatele
            // 
            listObyvatele.FormattingEnabled = true;
            listObyvatele.ItemHeight = 15;
            listObyvatele.Location = new Point(3, 3);
            listObyvatele.Name = "listObyvatele";
            listObyvatele.Size = new Size(318, 304);
            listObyvatele.TabIndex = 10;
            // 
            // ObyvatelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listObyvatele);
            Controls.Add(btnCreate);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(txtIdBytovaJednotka);
            Controls.Add(txtPrijmeni);
            Controls.Add(txtJmeno);
            Controls.Add(Prijmeni);
            Controls.Add(IdBytovaJednotka);
            Controls.Add(Jmeno);
            Name = "ObyvatelForm";
            Text = "ObyvatelForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Jmeno;
        private Label IdBytovaJednotka;
        private Label Prijmeni;
        private TextBox txtJmeno;
        private TextBox txtPrijmeni;
        private TextBox txtIdBytovaJednotka;
        private Button button1;
        private Button btnUpdate;
        private Button btnRead;
        private Button btnCreate;
        private ListBox listObyvatele;
    }
}