using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class User : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id = 0;

        public User()
        {
            InitializeComponent();
            VeriListe();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UserPanel.Controls.Clear();
            UserPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void VeriListe()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", SearchTxt.Text.Trim());
            param.Add("@Kosul", "");
            List<UserTable> list = SqlCon.Query<UserTable>
                ("KullaniciArama", param, commandType: CommandType.StoredProcedure).ToList<UserTable>();
            UserDGV.DataSource = list;
            UserDGV.Columns[0].Visible = false;
            UserDGV.Columns[1].HeaderText = "Kullanıcı Adı";
            UserDGV.Columns[2].HeaderText = "Şifre";
            UserDGV.Columns[3].HeaderText = "Adı";
            UserDGV.Columns[4].HeaderText = "Soyadı";
            UserDGV.Columns[5].HeaderText = "Telefon";
            UserDGV.Columns[6].HeaderText = "Rol";
            UserDGV.Columns[7].HeaderText = "Durum";
            UserDGV.Columns[8].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserPanel au = new UserPanel();
            AddUserControl(au);
            au.label8.Text = "Yeni Kullanıcı";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            UserPanel au = new UserPanel();
            AddUserControl(au);
            au.label8.Text = "Kullanıcı Düzenle";
            SqlCommand Komut = new SqlCommand("select u.user_id, u.username, u.password, u.user_firstname, u.user_lastname, up.phone_number, ur.user_role_name, u.user_status, u.user_delete from User_ u inner join [User Role] ur on ur.user_role_id = u.user_role_id inner join [User Phone] up on up.user_id = u.user_id where u.user_id =" + int.Parse(UserDGV.CurrentRow.Cells[0].Value.ToString()), SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                au.id = int.Parse(UserDGV.CurrentRow.Cells[0].Value.ToString());
                au.userTxt.Text = dr[1].ToString();
                au.PasswordTxt.Text = dr[2].ToString();
                au.FirstNameTxt.Text = dr[3].ToString();
                au.LastNameTxt.Text = dr[4].ToString();
                au.PhoneTxt.Text = dr[5].ToString();
                au.UserRoleCB.SelectedItem = dr[6].ToString();
                au.StatusCB.SelectedItem = dr[7].ToString();
            }
            SqlCon.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    id = int.Parse(UserDGV.CurrentRow.Cells[0].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", id);
                    SqlCon.Execute("KullaniciSil", param, commandType: CommandType.StoredProcedure);
                    UserStatus.Visible = true;
                    UserStatus.Text = "Silindi.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlCon.Close();
            }
            User u = new User();
            AddUserControl(u);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            DynamicParameters param = new DynamicParameters();
            if (UsernameRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Kadi");
                List<UserTable> list = SqlCon.Query<UserTable>
                ("KullaniciArama", param, commandType: CommandType.StoredProcedure).ToList<UserTable>();
                UserDGV.DataSource = list;
                UserDGV.Columns[0].Visible = false;
                UserDGV.Columns[1].HeaderText = "Kullanıcı Adı";
                UserDGV.Columns[2].HeaderText = "Şifre";
                UserDGV.Columns[3].HeaderText = "Adı";
                UserDGV.Columns[4].HeaderText = "Soyadı";
                UserDGV.Columns[5].HeaderText = "Telefon";
                UserDGV.Columns[6].HeaderText = "Rol";
                UserDGV.Columns[7].HeaderText = "Durum";
                UserDGV.Columns[8].Visible = false;
            }
            else if (UPhoneRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Ktelefon");
                List<UserTable> list = SqlCon.Query<UserTable>
                ("KullaniciArama", param, commandType: CommandType.StoredProcedure).ToList<UserTable>();
                UserDGV.DataSource = list;
                UserDGV.Columns[0].Visible = false;
                UserDGV.Columns[1].HeaderText = "Kullanıcı Adı";
                UserDGV.Columns[2].HeaderText = "Şifre";
                UserDGV.Columns[3].HeaderText = "Adı";
                UserDGV.Columns[4].HeaderText = "Soyadı";
                UserDGV.Columns[5].HeaderText = "Telefon";
                UserDGV.Columns[6].HeaderText = "Rol";
                UserDGV.Columns[7].HeaderText = "Durum";
                UserDGV.Columns[8].Visible = false;
            }
        }
    }
}
