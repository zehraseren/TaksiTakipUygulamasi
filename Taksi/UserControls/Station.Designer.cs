namespace Taksi.UserControls
{
    partial class Station
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
            VehiclePanel = new Panel();
            StationPanel = new Panel();
            TitlePanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            AddStationButton = new Button();
            ShowInMapRB = new RadioButton();
            EditBtn = new Button();
            StationStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            StationDGV = new DataGridView();
            VehiclePanel.SuspendLayout();
            StationPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            panel1.SuspendLayout();
            StationStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StationDGV).BeginInit();
            SuspendLayout();
            // 
            // VehiclePanel
            // 
            VehiclePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VehiclePanel.BackColor = Color.Transparent;
            VehiclePanel.Controls.Add(StationPanel);
            VehiclePanel.Location = new Point(0, 0);
            VehiclePanel.Name = "VehiclePanel";
            VehiclePanel.Size = new Size(900, 470);
            VehiclePanel.TabIndex = 10;
            // 
            // StationPanel
            // 
            StationPanel.BackColor = Color.Transparent;
            StationPanel.BackgroundImageLayout = ImageLayout.Stretch;
            StationPanel.Controls.Add(TitlePanel);
            StationPanel.Controls.Add(StationStatus);
            StationPanel.Controls.Add(StationDGV);
            StationPanel.Dock = DockStyle.Fill;
            StationPanel.Location = new Point(0, 0);
            StationPanel.Name = "StationPanel";
            StationPanel.Size = new Size(900, 470);
            StationPanel.TabIndex = 10;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(panel1);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 140);
            TitlePanel.TabIndex = 73;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(401, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 75;
            label1.Text = "Duraklar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddStationButton);
            panel1.Controls.Add(ShowInMapRB);
            panel1.Controls.Add(EditBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 90);
            panel1.TabIndex = 74;
            // 
            // AddStationButton
            // 
            AddStationButton.AutoSize = true;
            AddStationButton.BackColor = Color.FromArgb(255, 128, 0);
            AddStationButton.FlatAppearance.BorderSize = 0;
            AddStationButton.FlatStyle = FlatStyle.Flat;
            AddStationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddStationButton.ForeColor = Color.White;
            AddStationButton.Location = new Point(50, 57);
            AddStationButton.Name = "AddStationButton";
            AddStationButton.Size = new Size(148, 30);
            AddStationButton.TabIndex = 19;
            AddStationButton.Text = "Yeni Durak Ekle";
            AddStationButton.UseVisualStyleBackColor = false;
            AddStationButton.Click += AddStationButton_Click;
            // 
            // ShowInMapRB
            // 
            ShowInMapRB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowInMapRB.Appearance = Appearance.Button;
            ShowInMapRB.AutoSize = true;
            ShowInMapRB.BackColor = Color.FromArgb(255, 183, 3);
            ShowInMapRB.FlatAppearance.BorderSize = 0;
            ShowInMapRB.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 224, 192);
            ShowInMapRB.FlatStyle = FlatStyle.Flat;
            ShowInMapRB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShowInMapRB.ForeColor = Color.White;
            ShowInMapRB.Location = new Point(636, 57);
            ShowInMapRB.Name = "ShowInMapRB";
            ShowInMapRB.Size = new Size(123, 30);
            ShowInMapRB.TabIndex = 13;
            ShowInMapRB.TabStop = true;
            ShowInMapRB.Text = "Haritada Gör";
            ShowInMapRB.UseVisualStyleBackColor = false;
            ShowInMapRB.CheckedChanged += ShowInMapRB_CheckedChanged;
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditBtn.AutoSize = true;
            EditBtn.BackColor = Color.FromArgb(2, 48, 71);
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 224, 192);
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(765, 57);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(85, 30);
            EditBtn.TabIndex = 15;
            EditBtn.Text = "Düzenle";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // StationStatus
            // 
            StationStatus.BackColor = Color.Transparent;
            StationStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StationStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            StationStatus.Location = new Point(0, 445);
            StationStatus.Name = "StationStatus";
            StationStatus.Size = new Size(900, 25);
            StationStatus.TabIndex = 18;
            StationStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(14, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // StationDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StationDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StationDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StationDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StationDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StationDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            StationDGV.DefaultCellStyle = dataGridViewCellStyle3;
            StationDGV.Location = new Point(50, 140);
            StationDGV.Name = "StationDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            StationDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StationDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            StationDGV.RowTemplate.Height = 25;
            StationDGV.Size = new Size(800, 300);
            StationDGV.TabIndex = 17;
            // 
            // Station
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(VehiclePanel);
            Name = "Station";
            Size = new Size(900, 470);
            VehiclePanel.ResumeLayout(false);
            StationPanel.ResumeLayout(false);
            StationPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            StationStatus.ResumeLayout(false);
            StationStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StationDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel VehiclePanel;
        private Panel StationPanel;
        private StatusStrip StationStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridView StationDGV;
        private Button EditBtn;
        private RadioButton ShowInMapRB;
        private Button AddStationButton;
        private Panel TitlePanel;
        private Panel panel1;
        private Label label1;
    }
}
