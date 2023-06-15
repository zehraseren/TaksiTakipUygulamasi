namespace Taksi.UserControls
{
    partial class Ride
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ride));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            RidePanel = new Panel();
            TitlePanel = new Panel();
            CPhoneRB = new RadioButton();
            DriverNameRB = new RadioButton();
            LicensePlateRB = new RadioButton();
            removeBtn = new Button();
            ListBtn = new Button();
            FilterButton = new Button();
            EndDTP = new DateTimePicker();
            BeginDTP = new DateTimePicker();
            SearchTxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            EditButton = new Button();
            AddButton = new Button();
            label2 = new Label();
            TurnBackButton = new Button();
            RideDGV = new DataGridView();
            RideStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            RidePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RideDGV).BeginInit();
            RideStatus.SuspendLayout();
            SuspendLayout();
            // 
            // RidePanel
            // 
            RidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RidePanel.BackColor = Color.Transparent;
            RidePanel.Controls.Add(TitlePanel);
            RidePanel.Controls.Add(RideDGV);
            RidePanel.Controls.Add(RideStatus);
            RidePanel.Location = new Point(0, 0);
            RidePanel.Name = "RidePanel";
            RidePanel.Size = new Size(900, 470);
            RidePanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(CPhoneRB);
            TitlePanel.Controls.Add(DriverNameRB);
            TitlePanel.Controls.Add(LicensePlateRB);
            TitlePanel.Controls.Add(removeBtn);
            TitlePanel.Controls.Add(ListBtn);
            TitlePanel.Controls.Add(FilterButton);
            TitlePanel.Controls.Add(EndDTP);
            TitlePanel.Controls.Add(BeginDTP);
            TitlePanel.Controls.Add(SearchTxt);
            TitlePanel.Controls.Add(label3);
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(AddButton);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // CPhoneRB
            // 
            CPhoneRB.AutoSize = true;
            CPhoneRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CPhoneRB.ForeColor = Color.White;
            CPhoneRB.Location = new Point(290, 109);
            CPhoneRB.Name = "CPhoneRB";
            CPhoneRB.Size = new Size(87, 24);
            CPhoneRB.TabIndex = 85;
            CPhoneRB.Text = "Telefon";
            CPhoneRB.UseVisualStyleBackColor = true;
            // 
            // DriverNameRB
            // 
            DriverNameRB.AutoSize = true;
            DriverNameRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DriverNameRB.ForeColor = Color.White;
            DriverNameRB.Location = new Point(170, 109);
            DriverNameRB.Name = "DriverNameRB";
            DriverNameRB.Size = new Size(115, 24);
            DriverNameRB.TabIndex = 86;
            DriverNameRB.Text = "Sürücü Adı";
            DriverNameRB.UseVisualStyleBackColor = true;
            // 
            // LicensePlateRB
            // 
            LicensePlateRB.AutoSize = true;
            LicensePlateRB.Checked = true;
            LicensePlateRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LicensePlateRB.ForeColor = Color.White;
            LicensePlateRB.Location = new Point(50, 109);
            LicensePlateRB.Name = "LicensePlateRB";
            LicensePlateRB.Size = new Size(113, 24);
            LicensePlateRB.TabIndex = 87;
            LicensePlateRB.TabStop = true;
            LicensePlateRB.Text = "Araç Plaka";
            LicensePlateRB.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            removeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeBtn.AutoSize = true;
            removeBtn.BackColor = Color.FromArgb(111, 0, 0);
            removeBtn.FlatAppearance.BorderSize = 0;
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeBtn.ForeColor = Color.White;
            removeBtn.Location = new Point(808, 107);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(41, 30);
            removeBtn.TabIndex = 84;
            removeBtn.Text = "Sil";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // ListBtn
            // 
            ListBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListBtn.AutoSize = true;
            ListBtn.BackColor = Color.FromArgb(88, 24, 69);
            ListBtn.FlatAppearance.BorderSize = 0;
            ListBtn.FlatStyle = FlatStyle.Flat;
            ListBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ListBtn.ForeColor = Color.White;
            ListBtn.Location = new Point(695, 74);
            ListBtn.Name = "ListBtn";
            ListBtn.Size = new Size(154, 30);
            ListBtn.TabIndex = 83;
            ListBtn.Text = "Tümünü Listele";
            ListBtn.UseVisualStyleBackColor = false;
            // 
            // FilterButton
            // 
            FilterButton.AutoSize = true;
            FilterButton.BackColor = Color.FromArgb(88, 24, 69);
            FilterButton.FlatAppearance.BorderSize = 0;
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FilterButton.ForeColor = Color.White;
            FilterButton.Location = new Point(526, 106);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(74, 30);
            FilterButton.TabIndex = 82;
            FilterButton.Text = "Filtrele";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // EndDTP
            // 
            EndDTP.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EndDTP.Format = DateTimePickerFormat.Custom;
            EndDTP.Location = new Point(306, 84);
            EndDTP.Name = "EndDTP";
            EndDTP.Size = new Size(130, 24);
            EndDTP.TabIndex = 81;
            // 
            // BeginDTP
            // 
            BeginDTP.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BeginDTP.Format = DateTimePickerFormat.Custom;
            BeginDTP.Location = new Point(170, 84);
            BeginDTP.Name = "BeginDTP";
            BeginDTP.Size = new Size(130, 24);
            BeginDTP.TabIndex = 80;
            // 
            // SearchTxt
            // 
            SearchTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTxt.Location = new Point(383, 109);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(137, 26);
            SearchTxt.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 84);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 77;
            label3.Text = "Tarih Aralığı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 53);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 78;
            label1.Text = "Arama tipini seçiniz:";
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
            EditButton.Location = new Point(717, 107);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(85, 30);
            EditButton.TabIndex = 76;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
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
            AddButton.Location = new Point(656, 107);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(57, 30);
            AddButton.TabIndex = 75;
            AddButton.Text = "Ekle";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 20);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 58;
            label2.Text = "Sürüşler";
            // 
            // TurnBackButton
            // 
            TurnBackButton.BackgroundImage = (Image)resources.GetObject("TurnBackButton.BackgroundImage");
            TurnBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackButton.FlatAppearance.BorderSize = 0;
            TurnBackButton.FlatStyle = FlatStyle.Flat;
            TurnBackButton.Location = new Point(20, 20);
            TurnBackButton.Name = "TurnBackButton";
            TurnBackButton.RightToLeft = RightToLeft.Yes;
            TurnBackButton.Size = new Size(30, 30);
            TurnBackButton.TabIndex = 57;
            TurnBackButton.UseVisualStyleBackColor = true;
            // 
            // RideDGV
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RideDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            RideDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RideDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RideDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            RideDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            RideDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            RideDGV.DefaultCellStyle = dataGridViewCellStyle8;
            RideDGV.Location = new Point(50, 140);
            RideDGV.Name = "RideDGV";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            RideDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RideDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            RideDGV.RowTemplate.Height = 25;
            RideDGV.Size = new Size(800, 300);
            RideDGV.TabIndex = 4;
            // 
            // RideStatus
            // 
            RideStatus.BackColor = Color.Transparent;
            RideStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RideStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            RideStatus.Location = new Point(0, 445);
            RideStatus.Name = "RideStatus";
            RideStatus.Size = new Size(900, 25);
            RideStatus.TabIndex = 0;
            RideStatus.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // Ride
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(RidePanel);
            Name = "Ride";
            Size = new Size(900, 470);
            RidePanel.ResumeLayout(false);
            RidePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RideDGV).EndInit();
            RideStatus.ResumeLayout(false);
            RideStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RidePanel;
        private StatusStrip RideStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridView RideDGV;
        private Panel TitlePanel;
        private Label label2;
        private Button TurnBackButton;
        private RadioButton CPhoneRB;
        private RadioButton DriverNameRB;
        private RadioButton LicensePlateRB;
        private Button removeBtn;
        private Button ListBtn;
        private Button FilterButton;
        private DateTimePicker EndDTP;
        private DateTimePicker BeginDTP;
        private TextBox SearchTxt;
        private Label label3;
        private Label label1;
        private Button EditButton;
        private Button AddButton;
    }
}
