using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class Customer : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        int id = 0;
        public Customer()
        {
            InitializeComponent();
            VeriListe();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            CustomerPanel.Controls.Clear();
            CustomerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer ad = new AddCustomer();
            AddUserControl(ad);
            ad.RideButton.Visible = false;
            ad.SaveButton.Visible = true;
            ad.CancelButton.Visible = true;
            ad.GoToHomeButton.Visible = false;
            ad.label1.Text = "Yeni Müşteri";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            AddCustomer ad = new AddCustomer();
            AddUserControl(ad);
            ad.RideButton.Visible = false;
            ad.SaveButton.Visible = true;
            ad.label1.Text = "Müşteri Düzenle";
            SqlCommand Komut = new SqlCommand("Select c.customer_id, c.customer_firstname, c.customer_lastname, cp.phone_number, ca.province, ca.district, ca.address_line, c.customer_delete from Customer c inner join [Customer Phone] cp on cp.customer_id = c.customer_id inner join [Customer Address] ca on ca.customer_id = c.customer_id where c.customer_id =" + int.Parse(CustomerDGV.CurrentRow.Cells[0].Value.ToString()), SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                ad.id = int.Parse(CustomerDGV.CurrentRow.Cells[0].Value.ToString());
                ad.FirstNameTxt.Text = dr[1].ToString();
                ad.LastNameTxt.Text = dr[2].ToString();
                ad.PhoneTxt.Text = dr[3].ToString();
                ad.CityCB.SelectedItem = dr[4].ToString();
                ad.DistrictCB.SelectedItem = dr[5].ToString();
                ad.AddressTxt.Text = dr[6].ToString();
            }

            SqlCon.Close();
        }
        void VeriListe()
        {

            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");
            param.Add("@Kosul", "");
            List<CustomerTable> list = SqlCon.Query<CustomerTable>
                ("MusteriArama", param, commandType: CommandType.StoredProcedure).ToList<CustomerTable>();
            CustomerDGV.DataSource = list;
            CustomerDGV.Columns[0].Visible = false;
            CustomerDGV.Columns[1].Visible = false;
            CustomerDGV.Columns[2].HeaderText = "Müşterinin Adı";
            CustomerDGV.Columns[3].HeaderText = "Müşterinin Soyadı";
            CustomerDGV.Columns[4].HeaderText = "Telefon Numarası";
            CustomerDGV.Columns[5].Visible = false;

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz.", "Uyarı!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    id = int.Parse(CustomerDGV.CurrentRow.Cells[0].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", id);

                    SqlCon.Execute("MusteriSil", param, commandType: CommandType.StoredProcedure);
                    //toolStripStatusLabel1.Visible = true;
                    //toolStripStatusLabel1.Text = "Silindi!";
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
            Customer cus = new Customer();
            AddUserControl(cus);
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            DynamicParameters param = new DynamicParameters();
            if (CPhoneRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Telefon");
                List<CustomerTable> list = SqlCon.Query<CustomerTable>
                    ("MusteriArama", param, commandType: CommandType.StoredProcedure).ToList<CustomerTable>();
                CustomerDGV.DataSource = list;
                CustomerDGV.Columns[0].Visible = false;
                CustomerDGV.Columns[1].Visible = false;
                CustomerDGV.Columns[2].HeaderText = "Müşterinin Adı";
                CustomerDGV.Columns[3].HeaderText = "Müşterinin Soyadı";
                CustomerDGV.Columns[4].HeaderText = "Telefon Numarası";
                CustomerDGV.Columns[5].Visible = false;
            }
            else if (CustomerNameRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Müşteri Adı");
                List<CustomerTable> list = SqlCon.Query<CustomerTable>
                    ("MusteriArama", param, commandType: CommandType.StoredProcedure).ToList<CustomerTable>();
                CustomerDGV.DataSource = list;
                CustomerDGV.Columns[0].Visible = false;
                CustomerDGV.Columns[1].Visible = false;
                CustomerDGV.Columns[2].HeaderText = "Müşterinin Adı";
                CustomerDGV.Columns[3].HeaderText = "Müşterinin Soyadı";
                CustomerDGV.Columns[4].HeaderText = "Telefon Numarası";
                CustomerDGV.Columns[5].Visible = false;
            }
        }
    }
}
