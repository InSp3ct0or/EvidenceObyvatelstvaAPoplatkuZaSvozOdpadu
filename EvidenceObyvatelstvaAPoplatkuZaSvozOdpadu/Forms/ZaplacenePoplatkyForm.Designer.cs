
namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    partial class ZaplacenePoplatkyForm
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
            btnUpdate = new Button();
            btnRead = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            datePickerDatumUhrady = new DateTimePicker();
            DatumUhrady = new Label();
            IdObyvatel = new Label();
            listZaplacenePoplatky = new ListBox();
            txtIdObyvatel = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(174, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(93, 308);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 1;
            btnRead.Text = "btnRead";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 308);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "btnCreate";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 308);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // datePickerDatumUhrady
            // 
            datePickerDatumUhrady.Location = new Point(456, 27);
            datePickerDatumUhrady.Name = "datePickerDatumUhrady";
            datePickerDatumUhrady.Size = new Size(200, 23);
            datePickerDatumUhrady.TabIndex = 4;
            datePickerDatumUhrady.ValueChanged += datePickerDatumUhrady_ValueChanged;
            // 
            // DatumUhrady
            // 
            DatumUhrady.AutoSize = true;
            DatumUhrady.Location = new Point(456, 9);
            DatumUhrady.Name = "DatumUhrady";
            DatumUhrady.Size = new Size(81, 15);
            DatumUhrady.TabIndex = 5;
            DatumUhrady.Text = "DatumUhrady";
            // 
            // IdObyvatel
            // 
            IdObyvatel.AutoSize = true;
            IdObyvatel.Location = new Point(456, 69);
            IdObyvatel.Name = "IdObyvatel";
            IdObyvatel.Size = new Size(64, 15);
            IdObyvatel.TabIndex = 7;
            IdObyvatel.Text = "IdObyvatel";
            // 
            // listZaplacenePoplatky
            // 
            listZaplacenePoplatky.FormattingEnabled = true;
            listZaplacenePoplatky.ItemHeight = 15;
            listZaplacenePoplatky.Location = new Point(12, 9);
            listZaplacenePoplatky.Name = "listZaplacenePoplatky";
            listZaplacenePoplatky.Size = new Size(320, 289);
            listZaplacenePoplatky.TabIndex = 8;
            listZaplacenePoplatky.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtIdObyvatel
            // 
            txtIdObyvatel.Location = new Point(456, 87);
            txtIdObyvatel.Name = "txtIdObyvatel";
            txtIdObyvatel.Size = new Size(100, 23);
            txtIdObyvatel.TabIndex = 10;
            txtIdObyvatel.Text = "txtIdObyvatel";
            // 
            // ZaplacenePoplatkyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdObyvatel);
            Controls.Add(listZaplacenePoplatky);
            Controls.Add(IdObyvatel);
            Controls.Add(DatumUhrady);
            Controls.Add(datePickerDatumUhrady);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Name = "ZaplacenePoplatkyForm";
            Text = "ZaplacenePoplatkyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void datePickerDatumUhrady_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnUpdate;
        private Button btnRead;
        private Button btnCreate;
        private Button btnDelete;
        private DateTimePicker datePickerDatumUhrady;
        private Label DatumUhrady;
        private Label IdObyvatel;
        private ListBox listZaplacenePoplatky;
        private TextBox txtIdObyvatel;
    }
}