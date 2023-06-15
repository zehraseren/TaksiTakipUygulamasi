namespace Taksi.UserControls
{
    partial class DriverExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverExpense));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DriverExpensePanel = new Panel();
            TitlePanel = new Panel();
            label2 = new Label();
            TurnBackButton = new Button();
            label1 = new Label();
            FullListBtn = new Button();
            EditButton = new Button();
            ExpenseTypeCB = new ComboBox();
            AddButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            DriverExpenseDGV = new DataGridView();
            DriverExpensePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DriverExpenseDGV).BeginInit();
            SuspendLayout();
            // 
            // DriverExpensePanel
            // 
            DriverExpensePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DriverExpensePanel.BackColor = Color.Transparent;
            DriverExpensePanel.Controls.Add(TitlePanel);
            DriverExpensePanel.Controls.Add(statusStrip1);
            DriverExpensePanel.Controls.Add(DriverExpenseDGV);
            DriverExpensePanel.Location = new Point(0, 0);
            DriverExpensePanel.Name = "DriverExpensePanel";
            DriverExpensePanel.Size = new Size(900, 470);
            DriverExpensePanel.TabIndex = 0;
            DriverExpensePanel.Paint += DriverExpensePanel_Paint;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(FullListBtn);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(ExpenseTypeCB);
            TitlePanel.Controls.Add(AddButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            TitlePanel.Paint += TitlePanel_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(352, 20);
            label2.Name = "label2";
            label2.Size = new Size(204, 29);
            label2.TabIndex = 58;
            label2.Text = "Sürücü Giderleri";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 82);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 5;
            label1.Text = "Gider Türü";
            // 
            // FullListBtn
            // 
            FullListBtn.AutoSize = true;
            FullListBtn.BackColor = Color.FromArgb(88, 24, 69);
            FullListBtn.FlatAppearance.BorderSize = 0;
            FullListBtn.FlatStyle = FlatStyle.Flat;
            FullListBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FullListBtn.ForeColor = Color.White;
            FullListBtn.Location = new Point(177, 107);
            FullListBtn.Name = "FullListBtn";
            FullListBtn.Size = new Size(72, 30);
            FullListBtn.TabIndex = 4;
            FullListBtn.Text = "Listele";
            FullListBtn.UseVisualStyleBackColor = false;
            FullListBtn.Click += SearchButton_Click;
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
            EditButton.Location = new Point(755, 107);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(95, 30);
            EditButton.TabIndex = 1;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ExpenseTypeCB
            // 
            ExpenseTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseTypeCB.FormattingEnabled = true;
            ExpenseTypeCB.Location = new Point(50, 107);
            ExpenseTypeCB.Name = "ExpenseTypeCB";
            ExpenseTypeCB.Size = new Size(120, 28);
            ExpenseTypeCB.TabIndex = 3;
            ExpenseTypeCB.SelectedIndexChanged += ExpenseTypeCB_SelectedIndexChanged;
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
            AddButton.Location = new Point(687, 107);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(62, 30);
            AddButton.TabIndex = 2;
            AddButton.Text = "Ekle";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 445);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 25);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(19, 20);
            toolStripStatusLabel1.Text = "  ";
            // 
            // DriverExpenseDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DriverExpenseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DriverExpenseDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DriverExpenseDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DriverExpenseDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DriverExpenseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DriverExpenseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DriverExpenseDGV.DefaultCellStyle = dataGridViewCellStyle3;
            DriverExpenseDGV.Location = new Point(50, 140);
            DriverExpenseDGV.Name = "DriverExpenseDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DriverExpenseDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DriverExpenseDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DriverExpenseDGV.RowTemplate.Height = 25;
            DriverExpenseDGV.Size = new Size(800, 300);
            DriverExpenseDGV.TabIndex = 0;
            // 
            // DriverExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(DriverExpensePanel);
            Name = "DriverExpense";
            Size = new Size(900, 470);
            DriverExpensePanel.ResumeLayout(false);
            DriverExpensePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DriverExpenseDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DriverExpensePanel;
        private Label label1;
        private Button FullListBtn;
        private Button AddButton;
        private Button EditButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        public DataGridView DriverExpenseDGV;
        public ComboBox ExpenseTypeCB;
        private Panel TitlePanel;
        private Button TurnBackButton;
        private Label label2;
    }
}
