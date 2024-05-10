namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms
{
    partial class MainForm
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
            BytovaJednotkaTabPage = new TabPage();
            EnterNameStreet = new Label();
            EnterNameStreetTextBox = new TextBox();
            EnterMonetaryAmount = new Label();
            ChangeSum = new TextBox();
            ChangeAll = new Button();
            BytovaJednotkaDataGridView = new DataGridView();
            BytovaJednotkaDeleteButton = new Button();
            ObyvatelTabPage = new TabPage();
            ObyvatelDataGridView = new DataGridView();
            ObyvatelDeleteButton = new Button();
            ZaplacenePoplatkyTabPage = new TabPage();
            ZaplacenePoplatkyDataGridView = new DataGridView();
            ZaplacenePoplatkyDeleteButton = new Button();
            MainFormTabControl = new TabControl();
            Update = new Button();
            BytovaJednotkaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BytovaJednotkaDataGridView).BeginInit();
            ObyvatelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ObyvatelDataGridView).BeginInit();
            ZaplacenePoplatkyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ZaplacenePoplatkyDataGridView).BeginInit();
            MainFormTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // BytovaJednotkaTabPage
            // 
            BytovaJednotkaTabPage.Controls.Add(Update);
            BytovaJednotkaTabPage.Controls.Add(EnterNameStreet);
            BytovaJednotkaTabPage.Controls.Add(EnterNameStreetTextBox);
            BytovaJednotkaTabPage.Controls.Add(EnterMonetaryAmount);
            BytovaJednotkaTabPage.Controls.Add(ChangeSum);
            BytovaJednotkaTabPage.Controls.Add(ChangeAll);
            BytovaJednotkaTabPage.Controls.Add(BytovaJednotkaDataGridView);
            BytovaJednotkaTabPage.Controls.Add(BytovaJednotkaDeleteButton);
            BytovaJednotkaTabPage.Location = new Point(4, 24);
            BytovaJednotkaTabPage.Name = "BytovaJednotkaTabPage";
            BytovaJednotkaTabPage.Padding = new Padding(3);
            BytovaJednotkaTabPage.Size = new Size(774, 420);
            BytovaJednotkaTabPage.TabIndex = 3;
            BytovaJednotkaTabPage.Text = "BytovaJednotka";
            BytovaJednotkaTabPage.UseVisualStyleBackColor = true;
            // 
            // EnterNameStreet
            // 
            EnterNameStreet.AutoSize = true;
            EnterNameStreet.Location = new Point(195, 345);
            EnterNameStreet.Name = "EnterNameStreet";
            EnterNameStreet.Size = new Size(102, 15);
            EnterNameStreet.TabIndex = 22;
            EnterNameStreet.Text = "Enter Name Street";
            // 
            // EnterNameStreetTextBox
            // 
            EnterNameStreetTextBox.Location = new Point(195, 363);
            EnterNameStreetTextBox.Name = "EnterNameStreetTextBox";
            EnterNameStreetTextBox.Size = new Size(100, 23);
            EnterNameStreetTextBox.TabIndex = 21;
            EnterNameStreetTextBox.KeyPress += EnterNameStreetTextBox_KeyPress;
            // 
            // EnterMonetaryAmount
            // 
            EnterMonetaryAmount.AutoSize = true;
            EnterMonetaryAmount.Location = new Point(6, 345);
            EnterMonetaryAmount.Name = "EnterMonetaryAmount";
            EnterMonetaryAmount.Size = new Size(133, 15);
            EnterMonetaryAmount.TabIndex = 20;
            EnterMonetaryAmount.Text = "Enter monetary amount";
            // 
            // ChangeSum
            // 
            ChangeSum.Location = new Point(6, 363);
            ChangeSum.Name = "ChangeSum";
            ChangeSum.Size = new Size(140, 23);
            ChangeSum.TabIndex = 19;
            ChangeSum.Tag = "";
            ChangeSum.TextAlign = HorizontalAlignment.Center;
            // 
            // ChangeAll
            // 
            ChangeAll.Location = new Point(6, 391);
            ChangeAll.Name = "ChangeAll";
            ChangeAll.Size = new Size(80, 23);
            ChangeAll.TabIndex = 18;
            ChangeAll.Text = "Change All";
            ChangeAll.UseVisualStyleBackColor = true;
            ChangeAll.Click += ChangeAllButton_Click;
            // 
            // BytovaJednotkaDataGridView
            // 
            BytovaJednotkaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BytovaJednotkaDataGridView.Location = new Point(6, 6);
            BytovaJednotkaDataGridView.Name = "BytovaJednotkaDataGridView";
            BytovaJednotkaDataGridView.RowTemplate.Height = 25;
            BytovaJednotkaDataGridView.Size = new Size(762, 150);
            BytovaJednotkaDataGridView.TabIndex = 16;
            // 
            // BytovaJednotkaDeleteButton
            // 
            BytovaJednotkaDeleteButton.Location = new Point(573, 362);
            BytovaJednotkaDeleteButton.Name = "BytovaJednotkaDeleteButton";
            BytovaJednotkaDeleteButton.Size = new Size(195, 23);
            BytovaJednotkaDeleteButton.TabIndex = 17;
            BytovaJednotkaDeleteButton.Text = "Delete";
            BytovaJednotkaDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ObyvatelTabPage
            // 
            ObyvatelTabPage.Controls.Add(ObyvatelDataGridView);
            ObyvatelTabPage.Controls.Add(ObyvatelDeleteButton);
            ObyvatelTabPage.Location = new Point(4, 24);
            ObyvatelTabPage.Name = "ObyvatelTabPage";
            ObyvatelTabPage.Padding = new Padding(3);
            ObyvatelTabPage.Size = new Size(774, 420);
            ObyvatelTabPage.TabIndex = 2;
            ObyvatelTabPage.Text = "Obyvatel";
            ObyvatelTabPage.UseVisualStyleBackColor = true;
            // 
            // ObyvatelDataGridView
            // 
            ObyvatelDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ObyvatelDataGridView.Location = new Point(3, 6);
            ObyvatelDataGridView.Name = "ObyvatelDataGridView";
            ObyvatelDataGridView.RowTemplate.Height = 25;
            ObyvatelDataGridView.Size = new Size(765, 150);
            ObyvatelDataGridView.TabIndex = 16;
            // 
            // ObyvatelDeleteButton
            // 
            ObyvatelDeleteButton.Location = new Point(573, 361);
            ObyvatelDeleteButton.Name = "ObyvatelDeleteButton";
            ObyvatelDeleteButton.Size = new Size(195, 23);
            ObyvatelDeleteButton.TabIndex = 17;
            ObyvatelDeleteButton.Text = "Delete";
            ObyvatelDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ZaplacenePoplatkyTabPage
            // 
            ZaplacenePoplatkyTabPage.Controls.Add(ZaplacenePoplatkyDataGridView);
            ZaplacenePoplatkyTabPage.Controls.Add(ZaplacenePoplatkyDeleteButton);
            ZaplacenePoplatkyTabPage.Location = new Point(4, 24);
            ZaplacenePoplatkyTabPage.Name = "ZaplacenePoplatkyTabPage";
            ZaplacenePoplatkyTabPage.Padding = new Padding(3);
            ZaplacenePoplatkyTabPage.Size = new Size(774, 420);
            ZaplacenePoplatkyTabPage.TabIndex = 1;
            ZaplacenePoplatkyTabPage.Text = "Zaplacene Poplatky";
            ZaplacenePoplatkyTabPage.UseVisualStyleBackColor = true;
            // 
            // ZaplacenePoplatkyDataGridView
            // 
            ZaplacenePoplatkyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZaplacenePoplatkyDataGridView.Location = new Point(6, 6);
            ZaplacenePoplatkyDataGridView.Name = "ZaplacenePoplatkyDataGridView";
            ZaplacenePoplatkyDataGridView.RowTemplate.Height = 25;
            ZaplacenePoplatkyDataGridView.Size = new Size(762, 150);
            ZaplacenePoplatkyDataGridView.TabIndex = 5;
            // 
            // ZaplacenePoplatkyDeleteButton
            // 
            ZaplacenePoplatkyDeleteButton.Location = new Point(573, 357);
            ZaplacenePoplatkyDeleteButton.Name = "ZaplacenePoplatkyDeleteButton";
            ZaplacenePoplatkyDeleteButton.Size = new Size(195, 23);
            ZaplacenePoplatkyDeleteButton.TabIndex = 7;
            ZaplacenePoplatkyDeleteButton.Text = "Delete";
            ZaplacenePoplatkyDeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainFormTabControl
            // 
            MainFormTabControl.Controls.Add(ZaplacenePoplatkyTabPage);
            MainFormTabControl.Controls.Add(ObyvatelTabPage);
            MainFormTabControl.Controls.Add(BytovaJednotkaTabPage);
            MainFormTabControl.Location = new Point(12, 0);
            MainFormTabControl.Name = "MainFormTabControl";
            MainFormTabControl.SelectedIndex = 0;
            MainFormTabControl.Size = new Size(782, 448);
            MainFormTabControl.TabIndex = 0;
            // 
            // Update
            // 
            Update.Location = new Point(195, 391);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 23;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += UpdateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainFormTabControl);
            Name = "MainForm";
            Text = "MainForm";
            BytovaJednotkaTabPage.ResumeLayout(false);
            BytovaJednotkaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BytovaJednotkaDataGridView).EndInit();
            ObyvatelTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ObyvatelDataGridView).EndInit();
            ZaplacenePoplatkyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ZaplacenePoplatkyDataGridView).EndInit();
            MainFormTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage BytovaJednotkaTabPage;
        private TabPage ObyvatelTabPage;
        private TabPage ZaplacenePoplatkyTabPage;
        private Button ZaplacenePoplatkyDeleteButton;
        private Button ZaplacenePoplatkyCreateButton;
        private DataGridView ZaplacenePoplatkyDataGridView;
        private TabControl MainFormTabControl;
        private Button ZaplacenePoplatkyUpdateButton;
        private TextBox textBoxRokPoplatku;
        private Label DatumUhrady;
        private Label ZaplacenePoplatkyId;
        private Label RokPoplatku;
        private TextBox textBoxDatumUhrady;
        private TextBox textBoxObyvatelId;
        private Label Id;
        private DataGridView BytovaJednotkaDataGridView;
        private Label Adresa;
        private Button BytovaJednotkaCreateButton;
        private Label VyskaPoplatkuZaObyvatele;
        private Button BytovaJednotkaDeleteButton;
        private TextBox textBoxId;
        private Button BytovaJednotkaUpdateButton;
        private TextBox textBoxAdresa;
        private TextBox textBoxVyskaPoplatkuZaObyvatele;
        private Label Prijmeni;
        private DataGridView ObyvatelDataGridView;
        private Label Jmeno;
        private Button ObyvatelCreateButton;
        private Label IdObyvatel;
        private Button ObyvatelDeleteButton;
        private TextBox textBoxPrijmeni;
        private Button ObyvatelUpdateButton;
        private TextBox textBoxJmeno;
        private TextBox textBoxIdObyvatel;
        private Label BytovaJednotkaId;
        private TextBox textBoxBytovaJednotkaId;
        private TextBox ChangeSum;
        private Button ChangeAll;
        private Label EnterMonetaryAmount;
        private Label EnterNameStreet;
        private TextBox EnterNameStreetTextBox;
        private Button Update;
    }
}
