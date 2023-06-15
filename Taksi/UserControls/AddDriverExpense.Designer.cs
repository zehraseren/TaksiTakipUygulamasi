namespace Taksi.UserControls
{
    partial class AddDriverExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriverExpense));
            AddDriverExpensePanel = new Panel();
            CostTxt = new TextBox();
            CostTypeCB = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DriverExpenseTypeCB = new ComboBox();
            CancelButton = new Button();
            AddButton = new Button();
            TurnBackButton = new Button();
            TitlePanel = new Panel();
            label4 = new Label();
            AddDriverExpensePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddDriverExpensePanel
            // 
            AddDriverExpensePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddDriverExpensePanel.BackgroundImageLayout = ImageLayout.Stretch;
            AddDriverExpensePanel.Controls.Add(CostTxt);
            AddDriverExpensePanel.Controls.Add(CostTypeCB);
            AddDriverExpensePanel.Controls.Add(label3);
            AddDriverExpensePanel.Controls.Add(label2);
            AddDriverExpensePanel.Controls.Add(label1);
            AddDriverExpensePanel.Controls.Add(DriverExpenseTypeCB);
            AddDriverExpensePanel.Controls.Add(CancelButton);
            AddDriverExpensePanel.Controls.Add(AddButton);
            AddDriverExpensePanel.Location = new Point(0, 0);
            AddDriverExpensePanel.Name = "AddDriverExpensePanel";
            AddDriverExpensePanel.Size = new Size(900, 420);
            AddDriverExpensePanel.TabIndex = 0;
            // 
            // CostTxt
            // 
            CostTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CostTxt.Location = new Point(550, 190);
            CostTxt.Name = "CostTxt";
            CostTxt.Size = new Size(130, 26);
            CostTxt.TabIndex = 22;
            // 
            // CostTypeCB
            // 
            CostTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CostTypeCB.FormattingEnabled = true;
            CostTypeCB.Location = new Point(400, 190);
            CostTypeCB.Name = "CostTypeCB";
            CostTypeCB.Size = new Size(130, 28);
            CostTypeCB.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(550, 170);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 20;
            label3.Text = "Tutar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 170);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 19;
            label2.Text = "Ödeme Tipi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 170);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 18;
            label1.Text = "Gider Tipi";
            // 
            // DriverExpenseTypeCB
            // 
            DriverExpenseTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DriverExpenseTypeCB.FormattingEnabled = true;
            DriverExpenseTypeCB.Location = new Point(250, 190);
            DriverExpenseTypeCB.Name = "DriverExpenseTypeCB";
            DriverExpenseTypeCB.Size = new Size(130, 28);
            DriverExpenseTypeCB.TabIndex = 17;
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.BackColor = Color.FromArgb(111, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(500, 224);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 30);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Vazgeç";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.FromArgb(0, 98, 3);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(250, 224);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(180, 30);
            AddButton.TabIndex = 16;
            AddButton.Text = "Ekle";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click_1;
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
            TurnBackButton.TabIndex = 23;
            TurnBackButton.UseVisualStyleBackColor = false;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Controls.Add(label4);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 60);
            TitlePanel.TabIndex = 114;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(324, 20);
            label4.Name = "label4";
            label4.Size = new Size(261, 29);
            label4.TabIndex = 4;
            label4.Text = "Sürücü Gider Ekleme";
            // 
            // AddDriverExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(TitlePanel);
            Controls.Add(AddDriverExpensePanel);
            Name = "AddDriverExpense";
            Size = new Size(900, 420);
            AddDriverExpensePanel.ResumeLayout(false);
            AddDriverExpensePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddDriverExpensePanel;
        public TextBox CostTxt;
        public ComboBox CostTypeCB;
        private Label label3;
        private Label label2;
        private Label label1;
        public ComboBox DriverExpenseTypeCB;
        private Button CancelButton;
        private Button AddButton;
        private Button TurnBackButton;
        private Panel TitlePanel;
        private Label label4;
    }
}
