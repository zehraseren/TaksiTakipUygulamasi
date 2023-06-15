using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Configuration;
using Dapper;

namespace Taksi.UserControls
{
    public partial class AddRide : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id = 0;
        public AddRide()
        {
            InitializeComponent();
            addLicencePlate();
            addPaymentType();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddRidePanel.Controls.Clear();
            AddRidePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addLicencePlate()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select vehicle_licence_plate from Vehicle", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                LicencePlateCB.Items.Add(dr[0]);
            }

            SqlCon.Close();
        }

        private void addPaymentType()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select payment_type_name from [Payment Type]", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                PaymentTypeCB.Items.Add(dr[0]);
            }

            SqlCon.Close();
        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Ride rd = new Ride();
            AddUserControl(rd);
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Ride rd = new Ride();
            AddUserControl(rd);
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            string mesafeStr = DistanceTxt.Text.Trim();
            if (mesafeStr == "")
                mesafeStr = "0";
            param.Add("@id", id);
            param.Add("@telefon", PhoneTxt.Text.Trim());
            param.Add("@plaka", LicencePlateCB.SelectedItem);
            param.Add("@mesafe", Convert.ToDecimal(mesafeStr));
            param.Add("@odeme_tip", PaymentTypeCB.SelectedItem);
            param.Add("@tutar", PriceTxt.Text.Trim());
            param.Add("@aciklama", descriptionTxt.Text.Trim());
            param.Add("@sil", false);

            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                SqlCon.Execute("SurusEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
                //toolStripStatusLabel1.Visible = true;
                //if (id == 0)
                //    toolStripStatusLabel1.Text = "Kaydedildi!";
                //else
                //    toolStripStatusLabel1.Text = "Güncellendi!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Veritabanı hatası");
            }
            finally
            {
                SqlCon.Close();
            }
            Ride rd = new Ride();
            AddUserControl(rd);
        }
    }
}
