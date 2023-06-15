using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Taksi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string connectionString = "TaxiConnection";
            string username = UsernameTxt.Text.Trim();
            string password = PasswordTxt.Text.Trim();
            string firstName, lastName, role;
            int u_id;

            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings[connectionString]);

            connection.Open();

            SqlCommand command = new SqlCommand("LoginKontrol", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("@User_id", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Role", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            firstName = command.Parameters["@FirstName"].Value.ToString();
            lastName = command.Parameters["@LastName"].Value.ToString();
            

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Giriş başarılı !");
                u_id = int.Parse(command.Parameters["@User_id"].Value.ToString());
                role = command.Parameters["@Role"].Value.ToString();
                Main ana = new Main();
                ana.profileBtn.Text = firstName + " " + lastName;
                ana.u_id = u_id;
                ana.role = role;
                if (role != "admin")
                {
                    ana.UserButton.Visible = false;
                }
                this.Hide();
                ana.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış.");
                UsernameTxt.Clear();
                PasswordTxt.Clear();
                UsernameTxt.Select();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, Color.White);
        }
    }
}
