namespace Taksi.UserControls
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            AddCustomerPanel = new Panel();
            GoToHomeButton = new Button();
            RideButton = new Button();
            TitlePanel = new Panel();
            label1 = new Label();
            TurnBackButton = new Button();
            CancelButton = new Button();
            SaveButton = new Button();
            label12 = new Label();
            label11 = new Label();
            label3 = new Label();
            label9 = new Label();
            label5 = new Label();
            label2 = new Label();
            DistrictCB = new ComboBox();
            CityCB = new ComboBox();
            AddressTxt = new TextBox();
            PhoneTxt = new TextBox();
            LastNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            AddCustomerPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddCustomerPanel
            // 
            AddCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddCustomerPanel.BackColor = Color.Transparent;
            AddCustomerPanel.Controls.Add(GoToHomeButton);
            AddCustomerPanel.Controls.Add(RideButton);
            AddCustomerPanel.Controls.Add(TitlePanel);
            AddCustomerPanel.Controls.Add(CancelButton);
            AddCustomerPanel.Controls.Add(SaveButton);
            AddCustomerPanel.Controls.Add(label12);
            AddCustomerPanel.Controls.Add(label11);
            AddCustomerPanel.Controls.Add(label3);
            AddCustomerPanel.Controls.Add(label9);
            AddCustomerPanel.Controls.Add(label5);
            AddCustomerPanel.Controls.Add(label2);
            AddCustomerPanel.Controls.Add(DistrictCB);
            AddCustomerPanel.Controls.Add(CityCB);
            AddCustomerPanel.Controls.Add(AddressTxt);
            AddCustomerPanel.Controls.Add(PhoneTxt);
            AddCustomerPanel.Controls.Add(LastNameTxt);
            AddCustomerPanel.Controls.Add(FirstNameTxt);
            AddCustomerPanel.Location = new Point(0, 0);
            AddCustomerPanel.Name = "AddCustomerPanel";
            AddCustomerPanel.Size = new Size(900, 470);
            AddCustomerPanel.TabIndex = 0;
            // 
            // GoToHomeButton
            // 
            GoToHomeButton.Anchor = AnchorStyles.None;
            GoToHomeButton.AutoSize = true;
            GoToHomeButton.BackColor = Color.FromArgb(111, 0, 0);
            GoToHomeButton.FlatAppearance.BorderSize = 0;
            GoToHomeButton.FlatStyle = FlatStyle.Flat;
            GoToHomeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GoToHomeButton.ForeColor = Color.White;
            GoToHomeButton.Location = new Point(501, 315);
            GoToHomeButton.Name = "GoToHomeButton";
            GoToHomeButton.Size = new Size(179, 30);
            GoToHomeButton.TabIndex = 74;
            GoToHomeButton.Text = "Vazgeç";
            GoToHomeButton.UseVisualStyleBackColor = false;
            GoToHomeButton.Click += GoToHomeButton_Click;
            // 
            // RideButton
            // 
            RideButton.Anchor = AnchorStyles.None;
            RideButton.AutoSize = true;
            RideButton.BackColor = Color.FromArgb(2, 48, 71);
            RideButton.FlatAppearance.BorderSize = 0;
            RideButton.FlatStyle = FlatStyle.Flat;
            RideButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RideButton.ForeColor = Color.White;
            RideButton.Location = new Point(250, 315);
            RideButton.Name = "RideButton";
            RideButton.Size = new Size(185, 30);
            RideButton.TabIndex = 73;
            RideButton.Text = "Çağrıyı Yönlendir";
            RideButton.UseVisualStyleBackColor = false;
            RideButton.Click += RideButton_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 72;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(374, 22);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 3;
            label1.Text = "Yeni Müşteri";
            // 
            // TurnBackButton
            // 
            TurnBackButton.BackgroundImage = (Image)resources.GetObject("TurnBackButton.BackgroundImage");
            TurnBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackButton.FlatAppearance.BorderSize = 0;
            TurnBackButton.FlatStyle = FlatStyle.Flat;
            TurnBackButton.Location = new Point(50, 20);
            TurnBackButton.Name = "TurnBackButton";
            TurnBackButton.RightToLeft = RightToLeft.Yes;
            TurnBackButton.Size = new Size(30, 30);
            TurnBackButton.TabIndex = 57;
            TurnBackButton.UseVisualStyleBackColor = true;
            TurnBackButton.Click += TurnBackButton_Click;
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
            CancelButton.Location = new Point(501, 315);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(179, 30);
            CancelButton.TabIndex = 71;
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
            SaveButton.Location = new Point(250, 315);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(182, 30);
            SaveButton.TabIndex = 70;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(250, 235);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 69;
            label12.Text = "Adres";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(400, 175);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 68;
            label11.Text = "İlçe";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(400, 115);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 67;
            label3.Text = "Soyisim";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(250, 175);
            label9.Name = "label9";
            label9.Size = new Size(19, 20);
            label9.TabIndex = 65;
            label9.Text = "İl";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(550, 115);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 64;
            label5.Text = "Telefon";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(250, 115);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 66;
            label2.Text = "İsim";
            // 
            // DistrictCB
            // 
            DistrictCB.Anchor = AnchorStyles.None;
            DistrictCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DistrictCB.FormattingEnabled = true;
            DistrictCB.Location = new Point(400, 195);
            DistrictCB.Name = "DistrictCB";
            DistrictCB.Size = new Size(130, 28);
            DistrictCB.TabIndex = 63;
            // 
            // CityCB
            // 
            CityCB.Anchor = AnchorStyles.None;
            CityCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CityCB.FormattingEnabled = true;
            CityCB.Location = new Point(250, 195);
            CityCB.Name = "CityCB";
            CityCB.Size = new Size(130, 28);
            CityCB.TabIndex = 62;
            CityCB.SelectedIndexChanged += CityCB_SelectedIndexChanged_1;
            // 
            // AddressTxt
            // 
            AddressTxt.Anchor = AnchorStyles.None;
            AddressTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddressTxt.Location = new Point(250, 255);
            AddressTxt.Multiline = true;
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(430, 54);
            AddressTxt.TabIndex = 61;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.None;
            PhoneTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(550, 135);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(130, 26);
            PhoneTxt.TabIndex = 60;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Anchor = AnchorStyles.None;
            LastNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(400, 135);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(130, 26);
            LastNameTxt.TabIndex = 59;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Anchor = AnchorStyles.None;
            FirstNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(250, 135);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(130, 26);
            FirstNameTxt.TabIndex = 58;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(AddCustomerPanel);
            MinimumSize = new Size(900, 300);
            Name = "AddCustomer";
            Size = new Size(900, 470);
            AddCustomerPanel.ResumeLayout(false);
            AddCustomerPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddCustomerPanel;
        private Label label12;
        private Label label11;
        private Label label3;
        private Label label9;
        private Label label5;
        private Label label2;
        public ComboBox DistrictCB;
        public ComboBox CityCB;
        public TextBox AddressTxt;
        public TextBox PhoneTxt;
        public TextBox LastNameTxt;
        public TextBox FirstNameTxt;
        private Panel TitlePanel;
        private Button TurnBackButton;
        public Button RideButton;
        public Button SaveButton;
        public Label label1;
        public Button GoToHomeButton;
        public Button CancelButton;
    }
}
