namespace Taksi
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            IconList = new ImageList(components);
            UserBarPanel = new Panel();
            profileBtn = new Button();
            ExitButton = new Button();
            HomePageButton = new Button();
            MenuPanel = new Panel();
            menuTableLayoutPanel = new TableLayoutPanel();
            UserButton = new Button();
            RideButton = new Button();
            CustomerButton = new Button();
            ShiftButton = new Button();
            DriverButton = new Button();
            VehicleButton = new Button();
            StationButton = new Button();
            HomeButton = new Button();
            ContainerPanel = new Panel();
            UserBarPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            menuTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IconList
            // 
            IconList.ColorDepth = ColorDepth.Depth8Bit;
            IconList.ImageStream = (ImageListStreamer)resources.GetObject("IconList.ImageStream");
            IconList.TransparentColor = Color.Transparent;
            IconList.Images.SetKeyName(0, "Minimized.png");
            IconList.Images.SetKeyName(1, "X.png");
            IconList.Images.SetKeyName(2, "Maximized.png");
            IconList.Images.SetKeyName(3, "Home.png");
            // 
            // UserBarPanel
            // 
            UserBarPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserBarPanel.BackColor = Color.FromArgb(230, 180, 0);
            UserBarPanel.Controls.Add(profileBtn);
            UserBarPanel.Controls.Add(ExitButton);
            UserBarPanel.Controls.Add(HomePageButton);
            UserBarPanel.Location = new Point(0, 0);
            UserBarPanel.Name = "UserBarPanel";
            UserBarPanel.Size = new Size(900, 50);
            UserBarPanel.TabIndex = 1;
            // 
            // profileBtn
            // 
            profileBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            profileBtn.AutoSize = true;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profileBtn.ForeColor = SystemColors.ControlText;
            profileBtn.Location = new Point(666, -1);
            profileBtn.Margin = new Padding(3, 0, 3, 0);
            profileBtn.Name = "profileBtn";
            profileBtn.RightToLeft = RightToLeft.Yes;
            profileBtn.Size = new Size(178, 50);
            profileBtn.TabIndex = 1;
            profileBtn.Text = "Kullanıcılar";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Center;
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Location = new Point(850, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(50, 50);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HomePageButton
            // 
            HomePageButton.BackgroundImage = (Image)resources.GetObject("HomePageButton.BackgroundImage");
            HomePageButton.BackgroundImageLayout = ImageLayout.Center;
            HomePageButton.FlatAppearance.BorderSize = 0;
            HomePageButton.FlatStyle = FlatStyle.Flat;
            HomePageButton.Location = new Point(15, 5);
            HomePageButton.Name = "HomePageButton";
            HomePageButton.Size = new Size(40, 40);
            HomePageButton.TabIndex = 3;
            HomePageButton.UseVisualStyleBackColor = true;
            HomePageButton.Click += HomePageButton_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MenuPanel.BackColor = Color.Black;
            MenuPanel.Controls.Add(menuTableLayoutPanel);
            MenuPanel.Location = new Point(0, 50);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(900, 50);
            MenuPanel.TabIndex = 2;
            MenuPanel.Paint += MenuPanel_Paint;
            // 
            // menuTableLayoutPanel
            // 
            menuTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuTableLayoutPanel.ColumnCount = 8;
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            menuTableLayoutPanel.Controls.Add(UserButton, 7, 0);
            menuTableLayoutPanel.Controls.Add(RideButton, 6, 0);
            menuTableLayoutPanel.Controls.Add(CustomerButton, 5, 0);
            menuTableLayoutPanel.Controls.Add(ShiftButton, 4, 0);
            menuTableLayoutPanel.Controls.Add(DriverButton, 3, 0);
            menuTableLayoutPanel.Controls.Add(VehicleButton, 2, 0);
            menuTableLayoutPanel.Controls.Add(StationButton, 1, 0);
            menuTableLayoutPanel.Controls.Add(HomeButton, 0, 0);
            menuTableLayoutPanel.Location = new Point(0, 0);
            menuTableLayoutPanel.Name = "menuTableLayoutPanel";
            menuTableLayoutPanel.Padding = new Padding(24, 0, 24, 0);
            menuTableLayoutPanel.RowCount = 1;
            menuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuTableLayoutPanel.Size = new Size(900, 50);
            menuTableLayoutPanel.TabIndex = 0;
            // 
            // UserButton
            // 
            UserButton.Anchor = AnchorStyles.None;
            UserButton.AutoSize = true;
            UserButton.FlatAppearance.BorderSize = 0;
            UserButton.FlatStyle = FlatStyle.Flat;
            UserButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserButton.ForeColor = Color.FromArgb(230, 180, 0);
            UserButton.Location = new Point(769, 10);
            UserButton.Name = "UserButton";
            UserButton.Size = new Size(104, 30);
            UserButton.TabIndex = 6;
            UserButton.Text = "Kullanıcılar";
            UserButton.UseVisualStyleBackColor = true;
            UserButton.Click += UserButton_Click;
            UserButton.Leave += UserButton_Leave;
            // 
            // RideButton
            // 
            RideButton.Anchor = AnchorStyles.None;
            RideButton.AutoSize = true;
            RideButton.FlatAppearance.BorderSize = 0;
            RideButton.FlatStyle = FlatStyle.Flat;
            RideButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RideButton.ForeColor = Color.FromArgb(230, 180, 0);
            RideButton.Location = new Point(670, 10);
            RideButton.Name = "RideButton";
            RideButton.Size = new Size(86, 30);
            RideButton.TabIndex = 3;
            RideButton.Text = "Sürüşler";
            RideButton.UseVisualStyleBackColor = true;
            RideButton.Click += RideButton_Click;
            RideButton.Leave += RideButton_Leave;
            // 
            // CustomerButton
            // 
            CustomerButton.Anchor = AnchorStyles.None;
            CustomerButton.AutoSize = true;
            CustomerButton.FlatAppearance.BorderSize = 0;
            CustomerButton.FlatStyle = FlatStyle.Flat;
            CustomerButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerButton.ForeColor = Color.FromArgb(230, 180, 0);
            CustomerButton.Location = new Point(557, 10);
            CustomerButton.Name = "CustomerButton";
            CustomerButton.Size = new Size(99, 30);
            CustomerButton.TabIndex = 4;
            CustomerButton.Text = "Müşteriler";
            CustomerButton.UseVisualStyleBackColor = true;
            CustomerButton.Click += CustomerButton_Click;
            CustomerButton.Leave += CustomerButton_Leave;
            // 
            // ShiftButton
            // 
            ShiftButton.Anchor = AnchorStyles.None;
            ShiftButton.AutoSize = true;
            ShiftButton.FlatAppearance.BorderSize = 0;
            ShiftButton.FlatStyle = FlatStyle.Flat;
            ShiftButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShiftButton.ForeColor = Color.FromArgb(230, 180, 0);
            ShiftButton.Location = new Point(451, 10);
            ShiftButton.Name = "ShiftButton";
            ShiftButton.Size = new Size(99, 30);
            ShiftButton.TabIndex = 10;
            ShiftButton.Text = "Vardiyalar";
            ShiftButton.UseVisualStyleBackColor = true;
            ShiftButton.Click += ShiftButton_Click;
            ShiftButton.Leave += ShiftButton_Leave;
            // 
            // DriverButton
            // 
            DriverButton.Anchor = AnchorStyles.None;
            DriverButton.AutoSize = true;
            DriverButton.FlatAppearance.BorderSize = 0;
            DriverButton.FlatStyle = FlatStyle.Flat;
            DriverButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DriverButton.ForeColor = Color.FromArgb(230, 180, 0);
            DriverButton.Location = new Point(347, 10);
            DriverButton.Name = "DriverButton";
            DriverButton.Size = new Size(96, 30);
            DriverButton.TabIndex = 9;
            DriverButton.Text = "Sürücüler";
            DriverButton.UseVisualStyleBackColor = true;
            DriverButton.Click += DriverButton_Click;
            DriverButton.Leave += DriverButton_Leave;
            // 
            // VehicleButton
            // 
            VehicleButton.Anchor = AnchorStyles.None;
            VehicleButton.AutoSize = true;
            VehicleButton.FlatAppearance.BorderSize = 0;
            VehicleButton.FlatStyle = FlatStyle.Flat;
            VehicleButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleButton.ForeColor = Color.FromArgb(230, 180, 0);
            VehicleButton.Location = new Point(247, 10);
            VehicleButton.Name = "VehicleButton";
            VehicleButton.Size = new Size(84, 30);
            VehicleButton.TabIndex = 2;
            VehicleButton.Text = "Araçlar";
            VehicleButton.UseVisualStyleBackColor = true;
            VehicleButton.Click += VehicleButton_Click;
            VehicleButton.Leave += VehicleButton_Leave;
            // 
            // StationButton
            // 
            StationButton.Anchor = AnchorStyles.None;
            StationButton.AutoSize = true;
            StationButton.FlatAppearance.BorderSize = 0;
            StationButton.FlatStyle = FlatStyle.Flat;
            StationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StationButton.ForeColor = Color.FromArgb(230, 180, 0);
            StationButton.Location = new Point(149, 10);
            StationButton.Name = "StationButton";
            StationButton.Size = new Size(67, 30);
            StationButton.TabIndex = 1;
            StationButton.Text = "Durak";
            StationButton.UseVisualStyleBackColor = true;
            StationButton.Click += StationButton_Click;
            StationButton.Leave += StationButton_Leave;
            // 
            // HomeButton
            // 
            HomeButton.Anchor = AnchorStyles.None;
            HomeButton.AutoSize = true;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.FromArgb(230, 180, 0);
            HomeButton.Location = new Point(27, 10);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(100, 30);
            HomeButton.TabIndex = 8;
            HomeButton.Text = "Ana Sayfa";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            HomeButton.Leave += HomeButton_Leave;
            // 
            // ContainerPanel
            // 
            ContainerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContainerPanel.BackColor = Color.Transparent;
            ContainerPanel.Location = new Point(0, 100);
            ContainerPanel.MinimumSize = new Size(900, 470);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(900, 499);
            ContainerPanel.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 600);
            Controls.Add(ContainerPanel);
            Controls.Add(MenuPanel);
            Controls.Add(UserBarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(900, 600);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Main_Load;
            UserBarPanel.ResumeLayout(false);
            UserBarPanel.PerformLayout();
            MenuPanel.ResumeLayout(false);
            menuTableLayoutPanel.ResumeLayout(false);
            menuTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList IconList;
        private Panel UserBarPanel;
        private Panel MenuPanel;
        private Panel ContainerPanel;
        private Button CustomerButton;
        private Button RideButton;
        private Button VehicleButton;
        private Button StationButton;
        private Button HomeButton;
        private Button DriverButton;
        private Button ShiftButton;
        private Button ExitButton;
        private Button HomePageButton;
        public Button profileBtn;
        public Button UserButton;
        private TableLayoutPanel menuTableLayoutPanel;
    }
}