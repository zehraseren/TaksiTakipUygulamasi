using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class Vehicle : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id = 0;
        public Vehicle()
        {
            InitializeComponent();
            VeriListe();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            VehiclePanel.Controls.Clear();
            VehiclePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        void VeriListe()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", LicensePlateTxt.Text.Trim());         //trim boşluk silmek için
            List<VehicleTable> list = SqlCon.Query<VehicleTable>
                ("AracArama", param, commandType: CommandType.StoredProcedure).ToList<VehicleTable>();
            VehicleDGV.DataSource = list;
            VehicleDGV.Columns[0].Visible = false;
            VehicleDGV.Columns[1].Visible = false;
            VehicleDGV.Columns[2].HeaderText = "Plaka";
            VehicleDGV.Columns[3].HeaderText = "Marka";
            VehicleDGV.Columns[4].HeaderText = "Model";
            VehicleDGV.Columns[5].HeaderText = "Yıl";
            VehicleDGV.Columns[6].Visible = false;
            VehicleDGV.Columns[7].HeaderText = "Durak";
            VehicleDGV.Columns[8].Visible = false;
            SqlCon.Close();
        }

        private void ShowExpenceButton_Click(object sender, EventArgs e)
        {
            VehicleExpense ve = new VehicleExpense();
            AddUserControl(ve);
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle av = new AddVehicle();
            av.label4.Text = "Yeni Araç";
            AddUserControl(av);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            VeriListe();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                AddVehicle av = new AddVehicle();
                av.label4.Text = "Araç Düzenle";
                AddUserControl(av);
                SqlCommand Komut = new SqlCommand("select v.vehicle_id, v.vehicle_licence_plate, v.vehicle_coordinate, v.vehicle_brand, v.vehicle_model, v.vehicle_year, s.station_name from Vehicle v inner join Station s on s.station_id = v.vehicle_station_id where v.vehicle_id =" + int.Parse(VehicleDGV.CurrentRow.Cells[0].Value.ToString()), SqlCon);
                SqlDataReader dr = Komut.ExecuteReader();
                while (dr.Read())
                {
                    av.id = int.Parse(VehicleDGV.CurrentRow.Cells[0].Value.ToString());
                    av.LicencePlateTxt.Text = dr[1].ToString();
                    av.LocationTxt.Text = dr[2].ToString();
                    av.BrandTxt.Text = dr[3].ToString();
                    av.ModelTxt.Text = dr[4].ToString();
                    av.YearTxt.Text = dr[5].ToString();
                    av.SelectStationCB.SelectedItem = dr[6].ToString();
                }
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    id = int.Parse(VehicleDGV.CurrentRow.Cells[0].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", id);

                    SqlCon.Execute("AracSil", param, commandType: CommandType.StoredProcedure);
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
            Vehicle vh = new Vehicle();
            AddUserControl(vh);
        }

        private void ShowInMapButton_Click(object sender, EventArgs e)
        {
            //Ride rd = new Ride();
            //AddUserControl(rd);
        }
    }
}
