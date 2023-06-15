namespace Taksi.UserControls
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            AddUserPanel = new Panel();
            cancelBtnHome = new Button();
            TitlePanel = new Panel();
            label8 = new Label();
            TurnBackButton = new Button();
            UserRoleCB = new ComboBox();
            CancelButton = new Button();
            SaveButton = new Button();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            StatusCB = new ComboBox();
            PhoneTxt = new TextBox();
            PasswordTxt = new TextBox();
            LastNameTxt = new TextBox();
            userTxt = new TextBox();
            FirstNameTxt = new TextBox();
            AddUserPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddUserPanel
            // 
            AddUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddUserPanel.BackColor = Color.Transparent;
            AddUserPanel.Controls.Add(cancelBtnHome);
            AddUserPanel.Controls.Add(TitlePanel);
            AddUserPanel.Controls.Add(UserRoleCB);
            AddUserPanel.Controls.Add(CancelButton);
            AddUserPanel.Controls.Add(SaveButton);
            AddUserPanel.Controls.Add(label3);
            AddUserPanel.Controls.Add(label1);
            AddUserPanel.Controls.Add(label7);
            AddUserPanel.Controls.Add(label5);
            AddUserPanel.Controls.Add(label6);
            AddUserPanel.Controls.Add(label2);
            AddUserPanel.Controls.Add(label4);
            AddUserPanel.Controls.Add(StatusCB);
            AddUserPanel.Controls.Add(PhoneTxt);
            AddUserPanel.Controls.Add(PasswordTxt);
            AddUserPanel.Controls.Add(LastNameTxt);
            AddUserPanel.Controls.Add(userTxt);
            AddUserPanel.Controls.Add(FirstNameTxt);
            AddUserPanel.Location = new Point(0, 0);
            AddUserPanel.Name = "AddUserPanel";
            AddUserPanel.Size = new Size(900, 470);
            AddUserPanel.TabIndex = 2;
            // 
            // cancelBtnHome
            // 
            cancelBtnHome.Anchor = AnchorStyles.None;
            cancelBtnHome.AutoSize = true;
            cancelBtnHome.BackColor = Color.FromArgb(111, 0, 0);
            cancelBtnHome.FlatAppearance.BorderSize = 0;
            cancelBtnHome.FlatStyle = FlatStyle.Flat;
            cancelBtnHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtnHome.ForeColor = Color.White;
            cancelBtnHome.Location = new Point(500, 304);
            cancelBtnHome.Name = "cancelBtnHome";
            cancelBtnHome.Size = new Size(180, 30);
            cancelBtnHome.TabIndex = 80;
            cancelBtnHome.Text = "Vazgeç";
            cancelBtnHome.UseVisualStyleBackColor = false;
            cancelBtnHome.Visible = false;
            cancelBtnHome.Click += cancelBtnHome_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label8);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 79;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(321, 20);
            label8.Name = "label8";
            label8.Size = new Size(268, 29);
            label8.TabIndex = 4;
            label8.Text = "Yeni Kullanıcı Ekleme";
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
            TurnBackButton.TabIndex = 78;
            TurnBackButton.UseVisualStyleBackColor = true;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // UserRoleCB
            // 
            UserRoleCB.Anchor = AnchorStyles.None;
            UserRoleCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserRoleCB.FormattingEnabled = true;
            UserRoleCB.Location = new Point(550, 152);
            UserRoleCB.Name = "UserRoleCB";
            UserRoleCB.Size = new Size(130, 28);
            UserRoleCB.TabIndex = 77;
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
            CancelButton.Location = new Point(500, 304);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 30);
            CancelButton.TabIndex = 76;
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
            SaveButton.Location = new Point(236, 304);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(180, 30);
            SaveButton.TabIndex = 75;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(402, 192);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 74;
            label3.Text = "Soyisim";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(402, 252);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 71;
            label1.Text = "Durum";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(550, 132);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 72;
            label7.Text = "Rol";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(236, 252);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 73;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(402, 132);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 69;
            label6.Text = "Şifre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(236, 192);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 70;
            label2.Text = "İsim";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(236, 132);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 68;
            label4.Text = "Kullanıcı Adı";
            // 
            // StatusCB
            // 
            StatusCB.Anchor = AnchorStyles.None;
            StatusCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StatusCB.FormattingEnabled = true;
            StatusCB.Items.AddRange(new object[] { "Aktif", "Pasif" });
            StatusCB.Location = new Point(402, 272);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(130, 28);
            StatusCB.TabIndex = 67;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.None;
            PhoneTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(236, 272);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(130, 26);
            PhoneTxt.TabIndex = 66;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Anchor = AnchorStyles.None;
            PasswordTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(402, 152);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(130, 26);
            PasswordTxt.TabIndex = 63;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Anchor = AnchorStyles.None;
            LastNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(402, 212);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(130, 26);
            LastNameTxt.TabIndex = 65;
            // 
            // userTxt
            // 
            userTxt.Anchor = AnchorStyles.None;
            userTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userTxt.Location = new Point(236, 152);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(130, 26);
            userTxt.TabIndex = 62;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Anchor = AnchorStyles.None;
            FirstNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(236, 212);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(130, 26);
            FirstNameTxt.TabIndex = 64;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(AddUserPanel);
            Name = "UserPanel";
            Size = new Size(900, 470);
            AddUserPanel.ResumeLayout(false);
            AddUserPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddUserPanel;
        private Button CancelButton;
        private Button SaveButton;
        private Label label3;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label4;
        public ComboBox UserRoleCB;
        public ComboBox StatusCB;
        public TextBox PhoneTxt;
        public TextBox PasswordTxt;
        public TextBox LastNameTxt;
        public TextBox userTxt;
        public TextBox FirstNameTxt;
        private Panel TitlePanel;
        public Label label8;
        public Button TurnBackButton;
        public Button cancelBtnHome;
        public Label label1;
    }
}
