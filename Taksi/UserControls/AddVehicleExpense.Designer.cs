namespace Taksi.UserControls
{
    partial class AddVehicleExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleExpense));
            VehicleExpensePanel = new Panel();
            TitlePanel = new Panel();
            label2 = new Label();
            TurnBackButton = new Button();
            CancelButton = new Button();
            AddButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            CostTypeCB = new ComboBox();
            label1 = new Label();
            label11 = new Label();
            ExpenseTypeCB = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            CostTxt = new TextBox();
            LicensePlateTxt = new TextBox();
            VehicleExpensePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // VehicleExpensePanel
            // 
            VehicleExpensePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VehicleExpensePanel.BackColor = Color.Transparent;
            VehicleExpensePanel.BackgroundImageLayout = ImageLayout.Stretch;
            VehicleExpensePanel.Controls.Add(TitlePanel);
            VehicleExpensePanel.Controls.Add(CancelButton);
            VehicleExpensePanel.Controls.Add(AddButton);
            VehicleExpensePanel.Controls.Add(dateTimePicker1);
            VehicleExpensePanel.Controls.Add(CostTypeCB);
            VehicleExpensePanel.Controls.Add(label1);
            VehicleExpensePanel.Controls.Add(label11);
            VehicleExpensePanel.Controls.Add(ExpenseTypeCB);
            VehicleExpensePanel.Controls.Add(label6);
            VehicleExpensePanel.Controls.Add(label5);
            VehicleExpensePanel.Controls.Add(label4);
            VehicleExpensePanel.Controls.Add(CostTxt);
            VehicleExpensePanel.Controls.Add(LicensePlateTxt);
            VehicleExpensePanel.Location = new Point(0, 0);
            VehicleExpensePanel.Name = "VehicleExpensePanel";
            VehicleExpensePanel.Size = new Size(900, 470);
            VehicleExpensePanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 73;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(305, 20);
            label2.Name = "label2";
            label2.Size = new Size(292, 29);
            label2.TabIndex = 4;
            label2.Text = "Yeni Araç Gider Ekleme";
            // 
            // TurnBackButton
            // 
            TurnBackButton.BackColor = Color.Transparent;
            TurnBackButton.BackgroundImage = (Image)resources.GetObject("TurnBackButton.BackgroundImage");
            TurnBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackButton.FlatAppearance.BorderSize = 0;
            TurnBackButton.FlatStyle = FlatStyle.Flat;
            TurnBackButton.Location = new Point(20, 20);
            TurnBackButton.Name = "TurnBackButton";
            TurnBackButton.RightToLeft = RightToLeft.Yes;
            TurnBackButton.Size = new Size(30, 30);
            TurnBackButton.TabIndex = 50;
            TurnBackButton.UseVisualStyleBackColor = false;
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
            CancelButton.TabIndex = 48;
            CancelButton.Text = "Vazgeç";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            AddButton.Location = new Point(240, 279);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(180, 30);
            AddButton.TabIndex = 49;
            AddButton.Text = "Ekle";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(400, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 26);
            dateTimePicker1.TabIndex = 47;
            // 
            // CostTypeCB
            // 
            CostTypeCB.Anchor = AnchorStyles.None;
            CostTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CostTypeCB.FormattingEnabled = true;
            CostTypeCB.Location = new Point(400, 245);
            CostTypeCB.Name = "CostTypeCB";
            CostTypeCB.Size = new Size(130, 28);
            CostTypeCB.TabIndex = 42;
            CostTypeCB.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(550, 225);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 38;
            label1.Text = "Ödeme";
            label1.Visible = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(400, 225);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 39;
            label11.Text = "Ödeme Tipi";
            label11.Visible = false;
            // 
            // ExpenseTypeCB
            // 
            ExpenseTypeCB.Anchor = AnchorStyles.None;
            ExpenseTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseTypeCB.FormattingEnabled = true;
            ExpenseTypeCB.Location = new Point(240, 245);
            ExpenseTypeCB.Name = "ExpenseTypeCB";
            ExpenseTypeCB.Size = new Size(130, 28);
            ExpenseTypeCB.TabIndex = 46;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(400, 165);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 45;
            label6.Text = "Tarih";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(240, 225);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 44;
            label5.Text = "Gider Tipi";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(240, 165);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 43;
            label4.Text = "Plaka";
            // 
            // CostTxt
            // 
            CostTxt.Anchor = AnchorStyles.None;
            CostTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CostTxt.Location = new Point(550, 245);
            CostTxt.Name = "CostTxt";
            CostTxt.Size = new Size(130, 26);
            CostTxt.TabIndex = 41;
            // 
            // LicensePlateTxt
            // 
            LicensePlateTxt.Anchor = AnchorStyles.None;
            LicensePlateTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LicensePlateTxt.Location = new Point(240, 185);
            LicensePlateTxt.Name = "LicensePlateTxt";
            LicensePlateTxt.ReadOnly = true;
            LicensePlateTxt.Size = new Size(130, 26);
            LicensePlateTxt.TabIndex = 40;
            // 
            // AddVehicleExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(VehicleExpensePanel);
            MinimumSize = new Size(900, 470);
            Name = "AddVehicleExpense";
            Size = new Size(900, 470);
            VehicleExpensePanel.ResumeLayout(false);
            VehicleExpensePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel VehicleExpensePanel;
        private Button CancelButton;
        private Button AddButton;
        private DateTimePicker dateTimePicker1;
        private ComboBox CostTypeCB;
        private Label label1;
        private Label label11;
        private ComboBox ExpenseTypeCB;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox CostTxt;
        private TextBox LicensePlateTxt;
        private Button TurnBackButton;
        private Panel TitlePanel;
        private Label label2;
    }
}
