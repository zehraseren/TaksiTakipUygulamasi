namespace Taksi.UserControls
{
    partial class Vehicle
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
            VehicleDGV = new DataGridView();
            VehicleStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            VehiclePanel = new Panel();
            TitlePanel = new Panel();
            ShowExpenceButton = new Button();
            AddVehicleButton = new Button();
            ShowInMapButton = new Button();
            label1 = new Label();
            RemoveButton = new Button();
            EditButton = new Button();
            SearchButton = new Button();
            LicensePlateTxt = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)VehicleDGV).BeginInit();
            VehicleStatus.SuspendLayout();
            VehiclePanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // VehicleDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            VehicleDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VehicleDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VehicleDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            VehicleDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            VehicleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            VehicleDGV.DefaultCellStyle = dataGridViewCellStyle3;
            VehicleDGV.Location = new Point(50, 140);
            VehicleDGV.Name = "VehicleDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            VehicleDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            VehicleDGV.RowTemplate.Height = 25;
            VehicleDGV.Size = new Size(800, 300);
            VehicleDGV.TabIndex = 6;
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
            // VehiclePanel
            // 
            VehiclePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VehiclePanel.BackColor = Color.Transparent;
            VehiclePanel.Controls.Add(TitlePanel);
            VehiclePanel.Controls.Add(VehicleStatus);
            VehiclePanel.Controls.Add(VehicleDGV);
            VehiclePanel.Location = new Point(0, 0);
            VehiclePanel.Name = "VehiclePanel";
            VehiclePanel.Size = new Size(900, 470);
            VehiclePanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.Controls.Add(ShowExpenceButton);
            TitlePanel.Controls.Add(AddVehicleButton);
            TitlePanel.Controls.Add(ShowInMapButton);
            TitlePanel.Controls.Add(label1);
            TitlePanel.Controls.Add(RemoveButton);
            TitlePanel.Controls.Add(EditButton);
            TitlePanel.Controls.Add(SearchButton);
            TitlePanel.Controls.Add(LicensePlateTxt);
            TitlePanel.Controls.Add(label4);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(900, 142);
            TitlePanel.TabIndex = 110;
            // 
            // ShowExpenceButton
            // 
            ShowExpenceButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowExpenceButton.AutoSize = true;
            ShowExpenceButton.BackColor = Color.FromArgb(88, 24, 69);
            ShowExpenceButton.FlatAppearance.BorderSize = 0;
            ShowExpenceButton.FlatStyle = FlatStyle.Flat;
            ShowExpenceButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShowExpenceButton.ForeColor = Color.White;
            ShowExpenceButton.Location = new Point(599, 72);
            ShowExpenceButton.Name = "ShowExpenceButton";
            ShowExpenceButton.Size = new Size(122, 30);
            ShowExpenceButton.TabIndex = 92;
            ShowExpenceButton.Text = "Giderleri Gör";
            ShowExpenceButton.UseVisualStyleBackColor = false;
            ShowExpenceButton.Click += ShowExpenceButton_Click;
            // 
            // AddVehicleButton
            // 
            AddVehicleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddVehicleButton.AutoSize = true;
            AddVehicleButton.BackColor = Color.FromArgb(255, 128, 0);
            AddVehicleButton.FlatAppearance.BorderSize = 0;
            AddVehicleButton.FlatStyle = FlatStyle.Flat;
            AddVehicleButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddVehicleButton.ForeColor = Color.White;
            AddVehicleButton.Location = new Point(707, 107);
            AddVehicleButton.Name = "AddVehicleButton";
            AddVehicleButton.Size = new Size(143, 30);
            AddVehicleButton.TabIndex = 91;
            AddVehicleButton.Text = "Yeni Araç Ekle";
            AddVehicleButton.UseVisualStyleBackColor = false;
            AddVehicleButton.Click += AddVehicleButton_Click;
            // 
            // ShowInMapButton
            // 
            ShowInMapButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowInMapButton.AutoSize = true;
            ShowInMapButton.BackColor = Color.FromArgb(255, 183, 3);
            ShowInMapButton.FlatAppearance.BorderSize = 0;
            ShowInMapButton.FlatStyle = FlatStyle.Flat;
            ShowInMapButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShowInMapButton.ForeColor = Color.White;
            ShowInMapButton.Location = new Point(727, 72);
            ShowInMapButton.Name = "ShowInMapButton";
            ShowInMapButton.Size = new Size(123, 30);
            ShowInMapButton.TabIndex = 90;
            ShowInMapButton.Text = "Haritada Gör";
            ShowInMapButton.UseVisualStyleBackColor = false;
            ShowInMapButton.Click += ShowInMapButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 82);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 89;
            label1.Text = "Plaka";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.BackColor = Color.FromArgb(111, 0, 0);
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(661, 107);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(40, 30);
            RemoveButton.TabIndex = 88;
            RemoveButton.Text = "Sil";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
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
            EditButton.Location = new Point(563, 107);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(92, 30);
            EditButton.TabIndex = 87;
            EditButton.Text = "Düzenle";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.AutoSize = true;
            SearchButton.BackColor = Color.FromArgb(88, 24, 69);
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(206, 107);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(47, 30);
            SearchButton.TabIndex = 86;
            SearchButton.Text = "Ara";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // LicensePlateTxt
            // 
            LicensePlateTxt.Cursor = Cursors.IBeam;
            LicensePlateTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LicensePlateTxt.Location = new Point(51, 107);
            LicensePlateTxt.Name = "LicensePlateTxt";
            LicensePlateTxt.Size = new Size(145, 26);
            LicensePlateTxt.TabIndex = 85;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(401, 20);
            label4.Name = "label4";
            label4.Size = new Size(95, 29);
            label4.TabIndex = 84;
            label4.Text = "Araçlar";
            // 
            // Vehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(VehiclePanel);
            Name = "Vehicle";
            Size = new Size(900, 470);
            ((System.ComponentModel.ISupportInitialize)VehicleDGV).EndInit();
            VehicleStatus.ResumeLayout(false);
            VehicleStatus.PerformLayout();
            VehiclePanel.ResumeLayout(false);
            VehiclePanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView VehicleDGV;
        private StatusStrip VehicleStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel VehiclePanel;
        private Panel TitlePanel;
        private Label label4;
        private Button ShowExpenceButton;
        private Button AddVehicleButton;
        private Button ShowInMapButton;
        private Label label1;
        private Button RemoveButton;
        private Button EditButton;
        private Button SearchButton;
        public TextBox LicensePlateTxt;
    }
}
