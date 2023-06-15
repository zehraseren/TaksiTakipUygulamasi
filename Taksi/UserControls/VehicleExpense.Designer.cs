namespace Taksi.UserControls
{
    partial class VehicleExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleExpense));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            VehicleExpensePanel = new Panel();
            TitlePanel = new Panel();
            EndDTP = new DateTimePicker();
            label2 = new Label();
            BeginDTP = new DateTimePicker();
            TurnBackButton = new Button();
            label1 = new Label();
            VehicleExpenceCB = new ComboBox();
            SearchButton = new Button();
            AddButton = new Button();
            EditButton = new Button();
            label3 = new Label();
            VehicleStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            VehicleDGV = new DataGridView();
            VehicleExpensePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            VehicleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VehicleDGV).BeginInit();
            SuspendLayout();
            // 
            // VehicleExpensePanel
            // 
            VehicleExpensePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VehicleExpensePanel.BackColor = Color.Transparent;
            VehicleExpensePanel.Controls.Add(TitlePanel);
            VehicleExpensePanel.Controls.Add(VehicleStatus);
            VehicleExpensePanel.Controls.Add(VehicleDGV);
            VehicleExpensePanel.Location = new Point(0, 0);
            VehicleExpensePanel.Name = "VehicleExpensePanel";
            VehicleExpensePanel.Size = new Size(900, 470);
            VehicleExpensePanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(EndDTP);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(BeginDTP);
            TitlePanel.Controls.Add(TurnBackButton);
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(VehicleExpenceCB);
            TitlePanel.Controls.Add(SearchButton);
            TitlePanel.Controls.Add(AddButton);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(label3);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // EndDTP
            // 
            EndDTP.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EndDTP.Format = DateTimePickerFormat.Custom;
            EndDTP.Location = new Point(492, 105);
            EndDTP.Name = "EndDTP";
            EndDTP.Size = new Size(130, 24);
            EndDTP.TabIndex = 87;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(362, 20);
            label2.Name = "label2";
            label2.Size = new Size(175, 29);
            label2.TabIndex = 4;
            label2.Text = "Araç Giderleri";
            // 
            // BeginDTP
            // 
            BeginDTP.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BeginDTP.Format = DateTimePickerFormat.Custom;
            BeginDTP.Location = new Point(353, 105);
            BeginDTP.Name = "BeginDTP";
            BeginDTP.Size = new Size(130, 24);
            BeginDTP.TabIndex = 86;
            // 
            // TurnBackButton
            // 
            TurnBackButton.BackgroundImage = (Image)resources.GetObject("TurnBackButton.BackgroundImage");
            TurnBackButton.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackButton.FlatAppearance.BorderSize = 0;
            TurnBackButton.FlatStyle = FlatStyle.Flat;
            TurnBackButton.Location = new Point(20, 10);
            TurnBackButton.Name = "TurnBackButton";
            TurnBackButton.Size = new Size(30, 30);
            TurnBackButton.TabIndex = 11;
            TurnBackButton.UseVisualStyleBackColor = true;
            TurnBackButton.Click += TurnBackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 105);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 7;
            label1.Text = "Gider Tipi";
            // 
            // VehicleExpenceCB
            // 
            VehicleExpenceCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleExpenceCB.FormattingEnabled = true;
            VehicleExpenceCB.Location = new Point(138, 105);
            VehicleExpenceCB.Name = "VehicleExpenceCB";
            VehicleExpenceCB.Size = new Size(100, 28);
            VehicleExpenceCB.TabIndex = 10;
            // 
            // SearchButton
            // 
            SearchButton.AutoSize = true;
            SearchButton.BackColor = Color.FromArgb(88, 24, 69);
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(628, 105);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(47, 30);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Ara";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
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
            AddButton.Location = new Point(704, 105);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(54, 30);
            AddButton.TabIndex = 9;
            AddButton.Text = "Ekle";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
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
            EditButton.Location = new Point(764, 105);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(85, 30);
            EditButton.TabIndex = 4;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(244, 105);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 7;
            label3.Text = "Tarih Aralığı:";
            // 
            // VehicleStatus
            // 
            VehicleStatus.BackColor = Color.Transparent;
            VehicleStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            VehicleStatus.Location = new Point(0, 445);
            VehicleStatus.Name = "VehicleStatus";
            VehicleStatus.Size = new Size(900, 25);
            VehicleStatus.TabIndex = 8;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // VehicleDGV
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            VehicleDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VehicleDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VehicleDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            VehicleDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            VehicleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            VehicleDGV.DefaultCellStyle = dataGridViewCellStyle8;
            VehicleDGV.Location = new Point(50, 140);
            VehicleDGV.Name = "VehicleDGV";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            VehicleDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            VehicleDGV.RowTemplate.Height = 25;
            VehicleDGV.Size = new Size(800, 300);
            VehicleDGV.TabIndex = 6;
            // 
            // VehicleExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(VehicleExpensePanel);
            Name = "VehicleExpense";
            Size = new Size(900, 470);
            VehicleExpensePanel.ResumeLayout(false);
            VehicleExpensePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            VehicleStatus.ResumeLayout(false);
            VehicleStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VehicleDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel VehicleExpensePanel;
        private DataGridView VehicleDGV;
        private StatusStrip VehicleStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button TurnBackButton;
        private Panel TitlePanel;
        private Label label2;
        private DateTimePicker EndDTP;
        private DateTimePicker BeginDTP;
        private Label label1;
        private ComboBox VehicleExpenceCB;
        private Button SearchButton;
        private Button AddButton;
        private Button EditButton;
        private Label label3;
    }
}
