namespace Taksi.UserControls
{
    partial class AddVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicle));
            AddVehiclePanel = new Panel();
            TitlePanel = new Panel();
            label4 = new Label();
            TurnBackButton = new Button();
            label6 = new Label();
            LocationTxt = new TextBox();
            ModelTxt = new TextBox();
            YearTxt = new TextBox();
            label11 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            SelectStationCB = new ComboBox();
            BrandTxt = new TextBox();
            LicencePlateTxt = new TextBox();
            AddVehiclePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddVehiclePanel
            // 
            AddVehiclePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddVehiclePanel.BackColor = Color.Transparent;
            AddVehiclePanel.Controls.Add(TitlePanel);
            AddVehiclePanel.Controls.Add(label6);
            AddVehiclePanel.Controls.Add(LocationTxt);
            AddVehiclePanel.Controls.Add(ModelTxt);
            AddVehiclePanel.Controls.Add(YearTxt);
            AddVehiclePanel.Controls.Add(label11);
            AddVehiclePanel.Controls.Add(label2);
            AddVehiclePanel.Controls.Add(label5);
            AddVehiclePanel.Controls.Add(label3);
            AddVehiclePanel.Controls.Add(label1);
            AddVehiclePanel.Controls.Add(CancelButton);
            AddVehiclePanel.Controls.Add(SaveButton);
            AddVehiclePanel.Controls.Add(SelectStationCB);
            AddVehiclePanel.Controls.Add(BrandTxt);
            AddVehiclePanel.Controls.Add(LicencePlateTxt);
            AddVehiclePanel.Location = new Point(0, 0);
            AddVehiclePanel.Name = "AddVehiclePanel";
            AddVehiclePanel.Size = new Size(900, 470);
            AddVehiclePanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label4);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 113;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(341, 20);
            label4.Name = "label4";
            label4.Size = new Size(220, 29);
            label4.TabIndex = 4;
            label4.Text = "Yeni Araç Ekleme";
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
            TurnBackButton.TabIndex = 112;
            TurnBackButton.UseVisualStyleBackColor = true;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(400, 165);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 111;
            label6.Text = "Konum";
            // 
            // LocationTxt
            // 
            LocationTxt.Anchor = AnchorStyles.None;
            LocationTxt.Enabled = false;
            LocationTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LocationTxt.Location = new Point(400, 185);
            LocationTxt.Name = "LocationTxt";
            LocationTxt.ReadOnly = true;
            LocationTxt.Size = new Size(130, 26);
            LocationTxt.TabIndex = 110;
            // 
            // ModelTxt
            // 
            ModelTxt.Anchor = AnchorStyles.None;
            ModelTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ModelTxt.Location = new Point(400, 245);
            ModelTxt.Multiline = true;
            ModelTxt.Name = "ModelTxt";
            ModelTxt.Size = new Size(130, 27);
            ModelTxt.TabIndex = 108;
            // 
            // YearTxt
            // 
            YearTxt.Anchor = AnchorStyles.None;
            YearTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            YearTxt.Location = new Point(550, 245);
            YearTxt.Multiline = true;
            YearTxt.Name = "YearTxt";
            YearTxt.Size = new Size(130, 27);
            YearTxt.TabIndex = 109;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(550, 165);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 107;
            label11.Text = "Çalıştığı Durak";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 225);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 105;
            label2.Text = "Model";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(550, 225);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 106;
            label5.Text = "Yıl";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(240, 165);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 104;
            label3.Text = "Plaka";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 225);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 103;
            label1.Text = "Marka";
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
            CancelButton.Location = new Point(500, 279);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 30);
            CancelButton.TabIndex = 102;
            CancelButton.Text = "Vazgeç";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            SaveButton.Location = new Point(240, 279);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(180, 30);
            SaveButton.TabIndex = 101;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // SelectStationCB
            // 
            SelectStationCB.Anchor = AnchorStyles.None;
            SelectStationCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectStationCB.FormattingEnabled = true;
            SelectStationCB.Location = new Point(550, 185);
            SelectStationCB.Name = "SelectStationCB";
            SelectStationCB.Size = new Size(130, 28);
            SelectStationCB.TabIndex = 100;
            // 
            // BrandTxt
            // 
            BrandTxt.Anchor = AnchorStyles.None;
            BrandTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BrandTxt.Location = new Point(240, 245);
            BrandTxt.Name = "BrandTxt";
            BrandTxt.Size = new Size(130, 26);
            BrandTxt.TabIndex = 99;
            // 
            // LicencePlateTxt
            // 
            LicencePlateTxt.Anchor = AnchorStyles.None;
            LicencePlateTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LicencePlateTxt.Location = new Point(240, 185);
            LicencePlateTxt.Name = "LicencePlateTxt";
            LicencePlateTxt.Size = new Size(130, 26);
            LicencePlateTxt.TabIndex = 98;
            // 
            // AddVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(AddVehiclePanel);
            Name = "AddVehicle";
            Size = new Size(900, 470);
            AddVehiclePanel.ResumeLayout(false);
            AddVehiclePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel AddVehiclePanel;
        private Label label6;
        public TextBox LocationTxt;
        public TextBox ModelTxt;
        public TextBox YearTxt;
        private Label label11;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button CancelButton;
        private Button SaveButton;
        public ComboBox SelectStationCB;
        public TextBox BrandTxt;
        public TextBox LicencePlateTxt;
        private Button TurnBackButton;
        private Panel TitlePanel;
        public Label label4;
    }
}
