namespace Taksi.UserControls
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            AddDriverPanel = new Panel();
            CancelButton = new Button();
            SaveButton = new Button();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            DistrictCB = new ComboBox();
            CityCB = new ComboBox();
            VehicleCB = new ComboBox();
            StationCB = new ComboBox();
            ShiftCB = new ComboBox();
            AddressTxt = new TextBox();
            PhoneTxt = new TextBox();
            LastNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            IDNoTxt = new TextBox();
            TitlePanel = new Panel();
            label4 = new Label();
            TurnBackButton = new Button();
            AddDriverPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddDriverPanel
            // 
            AddDriverPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddDriverPanel.BackColor = Color.Transparent;
            AddDriverPanel.Controls.Add(CancelButton);
            AddDriverPanel.Controls.Add(SaveButton);
            AddDriverPanel.Controls.Add(label11);
            AddDriverPanel.Controls.Add(label10);
            AddDriverPanel.Controls.Add(label3);
            AddDriverPanel.Controls.Add(label9);
            AddDriverPanel.Controls.Add(label7);
            AddDriverPanel.Controls.Add(label5);
            AddDriverPanel.Controls.Add(label6);
            AddDriverPanel.Controls.Add(label2);
            AddDriverPanel.Controls.Add(label1);
            AddDriverPanel.Controls.Add(DistrictCB);
            AddDriverPanel.Controls.Add(CityCB);
            AddDriverPanel.Controls.Add(VehicleCB);
            AddDriverPanel.Controls.Add(StationCB);
            AddDriverPanel.Controls.Add(ShiftCB);
            AddDriverPanel.Controls.Add(AddressTxt);
            AddDriverPanel.Controls.Add(PhoneTxt);
            AddDriverPanel.Controls.Add(LastNameTxt);
            AddDriverPanel.Controls.Add(FirstNameTxt);
            AddDriverPanel.Controls.Add(IDNoTxt);
            AddDriverPanel.Controls.Add(TitlePanel);
            AddDriverPanel.Location = new Point(0, 0);
            AddDriverPanel.Name = "AddDriverPanel";
            AddDriverPanel.Size = new Size(900, 470);
            AddDriverPanel.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.None;
            CancelButton.AutoSize = true;
            CancelButton.BackColor = Color.FromArgb(111, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(500, 380);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 30);
            CancelButton.TabIndex = 130;
            CancelButton.Text = "Vazgeç";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.None;
            SaveButton.AutoSize = true;
            SaveButton.BackColor = Color.FromArgb(0, 98, 3);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(250, 380);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(180, 30);
            SaveButton.TabIndex = 129;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(400, 240);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 128;
            label11.Text = "İlçe";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(400, 180);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 127;
            label10.Text = "Kullandığı Araç";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(550, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 126;
            label3.Text = "Soyisim";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(250, 240);
            label9.Name = "label9";
            label9.Size = new Size(19, 20);
            label9.TabIndex = 124;
            label9.Text = "İl";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(252, 180);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 123;
            label7.Text = "Çalıştığı Durak";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(250, 120);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 125;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(400, 120);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 120;
            label6.Text = "Vardiya Tipi";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 122;
            label2.Text = "İsim";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 60);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 121;
            label1.Text = "T.C. Kimlik No";
            // 
            // DistrictCB
            // 
            DistrictCB.Anchor = AnchorStyles.None;
            DistrictCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DistrictCB.FormattingEnabled = true;
            DistrictCB.Location = new Point(400, 260);
            DistrictCB.Name = "DistrictCB";
            DistrictCB.Size = new Size(130, 28);
            DistrictCB.TabIndex = 119;
            // 
            // CityCB
            // 
            CityCB.Anchor = AnchorStyles.None;
            CityCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CityCB.FormattingEnabled = true;
            CityCB.Location = new Point(250, 260);
            CityCB.Name = "CityCB";
            CityCB.Size = new Size(130, 28);
            CityCB.TabIndex = 118;
            CityCB.SelectedIndexChanged += CityCB_SelectedIndexChanged;
            // 
            // VehicleCB
            // 
            VehicleCB.Anchor = AnchorStyles.None;
            VehicleCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleCB.FormattingEnabled = true;
            VehicleCB.Location = new Point(400, 200);
            VehicleCB.Name = "VehicleCB";
            VehicleCB.Size = new Size(130, 28);
            VehicleCB.TabIndex = 117;
            // 
            // StationCB
            // 
            StationCB.Anchor = AnchorStyles.None;
            StationCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StationCB.FormattingEnabled = true;
            StationCB.Location = new Point(252, 200);
            StationCB.Name = "StationCB";
            StationCB.Size = new Size(130, 28);
            StationCB.TabIndex = 116;
            // 
            // ShiftCB
            // 
            ShiftCB.Anchor = AnchorStyles.None;
            ShiftCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShiftCB.FormattingEnabled = true;
            ShiftCB.Location = new Point(400, 140);
            ShiftCB.Name = "ShiftCB";
            ShiftCB.Size = new Size(130, 28);
            ShiftCB.TabIndex = 115;
            // 
            // AddressTxt
            // 
            AddressTxt.Anchor = AnchorStyles.None;
            AddressTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddressTxt.Location = new Point(250, 320);
            AddressTxt.Multiline = true;
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(430, 54);
            AddressTxt.TabIndex = 114;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.None;
            PhoneTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(250, 140);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(130, 26);
            PhoneTxt.TabIndex = 113;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Anchor = AnchorStyles.None;
            LastNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(550, 80);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(130, 26);
            LastNameTxt.TabIndex = 112;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Anchor = AnchorStyles.None;
            FirstNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(400, 80);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(130, 26);
            FirstNameTxt.TabIndex = 111;
            // 
            // IDNoTxt
            // 
            IDNoTxt.Anchor = AnchorStyles.None;
            IDNoTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IDNoTxt.Location = new Point(250, 80);
            IDNoTxt.Name = "IDNoTxt";
            IDNoTxt.Size = new Size(130, 26);
            IDNoTxt.TabIndex = 110;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label4);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 109;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(331, 20);
            label4.Name = "label4";
            label4.Size = new Size(249, 29);
            label4.TabIndex = 5;
            label4.Text = "Yeni Sürücü Ekleme";
            // 
            // TurnBackButton
            // 
            TurnBackButton.BackgroundImage = (Image)resources.GetObject("TurnBackButton.BackgroundImage");
            TurnBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackButton.FlatAppearance.BorderSize = 0;
            TurnBackButton.FlatStyle = FlatStyle.Flat;
            TurnBackButton.Location = new Point(50, 20);
            TurnBackButton.Name = "TurnBackButton";
            TurnBackButton.Size = new Size(30, 30);
            TurnBackButton.TabIndex = 83;
            TurnBackButton.UseVisualStyleBackColor = true;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // AddDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(AddDriverPanel);
            Name = "AddDriver";
            Size = new Size(900, 470);
            AddDriverPanel.ResumeLayout(false);
            AddDriverPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddDriverPanel;
        private Button CancelButton;
        private Button SaveButton;
        private Label label11;
        private Label label10;
        private Label label3;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        public ComboBox DistrictCB;
        public ComboBox CityCB;
        public ComboBox VehicleCB;
        public ComboBox StationCB;
        public ComboBox ShiftCB;
        public TextBox AddressTxt;
        public TextBox PhoneTxt;
        public TextBox LastNameTxt;
        public TextBox FirstNameTxt;
        public TextBox IDNoTxt;
        private Panel TitlePanel;
        private Button TurnBackButton;
        public Label label4;
    }
}
