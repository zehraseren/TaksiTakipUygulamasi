namespace Taksi.UserControls
{
    partial class Home
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            HomePanel = new Panel();
            removeCusBtn = new Button();
            removelistBtn = new Button();
            CallPastDGV = new DataGridView();
            panel1 = new Panel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            SearchCustomerButton = new Button();
            addlistBtn = new Button();
            SearchTxt = new TextBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CallPastDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomePanel.AutoScroll = true;
            HomePanel.BackColor = Color.Transparent;
            HomePanel.Controls.Add(removeCusBtn);
            HomePanel.Controls.Add(removelistBtn);
            HomePanel.Controls.Add(CallPastDGV);
            HomePanel.Controls.Add(panel1);
            HomePanel.Controls.Add(SearchCustomerButton);
            HomePanel.Controls.Add(addlistBtn);
            HomePanel.Controls.Add(SearchTxt);
            HomePanel.Controls.Add(dataGridView2);
            HomePanel.Controls.Add(label4);
            HomePanel.Controls.Add(label3);
            HomePanel.Controls.Add(dataGridView1);
            HomePanel.Controls.Add(label2);
            HomePanel.Controls.Add(label1);
            HomePanel.Location = new Point(0, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(900, 660);
            HomePanel.TabIndex = 4;
            // 
            // removeCusBtn
            // 
            removeCusBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeCusBtn.AutoSize = true;
            removeCusBtn.BackColor = Color.FromArgb(255, 128, 0);
            removeCusBtn.FlatAppearance.BorderSize = 0;
            removeCusBtn.FlatStyle = FlatStyle.Flat;
            removeCusBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeCusBtn.ForeColor = Color.White;
            removeCusBtn.Location = new Point(708, 615);
            removeCusBtn.Name = "removeCusBtn";
            removeCusBtn.Size = new Size(127, 30);
            removeCusBtn.TabIndex = 6;
            removeCusBtn.Text = "Sıradan Çıkar";
            removeCusBtn.UseVisualStyleBackColor = false;
            removeCusBtn.Click += removeCusBtn_Click;
            // 
            // removelistBtn
            // 
            removelistBtn.AutoSize = true;
            removelistBtn.BackColor = Color.FromArgb(255, 128, 0);
            removelistBtn.FlatAppearance.BorderSize = 0;
            removelistBtn.FlatStyle = FlatStyle.Flat;
            removelistBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removelistBtn.ForeColor = Color.White;
            removelistBtn.Location = new Point(62, 288);
            removelistBtn.Name = "removelistBtn";
            removelistBtn.Size = new Size(127, 30);
            removelistBtn.TabIndex = 5;
            removelistBtn.Text = "Sıradan Çıkar";
            removelistBtn.UseVisualStyleBackColor = false;
            removelistBtn.Click += removelistBtn_Click;
            // 
            // CallPastDGV
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CallPastDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CallPastDGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CallPastDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CallPastDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CallPastDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CallPastDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CallPastDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CallPastDGV.DefaultCellStyle = dataGridViewCellStyle3;
            CallPastDGV.Location = new Point(653, 103);
            CallPastDGV.Name = "CallPastDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CallPastDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CallPastDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CallPastDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CallPastDGV.RowTemplate.Height = 25;
            CallPastDGV.Size = new Size(236, 500);
            CallPastDGV.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(gMapControl1);
            panel1.Location = new Point(285, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 536);
            panel1.TabIndex = 5;
            // 
            // gMapControl1
            // 
            gMapControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(0, 0);
            gMapControl1.Margin = new Padding(3, 2, 3, 2);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 33;
            gMapControl1.MinZoom = 11;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(325, 536);
            gMapControl1.TabIndex = 4;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // SearchCustomerButton
            // 
            SearchCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchCustomerButton.AutoSize = true;
            SearchCustomerButton.BackColor = Color.FromArgb(255, 128, 0);
            SearchCustomerButton.FlatAppearance.BorderSize = 0;
            SearchCustomerButton.FlatStyle = FlatStyle.Flat;
            SearchCustomerButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchCustomerButton.ForeColor = Color.White;
            SearchCustomerButton.Location = new Point(823, 40);
            SearchCustomerButton.Name = "SearchCustomerButton";
            SearchCustomerButton.Size = new Size(47, 30);
            SearchCustomerButton.TabIndex = 2;
            SearchCustomerButton.Text = "Ara";
            SearchCustomerButton.UseVisualStyleBackColor = false;
            SearchCustomerButton.Click += SearchCustomerButton_Click;
            // 
            // addlistBtn
            // 
            addlistBtn.AutoSize = true;
            addlistBtn.BackColor = Color.FromArgb(0, 98, 3);
            addlistBtn.FlatAppearance.BorderSize = 0;
            addlistBtn.FlatStyle = FlatStyle.Flat;
            addlistBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addlistBtn.ForeColor = Color.White;
            addlistBtn.Location = new Point(71, 612);
            addlistBtn.Name = "addlistBtn";
            addlistBtn.Size = new Size(109, 30);
            addlistBtn.TabIndex = 4;
            addlistBtn.Text = "Sıraya Ekle";
            addlistBtn.UseVisualStyleBackColor = false;
            addlistBtn.Click += addlistBtn_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTxt.Cursor = Cursors.IBeam;
            SearchTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTxt.ForeColor = Color.DimGray;
            SearchTxt.Location = new Point(670, 40);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(147, 26);
            SearchTxt.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.Location = new Point(5, 364);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 239);
            dataGridView2.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(670, 80);
            label4.Name = "label4";
            label4.Size = new Size(203, 20);
            label4.TabIndex = 0;
            label4.Text = "Sırada Bekleyen Müşteri";
            label4.Click += label3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(701, 10);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Müşteri Ara";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.Location = new Point(7, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(236, 235);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 338);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 3;
            label2.Text = "Sıra Dışındaki Araçlar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Sıradaki Araçlar";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(HomePanel);
            Name = "Home";
            Size = new Size(900, 660);
            Load += Home_Load;
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CallPastDGV).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePanel;
        private DataGridView CallPastDGV;
        private Button SearchCustomerButton;
        private Label label3;
        private Label label1;
        private Label label4;
        private DataGridView NextDGV;
        private Button removelistBtn;
        private Button addlistBtn;
        private Label label2;
        public DataGridView dataGridView2;
        public DataGridView dataGridView1;
        public TextBox SearchTxt;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Panel panel1;
        private Button removeCusBtn;
        private DataGridViewCellStyle dataGridViewCellStyle11;
        private DataGridViewCellStyle dataGridViewCellStyle12;
        private DataGridViewCellStyle dataGridViewCellStyle13;
        private DataGridViewCellStyle dataGridViewCellStyle14;
        private DataGridViewCellStyle dataGridViewCellStyle15;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private DataGridViewCellStyle dataGridViewCellStyle5;
    }
}
