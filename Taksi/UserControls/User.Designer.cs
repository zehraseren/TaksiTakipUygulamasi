namespace Taksi.UserControls
{
    partial class User
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
            UserStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            UserDGV = new DataGridView();
            UserPanel = new Panel();
            TitlePanel = new Panel();
            UsernameRB = new RadioButton();
            UPhoneRB = new RadioButton();
            label3 = new Label();
            SearchBtn = new Button();
            AddButton = new Button();
            EditButton = new Button();
            SearchTxt = new TextBox();
            RemoveButton = new Button();
            label2 = new Label();
            UserStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            UserPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // UserStatus
            // 
            UserStatus.BackColor = Color.Transparent;
            UserStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            UserStatus.Location = new Point(0, 445);
            UserStatus.Name = "UserStatus";
            UserStatus.Size = new Size(900, 25);
            UserStatus.TabIndex = 7;
            UserStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // UserDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UserDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UserDGV.Location = new Point(50, 140);
            UserDGV.Name = "UserDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            UserDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            UserDGV.RowTemplate.Height = 25;
            UserDGV.Size = new Size(800, 300);
            UserDGV.TabIndex = 4;
            // 
            // UserPanel
            // 
            UserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserPanel.Controls.Add(TitlePanel);
            UserPanel.Controls.Add(UserDGV);
            UserPanel.Location = new Point(0, 0);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(900, 470);
            UserPanel.TabIndex = 8;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(UsernameRB);
            TitlePanel.Controls.Add(UPhoneRB);
            TitlePanel.Controls.Add(label3);
            TitlePanel.Controls.Add(SearchBtn);
            TitlePanel.Controls.Add(AddButton);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(SearchTxt);
            TitlePanel.Controls.Add(RemoveButton);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // UsernameRB
            // 
            UsernameRB.AutoSize = true;
            UsernameRB.Checked = true;
            UsernameRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameRB.ForeColor = Color.White;
            UsernameRB.Location = new Point(50, 106);
            UsernameRB.Name = "UsernameRB";
            UsernameRB.Size = new Size(124, 24);
            UsernameRB.TabIndex = 99;
            UsernameRB.TabStop = true;
            UsernameRB.Text = "Kullanıcı Adı";
            UsernameRB.UseVisualStyleBackColor = true;
            // 
            // UPhoneRB
            // 
            UPhoneRB.AutoSize = true;
            UPhoneRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UPhoneRB.ForeColor = Color.White;
            UPhoneRB.Location = new Point(194, 106);
            UPhoneRB.Name = "UPhoneRB";
            UPhoneRB.Size = new Size(87, 24);
            UPhoneRB.TabIndex = 98;
            UPhoneRB.Text = "Telefon";
            UPhoneRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 79);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 97;
            label3.Text = "Arama tipini seçiniz:";
            // 
            // SearchBtn
            // 
            SearchBtn.AutoSize = true;
            SearchBtn.BackColor = Color.FromArgb(88, 24, 69);
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(477, 106);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(55, 30);
            SearchBtn.TabIndex = 92;
            SearchBtn.Text = "Ara";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.FromArgb(255, 128, 0);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(660, 106);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(54, 30);
            AddButton.TabIndex = 96;
            AddButton.Text = "Ekle";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
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
            EditButton.Location = new Point(720, 106);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(85, 30);
            EditButton.TabIndex = 93;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTxt.Location = new Point(282, 106);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(189, 26);
            SearchTxt.TabIndex = 95;
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
            RemoveButton.Location = new Point(811, 106);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(39, 30);
            RemoveButton.TabIndex = 94;
            RemoveButton.Text = "Sil";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(380, 20);
            label2.Name = "label2";
            label2.Size = new Size(143, 29);
            label2.TabIndex = 58;
            label2.Text = "Kullanıcılar";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(UserStatus);
            Controls.Add(UserPanel);
            Name = "User";
            Size = new Size(900, 470);
            UserStatus.ResumeLayout(false);
            UserStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            UserPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView UserDGV;
        private Panel UserPanel;
        private Panel TitlePanel;
        private Label label2;
        private RadioButton UsernameRB;
        private RadioButton UPhoneRB;
        private Label label3;
        private Button SearchBtn;
        private Button AddButton;
        private Button EditButton;
        private TextBox SearchTxt;
        private Button RemoveButton;
        public ToolStripStatusLabel toolStripStatusLabel1;
        public StatusStrip UserStatus;
    }
}
