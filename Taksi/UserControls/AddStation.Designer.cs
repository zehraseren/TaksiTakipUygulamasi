namespace Taksi.UserControls
{
    partial class AddStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStation));
            AddStationPanel = new Panel();
            TitlePanel = new Panel();
            label1 = new Label();
            TurnBackButton = new Button();
            label2 = new Label();
            StationNameTxt = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label11 = new Label();
            PhoneTxt = new TextBox();
            label12 = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            CityCB = new ComboBox();
            AddressTxt = new TextBox();
            DistrictCB = new ComboBox();
            AddStationPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddStationPanel
            // 
            AddStationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddStationPanel.BackColor = Color.Transparent;
            AddStationPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AddStationPanel.Controls.Add(TitlePanel);
            AddStationPanel.Controls.Add(label2);
            AddStationPanel.Controls.Add(StationNameTxt);
            AddStationPanel.Controls.Add(label9);
            AddStationPanel.Controls.Add(label5);
            AddStationPanel.Controls.Add(label11);
            AddStationPanel.Controls.Add(PhoneTxt);
            AddStationPanel.Controls.Add(label12);
            AddStationPanel.Controls.Add(SaveButton);
            AddStationPanel.Controls.Add(CancelButton);
            AddStationPanel.Controls.Add(CityCB);
            AddStationPanel.Controls.Add(AddressTxt);
            AddStationPanel.Controls.Add(DistrictCB);
            AddStationPanel.Location = new Point(0, 0);
            AddStationPanel.Name = "AddStationPanel";
            AddStationPanel.Size = new Size(900, 470);
            AddStationPanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 108;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 20);
            label1.Name = "label1";
            label1.Size = new Size(236, 29);
            label1.TabIndex = 4;
            label1.Text = "Yeni Durak Ekleme";
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
            TurnBackButton.TabIndex = 107;
            TurnBackButton.UseVisualStyleBackColor = true;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(315, 120);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 102;
            label2.Text = "Durak Adı";
            // 
            // StationNameTxt
            // 
            StationNameTxt.Anchor = AnchorStyles.None;
            StationNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StationNameTxt.Location = new Point(315, 140);
            StationNameTxt.Name = "StationNameTxt";
            StationNameTxt.Size = new Size(130, 26);
            StationNameTxt.TabIndex = 95;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(315, 180);
            label9.Name = "label9";
            label9.Size = new Size(19, 20);
            label9.TabIndex = 101;
            label9.Text = "İl";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(475, 120);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 100;
            label5.Text = "Telefon";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(475, 180);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 103;
            label11.Text = "İlçe";
            // 
            // PhoneTxt
            // 
            PhoneTxt.Anchor = AnchorStyles.None;
            PhoneTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTxt.Location = new Point(475, 140);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(130, 26);
            PhoneTxt.TabIndex = 96;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(315, 240);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 104;
            label12.Text = "Adres";
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
            SaveButton.Location = new Point(315, 320);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(130, 30);
            SaveButton.TabIndex = 105;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
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
            CancelButton.Location = new Point(475, 320);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 30);
            CancelButton.TabIndex = 106;
            CancelButton.Text = "Vazgeç";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CityCB
            // 
            CityCB.Anchor = AnchorStyles.None;
            CityCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CityCB.FormattingEnabled = true;
            CityCB.Location = new Point(315, 200);
            CityCB.Name = "CityCB";
            CityCB.Size = new Size(130, 28);
            CityCB.TabIndex = 98;
            CityCB.SelectedIndexChanged += CityCB_SelectedIndexChanged;
            // 
            // AddressTxt
            // 
            AddressTxt.Anchor = AnchorStyles.None;
            AddressTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddressTxt.Location = new Point(315, 260);
            AddressTxt.Multiline = true;
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(290, 54);
            AddressTxt.TabIndex = 97;
            // 
            // DistrictCB
            // 
            DistrictCB.Anchor = AnchorStyles.None;
            DistrictCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DistrictCB.FormattingEnabled = true;
            DistrictCB.Location = new Point(475, 200);
            DistrictCB.Name = "DistrictCB";
            DistrictCB.Size = new Size(130, 28);
            DistrictCB.TabIndex = 99;
            // 
            // AddStation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(AddStationPanel);
            Name = "AddStation";
            Size = new Size(900, 470);
            AddStationPanel.ResumeLayout(false);
            AddStationPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddStationPanel;
        private Label label2;
        public TextBox StationNameTxt;
        private Label label9;
        private Label label5;
        private Label label11;
        public TextBox PhoneTxt;
        private Label label12;
        private Button SaveButton;
        private Button CancelButton;
        public ComboBox CityCB;
        public TextBox AddressTxt;
        public ComboBox DistrictCB;
        private Button TurnBackButton;
        private Panel TitlePanel;
        public Label label1;
    }
}
