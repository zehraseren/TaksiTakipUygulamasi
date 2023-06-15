namespace Taksi.UserControls
{
    partial class Driver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DriverPanel = new Panel();
            TitlePanel = new Panel();
            DPhoneRB = new RadioButton();
            label2 = new Label();
            DriverNameRB = new RadioButton();
            label3 = new Label();
            AddDriverButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            SearchTxt = new TextBox();
            ShowExpenseButton = new Button();
            SearchButton = new Button();
            DriverDGV = new DataGridView();
            DriverPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DriverDGV).BeginInit();
            SuspendLayout();
            // 
            // DriverPanel
            // 
            DriverPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DriverPanel.BackColor = Color.Transparent;
            DriverPanel.BackgroundImageLayout = ImageLayout.Stretch;
            DriverPanel.Controls.Add(TitlePanel);
            DriverPanel.Controls.Add(DriverDGV);
            DriverPanel.Location = new Point(0, 0);
            DriverPanel.Name = "DriverPanel";
            DriverPanel.Size = new Size(900, 470);
            DriverPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(DPhoneRB);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(DriverNameRB);
            TitlePanel.Controls.Add(label3);
            TitlePanel.Controls.Add(AddDriverButton);
            TitlePanel.Controls.Add(RemoveButton);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(SearchTxt);
            TitlePanel.Controls.Add(ShowExpenseButton);
            TitlePanel.Controls.Add(SearchButton);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // DPhoneRB
            // 
            DPhoneRB.AutoSize = true;
            DPhoneRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DPhoneRB.ForeColor = Color.White;
            DPhoneRB.Location = new Point(172, 110);
            DPhoneRB.Name = "DPhoneRB";
            DPhoneRB.Size = new Size(87, 24);
            DPhoneRB.TabIndex = 88;
            DPhoneRB.Text = "Telefon";
            DPhoneRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(391, 20);
            label2.Name = "label2";
            label2.Size = new Size(125, 29);
            label2.TabIndex = 58;
            label2.Text = "Sürücüler";
            // 
            // DriverNameRB
            // 
            DriverNameRB.AutoSize = true;
            DriverNameRB.Checked = true;
            DriverNameRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DriverNameRB.ForeColor = Color.White;
            DriverNameRB.Location = new Point(50, 109);
            DriverNameRB.Name = "DriverNameRB";
            DriverNameRB.Size = new Size(115, 24);
            DriverNameRB.TabIndex = 90;
            DriverNameRB.TabStop = true;
            DriverNameRB.Text = "Sürücü Adı";
            DriverNameRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 85);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 85;
            label3.Text = "Arama tipini seçiniz:";
            // 
            // AddDriverButton
            // 
            AddDriverButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDriverButton.AutoSize = true;
            AddDriverButton.BackColor = Color.FromArgb(255, 183, 3);
            AddDriverButton.FlatAppearance.BorderSize = 0;
            AddDriverButton.FlatStyle = FlatStyle.Flat;
            AddDriverButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddDriverButton.ForeColor = Color.White;
            AddDriverButton.Location = new Point(669, 108);
            AddDriverButton.Name = "AddDriverButton";
            AddDriverButton.Size = new Size(181, 30);
            AddDriverButton.TabIndex = 0;
            AddDriverButton.Text = "Yeni Sürücü Ekle";
            AddDriverButton.UseVisualStyleBackColor = false;
            AddDriverButton.Click += AddDriverButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.BackColor = Color.FromArgb(111, 0, 0);
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(623, 108);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(40, 30);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Sil";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.AutoSize = true;
            EditButton.BackColor = Color.FromArgb(2, 48, 71);
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(532, 108);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(85, 30);
            EditButton.TabIndex = 2;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTxt.Location = new Point(260, 108);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(145, 26);
            SearchTxt.TabIndex = 7;
            // 
            // ShowExpenseButton
            // 
            ShowExpenseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowExpenseButton.AutoSize = true;
            ShowExpenseButton.BackColor = Color.FromArgb(88, 24, 69);
            ShowExpenseButton.FlatAppearance.BorderSize = 0;
            ShowExpenseButton.FlatStyle = FlatStyle.Flat;
            ShowExpenseButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShowExpenseButton.ForeColor = Color.White;
            ShowExpenseButton.Location = new Point(728, 75);
            ShowExpenseButton.Name = "ShowExpenseButton";
            ShowExpenseButton.Size = new Size(122, 30);
            ShowExpenseButton.TabIndex = 3;
            ShowExpenseButton.Text = "Giderleri Gör";
            ShowExpenseButton.UseVisualStyleBackColor = false;
            ShowExpenseButton.Click += ShowExpenseButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.AutoSize = true;
            SearchButton.BackColor = Color.FromArgb(88, 24, 69);
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(411, 108);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(48, 30);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Ara";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // DriverDGV
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DriverDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            DriverDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DriverDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DriverDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DriverDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DriverDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DriverDGV.DefaultCellStyle = dataGridViewCellStyle8;
            DriverDGV.Location = new Point(50, 140);
            DriverDGV.Name = "DriverDGV";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DriverDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DriverDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DriverDGV.RowTemplate.Height = 25;
            DriverDGV.Size = new Size(800, 300);
            DriverDGV.TabIndex = 8;
            // 
            // Driver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(DriverPanel);
            Name = "Driver";
            Size = new Size(900, 470);
            DriverPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DriverDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DriverPanel;
        private Button SearchButton;
        private Button ShowExpenseButton;
        private Button EditButton;
        private Button RemoveButton;
        private Button AddDriverButton;
        public TextBox SearchTxt;
        private DataGridView DriverDGV;
        private Panel TitlePanel;
        private Label label2;
        private RadioButton DPhoneRB;
        private RadioButton DriverNameRB;
        private Label label3;
    }
}
