namespace Taksi.UserControls
{
    partial class Customer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            CustomerPanel = new Panel();
            TitlePanel = new Panel();
            CPhoneRB = new RadioButton();
            label2 = new Label();
            CustomerNameRB = new RadioButton();
            label3 = new Label();
            SearchButton = new Button();
            EditButton = new Button();
            AddCustomerButton = new Button();
            RemoveButton = new Button();
            SearchTxt = new TextBox();
            CustomerStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            CustomerDGV = new DataGridView();
            CustomerPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            CustomerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            SuspendLayout();
            // 
            // CustomerPanel
            // 
            CustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerPanel.BackColor = Color.Transparent;
            CustomerPanel.Controls.Add(TitlePanel);
            CustomerPanel.Controls.Add(CustomerStatus);
            CustomerPanel.Controls.Add(CustomerDGV);
            CustomerPanel.Location = new Point(0, 0);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(900, 470);
            CustomerPanel.TabIndex = 19;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(CPhoneRB);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(CustomerNameRB);
            TitlePanel.Controls.Add(label3);
            TitlePanel.Controls.Add(SearchButton);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(AddCustomerButton);
            TitlePanel.Controls.Add(RemoveButton);
            TitlePanel.Controls.Add(SearchTxt);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // CPhoneRB
            // 
            CPhoneRB.AutoSize = true;
            CPhoneRB.Checked = true;
            CPhoneRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPhoneRB.ForeColor = Color.White;
            CPhoneRB.Location = new Point(50, 104);
            CPhoneRB.Name = "CPhoneRB";
            CPhoneRB.Size = new Size(87, 24);
            CPhoneRB.TabIndex = 80;
            CPhoneRB.TabStop = true;
            CPhoneRB.Text = "Telefon";
            CPhoneRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(388, 20);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 58;
            label2.Text = "Müşteriler";
            // 
            // CustomerNameRB
            // 
            CustomerNameRB.AutoSize = true;
            CustomerNameRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerNameRB.ForeColor = Color.White;
            CustomerNameRB.Location = new Point(138, 104);
            CustomerNameRB.Name = "CustomerNameRB";
            CustomerNameRB.Size = new Size(117, 24);
            CustomerNameRB.TabIndex = 82;
            CustomerNameRB.Text = "Müşteri Adı";
            CustomerNameRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 84);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 75;
            label3.Text = "Arama tipini seçiniz:";
            // 
            // SearchButton
            // 
            SearchButton.AutoSize = true;
            SearchButton.BackColor = Color.FromArgb(88, 24, 69);
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 224, 192);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(404, 104);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(47, 30);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Ara";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.AutoSize = true;
            EditButton.BackColor = Color.FromArgb(2, 48, 71);
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 224, 192);
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(526, 104);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(85, 30);
            EditButton.TabIndex = 14;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddCustomerButton.AutoSize = true;
            AddCustomerButton.BackColor = Color.FromArgb(255, 183, 3);
            AddCustomerButton.FlatAppearance.BorderSize = 0;
            AddCustomerButton.FlatStyle = FlatStyle.Flat;
            AddCustomerButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCustomerButton.ForeColor = Color.White;
            AddCustomerButton.Location = new Point(663, 104);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(187, 30);
            AddCustomerButton.TabIndex = 19;
            AddCustomerButton.Text = "Yeni Müşteri Ekle";
            AddCustomerButton.UseVisualStyleBackColor = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.BackColor = Color.FromArgb(111, 0, 0);
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 224, 192);
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(617, 104);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(40, 30);
            RemoveButton.TabIndex = 15;
            RemoveButton.Text = "Sil";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Cursor = Cursors.IBeam;
            SearchTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTxt.Location = new Point(261, 104);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(132, 26);
            SearchTxt.TabIndex = 11;
            // 
            // CustomerStatus
            // 
            CustomerStatus.BackColor = Color.Transparent;
            CustomerStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            CustomerStatus.Location = new Point(0, 445);
            CustomerStatus.Name = "CustomerStatus";
            CustomerStatus.Size = new Size(900, 25);
            CustomerStatus.TabIndex = 17;
            CustomerStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // CustomerDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomerDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomerDGV.Location = new Point(50, 140);
            CustomerDGV.Name = "CustomerDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CustomerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CustomerDGV.RowTemplate.Height = 25;
            CustomerDGV.Size = new Size(800, 300);
            CustomerDGV.TabIndex = 16;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(CustomerPanel);
            Name = "Customer";
            Size = new Size(900, 470);
            CustomerPanel.ResumeLayout(false);
            CustomerPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            CustomerStatus.ResumeLayout(false);
            CustomerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CustomerPanel;
        private StatusStrip CustomerStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox SearchTxt;
        private Button RemoveButton;
        private DataGridView CustomerDGV;
        private Button EditButton;
        private Button SearchButton;
        private Button AddCustomerButton;
        private Panel TitlePanel;
        private Label label2;
        private RadioButton CPhoneRB;
        private RadioButton CustomerNameRB;
        private Label label3;
    }
}
