namespace Taksi
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            EnterButton = new Button();
            PasswordTxt = new TextBox();
            UsernameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            IconList = new ImageList(components);
            LoginPanel = new Panel();
            panel1.SuspendLayout();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(EnterButton);
            panel1.Controls.Add(PasswordTxt);
            panel1.Controls.Add(UsernameTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(237, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 204);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.FromArgb(0, 98, 3);
            EnterButton.BackgroundImageLayout = ImageLayout.Stretch;
            EnterButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EnterButton.ForeColor = Color.White;
            EnterButton.Location = new Point(187, 125);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(120, 39);
            EnterButton.TabIndex = 4;
            EnterButton.Text = "GİRİŞ";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(187, 53);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(120, 29);
            PasswordTxt.TabIndex = 3;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameTxt.Location = new Point(187, 17);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(120, 29);
            UsernameTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 1;
            label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(157, 24);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI:";
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
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.Transparent;
            LoginPanel.Controls.Add(panel1);
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(800, 450);
            LoginPanel.TabIndex = 1;
            // 
            // Login
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taksi Takip";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            LoginPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button EnterButton;
        private TextBox PasswordTxt;
        private TextBox UsernameTxt;
        private Label label2;
        private Label label1;
        private ImageList IconList;
        private Panel LoginPanel;
    }
}