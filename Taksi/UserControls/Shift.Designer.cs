namespace Taksi.UserControls
{
    partial class Shift
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            ShiftPanel = new Panel();
            TitlePanel = new Panel();
            ListBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ShowButton = new Button();
            ShiftTypeCB = new ComboBox();
            ShiftDGV = new DataGridView();
            RideStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ShiftPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShiftDGV).BeginInit();
            RideStatus.SuspendLayout();
            SuspendLayout();
            // 
            // ShiftPanel
            // 
            ShiftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShiftPanel.BackColor = Color.Transparent;
            ShiftPanel.Controls.Add(TitlePanel);
            ShiftPanel.Controls.Add(ShiftDGV);
            ShiftPanel.Controls.Add(RideStatus);
            ShiftPanel.Location = new Point(0, 0);
            ShiftPanel.Name = "ShiftPanel";
            ShiftPanel.Size = new Size(900, 470);
            ShiftPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(ListBtn);
            TitlePanel.Controls.Add(label2);
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(ShowButton);
            TitlePanel.Controls.Add(ShiftTypeCB);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // ListBtn
            // 
            ListBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListBtn.AutoSize = true;
            ListBtn.BackColor = Color.FromArgb(88, 24, 69);
            ListBtn.FlatAppearance.BorderSize = 0;
            ListBtn.FlatStyle = FlatStyle.Flat;
            ListBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ListBtn.ForeColor = Color.White;
            ListBtn.Location = new Point(696, 105);
            ListBtn.Name = "ListBtn";
            ListBtn.Size = new Size(154, 30);
            ListBtn.TabIndex = 74;
            ListBtn.Text = "Tümünü Listele";
            ListBtn.UseVisualStyleBackColor = false;
            ListBtn.Click += ListBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(383, 20);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 58;
            label2.Text = "Vardiyalar";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 85);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Vardiya Tipi";
            // 
            // ShowButton
            // 
            ShowButton.AutoSize = true;
            ShowButton.BackColor = Color.FromArgb(88, 24, 69);
            ShowButton.FlatAppearance.BorderSize = 0;
            ShowButton.FlatStyle = FlatStyle.Flat;
            ShowButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShowButton.ForeColor = Color.White;
            ShowButton.Location = new Point(190, 105);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(74, 30);
            ShowButton.TabIndex = 2;
            ShowButton.Text = "Göster";
            ShowButton.UseVisualStyleBackColor = false;
            ShowButton.Click += ShowButton_Click;
            // 
            // ShiftTypeCB
            // 
            ShiftTypeCB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShiftTypeCB.FormattingEnabled = true;
            ShiftTypeCB.Location = new Point(50, 105);
            ShiftTypeCB.Name = "ShiftTypeCB";
            ShiftTypeCB.Size = new Size(130, 28);
            ShiftTypeCB.TabIndex = 3;
            // 
            // ShiftDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShiftDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ShiftDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShiftDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShiftDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ShiftDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ShiftDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ShiftDGV.DefaultCellStyle = dataGridViewCellStyle3;
            ShiftDGV.Location = new Point(50, 140);
            ShiftDGV.Name = "ShiftDGV";
            ShiftDGV.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ShiftDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShiftDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            ShiftDGV.RowTemplate.Height = 25;
            ShiftDGV.Size = new Size(800, 300);
            ShiftDGV.TabIndex = 4;
            // 
            // RideStatus
            // 
            RideStatus.BackColor = Color.Transparent;
            RideStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RideStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            RideStatus.Location = new Point(0, 445);
            RideStatus.Name = "RideStatus";
            RideStatus.Size = new Size(900, 25);
            RideStatus.TabIndex = 0;
            RideStatus.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // Shift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ShiftPanel);
            Name = "Shift";
            Size = new Size(900, 470);
            ShiftPanel.ResumeLayout(false);
            ShiftPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShiftDGV).EndInit();
            RideStatus.ResumeLayout(false);
            RideStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ShiftPanel;
        private Label label1;
        private DataGridView ShiftDGV;
        private ComboBox ShiftTypeCB;
        private Button ShowButton;
        private StatusStrip RideStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel TitlePanel;
        private Label label2;
        private Button ListBtn;
    }
}
