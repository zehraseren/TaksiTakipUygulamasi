using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class Driver : UserControl
    {
        public int driverid;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id = 0;
        public Driver()
        {
            InitializeComponent();
            VeriListe();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            DriverPanel.Controls.Clear();
            DriverPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddDriverButton_Click(object sender, EventArgs e)
        {
            AddDriver ad = new AddDriver();
            ad.label4.Text = "Yeni Sürücü";
            AddUserControl(ad);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                AddDriver ad = new AddDriver();
                ad.label4.Text = "Sürücü Düzenle";
                AddUserControl(ad);
                SqlCommand Komut = new SqlCommand("select d.driver_id, d.driver_id_number, d.driver_firstname, d.driver_lastname,dp.phone_number, s.shift_type_name, st.station_name, v.vehicle_licence_plate, da.province, da.district, da.address_line from Driver d inner join [Driver Phone] dp on dp.driver_id = d.driver_id inner join [Driver Address] da on da.driver_id = d.driver_id inner join Shift s on s.shift_id = d.driver_shift_id inner join Station st on st.station_id = d.driver_station_id inner join Vehicle v on v.vehicle_id = d.driver_vehicle_id where d.driver_id =" + int.Parse(DriverDGV.CurrentRow.Cells[0].Value.ToString()), SqlCon);
                SqlDataReader dr = Komut.ExecuteReader();
                while (dr.Read())
                {
                    ad.id = int.Parse(DriverDGV.CurrentRow.Cells[0].Value.ToString());
                    ad.IDNoTxt.Text = dr[1].ToString();
                    ad.FirstNameTxt.Text = dr[2].ToString();
                    ad.LastNameTxt.Text = dr[3].ToString();
                    ad.PhoneTxt.Text = dr[4].ToString();
                    ad.ShiftCB.SelectedItem = dr[5].ToString();
                    ad.StationCB.SelectedItem = dr[6].ToString();
                    ad.VehicleCB.SelectedItem = dr[7].ToString();
                    ad.CityCB.SelectedItem = dr[8].ToString();
                    ad.DistrictCB.SelectedItem = dr[9].ToString();
                    ad.AddressTxt.Text = dr[10].ToString();
                }

                SqlCon.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ShowExpenseButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            DriverExpense de = new DriverExpense();
            AddDriverExpense ade = new AddDriverExpense();
            AddUserControl(de);
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");
            driverid = int.Parse(DriverDGV.CurrentRow.Cells[0].Value.ToString());
            de.driverid = driverid;
            //ade.driverid = driverid;
            param.Add("@id", driverid);
            List<DriverExpenseTable> list = SqlCon.Query<DriverExpenseTable>
                ("SurucuGiderArama", param, commandType: CommandType.StoredProcedure).ToList<DriverExpenseTable>();
            de.DriverExpenseDGV.DataSource = list;
            de.DriverExpenseDGV.Columns[0].Visible = false;
            de.DriverExpenseDGV.Columns[1].HeaderText = "Ad";
            de.DriverExpenseDGV.Columns[2].HeaderText = "Soyad";
            de.DriverExpenseDGV.Columns[3].HeaderText = "TC Kimlik No";
            de.DriverExpenseDGV.Columns[4].HeaderText = "Tarih";
            de.DriverExpenseDGV.Columns[5].HeaderText = "Tutar";
            de.DriverExpenseDGV.Columns[6].HeaderText = "Gider Tipi";
            de.DriverExpenseDGV.Columns[7].HeaderText = "Ödeme Tipi";
        }

        void VeriListe()
        {

            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", SearchTxt.Text.Trim());         //trim boşluk silmek için
            param.Add("@Kosul", "");         //trim boşluk silmek için
            List<DriverTable> list = SqlCon.Query<DriverTable>
                ("SurucuArama", param, commandType: CommandType.StoredProcedure).ToList<DriverTable>();
            DriverDGV.DataSource = list;
            DriverDGV.Columns[0].Visible = false;
            DriverDGV.Columns[1].HeaderText = "TC Kimlik No";
            DriverDGV.Columns[2].HeaderText = "Ad";
            DriverDGV.Columns[3].HeaderText = "Soyad";
            DriverDGV.Columns[4].HeaderText = "Telefon";
            DriverDGV.Columns[5].HeaderText = "Vardiya";
            DriverDGV.Columns[6].HeaderText = "Durak Adı";
            DriverDGV.Columns[7].HeaderText = "Araç Plakası";
            DriverDGV.Columns[8].Visible = false;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            DynamicParameters param = new DynamicParameters();
            if (DPhoneRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Sürücü Telefon");
                List<DriverTable> list = SqlCon.Query<DriverTable>
                 ("SurucuArama", param, commandType: CommandType.StoredProcedure).ToList<DriverTable>();
                DriverDGV.DataSource = list;
                DriverDGV.Columns[0].Visible = false;
                DriverDGV.Columns[1].HeaderText = "TC Kimlik No";
                DriverDGV.Columns[2].HeaderText = "Ad";
                DriverDGV.Columns[3].HeaderText = "Soyad";
                DriverDGV.Columns[4].HeaderText = "Telefon";
                DriverDGV.Columns[5].HeaderText = "Vardiya";
                DriverDGV.Columns[6].HeaderText = "Durak Adı";
                DriverDGV.Columns[7].HeaderText = "Araç Plakası";
                DriverDGV.Columns[8].Visible = false;
            }
            else if (DriverNameRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Sürücü Ad");
                List<DriverTable> list = SqlCon.Query<DriverTable>
                 ("SurucuArama", param, commandType: CommandType.StoredProcedure).ToList<DriverTable>();
                DriverDGV.DataSource = list;
                DriverDGV.Columns[0].Visible = false;
                DriverDGV.Columns[1].HeaderText = "TC Kimlik No";
                DriverDGV.Columns[2].HeaderText = "Ad";
                DriverDGV.Columns[3].HeaderText = "Soyad";
                DriverDGV.Columns[4].HeaderText = "Telefon";
                DriverDGV.Columns[5].HeaderText = "Vardiya";
                DriverDGV.Columns[6].HeaderText = "Durak Adı";
                DriverDGV.Columns[7].HeaderText = "Araç Plakası";
                DriverDGV.Columns[8].Visible = false;
            }
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
                    id = int.Parse(DriverDGV.CurrentRow.Cells[0].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", id);

                    SqlCon.Execute("SurucuSil", param, commandType: CommandType.StoredProcedure);
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
            Driver d = new Driver();
            AddUserControl(d);
        }
    }
}
