namespace Taksi.UserControls
{
    partial class AddRide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRide));
            AddRidePanel = new Panel();
            TitlePanel = new Panel();
            label9 = new Label();
            TurnBackButton = new Button();
            LicencePlateCB = new ComboBox();
            CancelButton = new Button();
            AddButton = new Button();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PaymentTypeCB = new ComboBox();
            DistanceTxt = new TextBox();
            EndPointTxt = new TextBox();
            PhoneTxt = new TextBox();
            descriptionTxt = new TextBox();
            BeginPointTxt = new TextBox();
            PriceTxt = new TextBox();
            AddRidePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddRidePanel
            // 
            AddRidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddRidePanel.BackColor = Color.Transparent;
            AddRidePanel.Controls.Add(TitlePanel);
            AddRidePanel.Controls.Add(LicencePlateCB);
            AddRidePanel.Controls.Add(CancelButton);
            AddRidePanel.Controls.Add(AddButton);
            AddRidePanel.Controls.Add(label8);
            AddRidePanel.Controls.Add(label6);
            AddRidePanel.Controls.Add(label7);
            AddRidePanel.Controls.Add(label5);
            AddRidePanel.Controls.Add(label4);
            AddRidePanel.Controls.Add(label3);
            AddRidePanel.Controls.Add(label2);
            AddRidePanel.Controls.Add(label1);
            AddRidePanel.Controls.Add(PaymentTypeCB);
            AddRidePanel.Controls.Add(DistanceTxt);
            AddRidePanel.Controls.Add(EndPointTxt);
            AddRidePanel.Controls.Add(PhoneTxt);
            AddRidePanel.Controls.Add(descriptionTxt);
            AddRidePanel.Controls.Add(BeginPointTxt);
            AddRidePanel.Controls.Add(PriceTxt);
            AddRidePanel.Location = new Point(0, 0);
            AddRidePanel.Name = "AddRidePanel";
            AddRidePanel.Size = new Size(900, 470);
            AddRidePanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label9);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 80;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(340, 20);
            label9.Name = "label9";
            label9.Size = new Size(235, 29);
            label9.TabIndex = 4;
            label9.Text = "Yeni Sürüş Ekleme";
            // 
            // TurnBackButton
            // 
            TurnBackButton.BackColor = Color.Transparent;
            TurnBackButton.BackgroundImage = (Image)resources.GetObject("TurnBackButton.BackgroundImage");
            TurnBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackButton.FlatAppearance.BorderSize = 0;
            TurnBackButton.FlatStyle = FlatStyle.Flat;
            TurnBackButton.Location = new Point(50, 20);
            TurnBackButton.Name = "TurnBackButton";
            TurnBackButton.RightToLeft = RightToLeft.Yes;
            TurnBackButton.Size = new Size(30, 30);
            TurnBackButton.TabIndex = 31;
            TurnBackButton.UseVisualStyleBackColor = false;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // LicencePlateCB
            // 
            LicencePlateCB.Anchor = AnchorStyles.None;
            LicencePlateCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LicencePlateCB.FormattingEnabled = true;
            LicencePlateCB.Location = new Point(400, 110);
            LicencePlateCB.Name = "LicencePlateCB";
            LicencePlateCB.Size = new Size(130, 28);
            LicencePlateCB.TabIndex = 49;
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
            CancelButton.Location = new Point(500, 350);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 30);
            CancelButton.TabIndex = 48;
            CancelButton.Text = "Vazgeç";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.None;
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.FromArgb(0, 98, 3);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(240, 350);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(180, 30);
            AddButton.TabIndex = 47;
            AddButton.Text = "Kaydet";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click_1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(400, 210);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 45;
            label8.Text = "Tutar";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(240, 270);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 44;
            label6.Text = "Açıklama";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(240, 210);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 39;
            label7.Text = "Ödeme Tipi";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(550, 150);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 40;
            label5.Text = "Mesafe";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(400, 150);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 46;
            label4.Text = "Bitiş Noktası";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(240, 147);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 41;
            label3.Text = "Başlangıç Noktası";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 90);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 43;
            label2.Text = "Plaka";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 90);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 42;
            label1.Text = "Telefon";
            // 
            // PaymentTypeCB
            // 
            PaymentTypeCB.Anchor = AnchorStyles.None;
            PaymentTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentTypeCB.FormattingEnabled = true;
            PaymentTypeCB.Location = new Point(240, 230);
            PaymentTypeCB.Name = "PaymentTypeCB";
            PaymentTypeCB.Size = new Size(130, 28);
            PaymentTypeCB.TabIndex = 38;
            // 
            // DistanceTxt
            // 
            DistanceTxt.Anchor = AnchorStyles.None;
            DistanceTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DistanceTxt.Location = new Point(550, 170);
            DistanceTxt.Name = "DistanceTxt";
            DistanceTxt.Size = new Size(130, 26);
            DistanceTxt.TabIndex = 37;
            // 
            // EndPointTxt
            // 
            EndPointTxt.Anchor = AnchorStyles.None;
            EndPointTxt.Enabled = false;
            EndPointTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EndPointTxt.Location = new Point(400, 170);
            EndPointTxt.Name = "EndPointTxt";
            EndPointTxt.Size = new Size(130, 26);
            EndPointTxt.TabIndex = 36;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.None;
            PhoneTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(240, 110);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(130, 26);
            PhoneTxt.TabIndex = 35;
            // 
            // descriptionTxt
            // 
            descriptionTxt.Anchor = AnchorStyles.None;
            descriptionTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTxt.Location = new Point(240, 290);
            descriptionTxt.Multiline = true;
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(440, 54);
            descriptionTxt.TabIndex = 34;
            // 
            // BeginPointTxt
            // 
            BeginPointTxt.Anchor = AnchorStyles.None;
            BeginPointTxt.Enabled = false;
            BeginPointTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BeginPointTxt.Location = new Point(240, 170);
            BeginPointTxt.Name = "BeginPointTxt";
            BeginPointTxt.Size = new Size(130, 26);
            BeginPointTxt.TabIndex = 33;
            // 
            // PriceTxt
            // 
            PriceTxt.Anchor = AnchorStyles.None;
            PriceTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PriceTxt.Location = new Point(400, 230);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(130, 26);
            PriceTxt.TabIndex = 32;
            // 
            // AddRide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(AddRidePanel);
            Name = "AddRide";
            Size = new Size(900, 470);
            AddRidePanel.ResumeLayout(false);
            AddRidePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel AddRidePanel;
        private Button TurnBackButton;
        public ComboBox LicencePlateCB;
        private Button CancelButton;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public ComboBox PaymentTypeCB;
        public TextBox DistanceTxt;
        public TextBox EndPointTxt;
        public TextBox PhoneTxt;
        public TextBox descriptionTxt;
        public TextBox BeginPointTxt;
        public TextBox PriceTxt;
        private Panel TitlePanel;
        public Button AddButton;
        public Label label9;
    }
}
