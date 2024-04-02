namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    partial class Form1
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
            btnBytovaJednotka = new Button();
            btnObyvatel = new Button();
            btnZaplacenePoplatky = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBytovaJednotka
            // 
            btnBytovaJednotka.Location = new Point(425, 282);
            btnBytovaJednotka.Name = "btnBytovaJednotka";
            btnBytovaJednotka.Size = new Size(131, 23);
            btnBytovaJednotka.TabIndex = 0;
            btnBytovaJednotka.Text = "btnBytovaJednotka";
            btnBytovaJednotka.UseVisualStyleBackColor = true;
            // 
            // btnObyvatel
            // 
            btnObyvatel.Location = new Point(333, 282);
            btnObyvatel.Name = "btnObyvatel";
            btnObyvatel.Size = new Size(86, 23);
            btnObyvatel.TabIndex = 1;
            btnObyvatel.Text = "btnObyvatel";
            btnObyvatel.UseVisualStyleBackColor = true;
            btnObyvatel.Click += btnObyvatel_Click_1;
            // 
            // btnZaplacenePoplatky
            // 
            btnZaplacenePoplatky.Location = new Point(177, 282);
            btnZaplacenePoplatky.Name = "btnZaplacenePoplatky";
            btnZaplacenePoplatky.Size = new Size(150, 23);
            btnZaplacenePoplatky.TabIndex = 2;
            btnZaplacenePoplatky.Text = "btnZaplacenePoplatky";
            btnZaplacenePoplatky.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(177, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(379, 233);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnZaplacenePoplatky);
            Controls.Add(btnObyvatel);
            Controls.Add(btnBytovaJednotka);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBytovaJednotka;
        private Button btnObyvatel;
        private Button btnZaplacenePoplatky;
        private DataGridView dataGridView1;
    }
}