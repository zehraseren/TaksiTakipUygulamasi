using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Taksi.UserControls;
using static Taksi.Classes.Tables;

//dapper, gmap, system.data.sql.client kütüphanelerini ekle

namespace Taksi
{
    public partial class Main : Form
    {
        public int u_id;
        public string role;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public Main()
        {
            InitializeComponent();
            Home mainpanel = new Home();
            AddUserControl(mainpanel);
        }

        #region Main Buttons

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion


        #region Other Buttons

        public void HomeButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            Home hm = new Home();
            AddUserControl(hm);

            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");         //trim boþluk silmek için
            List<VehicleTable> list = SqlCon.Query<VehicleTable>
                ("SirasizArac", param, commandType: CommandType.StoredProcedure).ToList<VehicleTable>();
            hm.dataGridView2.DataSource = list;
            hm.dataGridView2.Columns[0].Visible = false;
            hm.dataGridView2.Columns[1].Visible = false;
            hm.dataGridView2.Columns[2].HeaderText = "Araç Plaka";
            hm.dataGridView2.Columns[3].Visible = false;
            hm.dataGridView2.Columns[4].Visible = false;
            hm.dataGridView2.Columns[5].Visible = false;
            hm.dataGridView2.Columns[6].Visible = false;
            hm.dataGridView2.Columns[7].Visible = false;
            hm.dataGridView2.Columns[8].Visible = false;

            SqlCon.Close();
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            param.Add("@AramaMetni", "");
            list = SqlCon.Query<VehicleTable>
                ("SiraliArac", param, commandType: CommandType.StoredProcedure).ToList<VehicleTable>();
            hm.dataGridView1.DataSource = list;
            hm.dataGridView1.Columns[0].Visible = false;
            hm.dataGridView1.Columns[1].HeaderText = "Sýra";
            hm.dataGridView1.Columns[2].HeaderText = "Araç Plaka";
            hm.dataGridView1.Columns[3].Visible = false;
            hm.dataGridView1.Columns[4].Visible = false;
            hm.dataGridView1.Columns[5].Visible = false;
            hm.dataGridView1.Columns[6].Visible = false;
            hm.dataGridView1.Columns[7].Visible = false;
            hm.dataGridView1.Columns[8].Visible = false;

            SqlCon.Close();
        }

        private void HomeButton_Leave(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.Transparent;
        }

        private void StationButton_Click(object sender, EventArgs e)
        {
            Station mainpanel = new Station();
            AddUserControl(mainpanel);
            StationButton.BackColor = Color.FromArgb(50, Color.White);
        }

        private void StationButton_Leave(object sender, EventArgs e)
        {
            StationButton.BackColor = Color.Transparent;
        }

        private void VehicleButton_Click(object sender, EventArgs e)
        {
            Vehicle mainpanel = new Vehicle();
            AddUserControl(mainpanel);
            VehicleButton.BackColor = Color.FromArgb(50, Color.White);
        }

        private void VehicleButton_Leave(object sender, EventArgs e)
        {
            VehicleButton.BackColor = Color.Transparent;
        }

        private void DriverButton_Click(object sender, EventArgs e)
        {
            Driver mainpanel = new Driver();
            AddUserControl(mainpanel);
            DriverButton.BackColor = Color.FromArgb(50, Color.White);
        }

        private void DriverButton_Leave(object sender, EventArgs e)
        {
            DriverButton.BackColor = Color.Transparent;
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            Shift mainpanel = new Shift();
            AddUserControl(mainpanel);
            ShiftButton.BackColor = Color.FromArgb(50, Color.White);
        }
        private void ShiftButton_Leave(object sender, EventArgs e)
        {
            ShiftButton.BackColor = Color.Transparent;
        }

        private void RideButton_Click(object sender, EventArgs e)
        {
            Ride mainpanel = new Ride();
            AddUserControl(mainpanel);
            RideButton.BackColor = Color.FromArgb(50, Color.White);
        }

        private void RideButton_Leave(object sender, EventArgs e)
        {
            RideButton.BackColor = Color.Transparent;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Customer mainpanel = new Customer();
            AddUserControl(mainpanel);
            CustomerButton.BackColor = Color.FromArgb(50, Color.White);
        }

        private void CustomerButton_Leave(object sender, EventArgs e)
        {
            CustomerButton.BackColor = Color.Transparent;
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            User mainpanel = new User();
            AddUserControl(mainpanel);
            UserButton.BackColor = Color.FromArgb(50, Color.White);
        }

        private void UserButton_Leave(object sender, EventArgs e)
        {
            UserButton.BackColor = Color.Transparent;
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            Home mainpnanel = new Home();
            AddUserControl(mainpnanel);
        }

        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            this.Hide();
            lg.Show();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            UserPanel up = new UserPanel();
            AddUserControl(up);
            up.TurnBackButton.Visible = false;
            up.label8.Text = "Profil";
            up.cancelBtnHome.Visible = true;
            up.label1.Visible = false;
            up.StatusCB.Visible = false;
            if (role != "admin")
            {
                up.userTxt.Enabled = false;
                up.UserRoleCB.Enabled = false;
            }
            SqlCommand Komut = new SqlCommand("select u.user_id, u.username, u.password, u.user_firstname, u.user_lastname, up.phone_number, ur.user_role_name, u.user_status, u.user_delete from User_ u inner join [User Role] ur on ur.user_role_id = u.user_role_id inner join [User Phone] up on up.user_id = u.user_id where u.user_id =" + u_id, SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                up.id = u_id;
                up.userTxt.Text = dr[1].ToString();
                up.PasswordTxt.Text = dr[2].ToString();
                up.FirstNameTxt.Text = dr[3].ToString();
                up.LastNameTxt.Text = dr[4].ToString();
                up.PhoneTxt.Text = dr[5].ToString();
                up.UserRoleCB.SelectedItem = dr[6].ToString();
                up.StatusCB.SelectedItem = dr[7].ToString();
            }
            SqlCon.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AdjustMenuTableLayoutPanel();
            ArrangeMenuButtons();
        }

        private void ArrangeMenuButtons()
        {
            // Sadece Visible = true olan butonlarý alýn ve sýralý bir liste oluþturun
            List<Button> visibleButtons = new List<Button>();
            foreach (Control control in menuTableLayoutPanel.Controls)
            {
                if (control is Button button && button.Visible)
                {
                    visibleButtons.Add(button);
                }
            }

            // Butonlarý sýralamaya göre ters þekilde hücrelere yerleþtirin
            menuTableLayoutPanel.ColumnCount = visibleButtons.Count;
            int columnIndex = visibleButtons.Count - 1;
            foreach (Button button in visibleButtons)
            {
                menuTableLayoutPanel.Controls.Add(button, columnIndex, 0);
                columnIndex--;
            }

            // Butonlarýn ortalanmýþ olmasýný saðlayýn
            foreach (ColumnStyle columnStyle in menuTableLayoutPanel.ColumnStyles)
            {
                columnStyle.SizeType = SizeType.Percent;
                columnStyle.Width = 100f / visibleButtons.Count;
            }
        }

        private void AdjustMenuTableLayoutPanel()
        {
            // Normal panelin boyutunu alýn
            int panelWidth = MenuPanel.Width;
            int panelHeight = MenuPanel.Height;

            // MenuTableLayoutPanel'in boyutunu ayarlayýn
            menuTableLayoutPanel.Width = panelWidth;
            menuTableLayoutPanel.Height = panelHeight;

            // MenuTableLayoutPanel'i ortala
            menuTableLayoutPanel.Left = (MenuPanel.Width - menuTableLayoutPanel.Width) / 2;
            menuTableLayoutPanel.Top = (MenuPanel.Height - menuTableLayoutPanel.Height) / 2;
        }





    }
}