namespace Taksi.UserControls
{
    partial class StationMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMap));
            panel1 = new Panel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            TurnBackBtn = new Button();
            StationMapPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(gMapControl1);
            panel1.Location = new Point(20, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 575);
            panel1.TabIndex = 0;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(0, 0);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 35;
            gMapControl1.MinZoom = 19;
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
            gMapControl1.Size = new Size(860, 575);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // TurnBackBtn
            // 
            TurnBackBtn.BackgroundImage = (Image)resources.GetObject("TurnBackBtn.BackgroundImage");
            TurnBackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            TurnBackBtn.FlatAppearance.BorderSize = 0;
            TurnBackBtn.FlatStyle = FlatStyle.Flat;
            TurnBackBtn.ForeColor = Color.White;
            TurnBackBtn.ImageKey = "Left.png";
            TurnBackBtn.Location = new Point(50, 20);
            TurnBackBtn.Name = "TurnBackBtn";
            TurnBackBtn.Size = new Size(30, 30);
            TurnBackBtn.TabIndex = 1;
            TurnBackBtn.Tag = "";
            TurnBackBtn.UseVisualStyleBackColor = true;
            TurnBackBtn.Visible = false;
            TurnBackBtn.Click += TurnBackBtn_Click;
            // 
            // StationMapPanel
            // 
            StationMapPanel.BackColor = Color.Transparent;
            StationMapPanel.Dock = DockStyle.Fill;
            StationMapPanel.Location = new Point(0, 0);
            StationMapPanel.Name = "StationMapPanel";
            StationMapPanel.Size = new Size(900, 660);
            StationMapPanel.TabIndex = 2;
            // 
            // StationMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(TurnBackBtn);
            Controls.Add(panel1);
            Controls.Add(StationMapPanel);
            Name = "StationMap";
            Size = new Size(900, 660);
            Load += StationMap_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Button TurnBackBtn;
        private Panel StationMapPanel;
    }
}
