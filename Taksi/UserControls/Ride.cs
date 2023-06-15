using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class Ride : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        int id = 0;
        public Ride()
        {
            InitializeComponent();
            VeriListe();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            RidePanel.Controls.Clear();
            RidePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        void VeriListe()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");
            param.Add("@Kosul", "");
            param.Add("@tarih1", "");
            param.Add("@tarih2", "");
            List<RideTable> list = SqlCon.Query<RideTable>
                ("SurusArama", param, commandType: CommandType.StoredProcedure).ToList<RideTable>();
            RideDGV.DataSource = list;
            RideDGV.Columns[0].Visible = false;
            RideDGV.Columns[1].HeaderText = "Tarih";
            RideDGV.Columns[2].Visible = false; ;
            RideDGV.Columns[3].HeaderText = "Müşteri Ad";
            RideDGV.Columns[4].HeaderText = "Müşteri Soyad";
            RideDGV.Columns[5].HeaderText = "Telefon No";
            RideDGV.Columns[6].HeaderText = "Plaka";
            RideDGV.Columns[7].Visible = false;
            RideDGV.Columns[8].Visible = false;
            RideDGV.Columns[9].HeaderText = "Tutar";
            RideDGV.Columns[10].Visible = false;

        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            VeriListe();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddRide ar = new AddRide();
            AddUserControl(ar);
            ar.PhoneTxt.Enabled = true;
            ar.LicencePlateCB.Enabled = true;
            ar.label9.Text = "Yeni Sürüş";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddRide ar = new AddRide();
            AddUserControl(ar);
            ar.PhoneTxt.Enabled = false;
            ar.LicencePlateCB.Enabled = false;
            ar.label9.Text = "Sürüş Düzenle";
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                if (RideDGV.CurrentCell != null)
                {
                    int a = int.Parse(RideDGV.CurrentRow.Cells[0].Value.ToString());
                    SqlCommand Komut = new SqlCommand("select r.ride_id, cp.phone_number, v.vehicle_licence_plate, r.start_coordinate, r.end_coordinate, r.ride_distance, pt.payment_type_name, rp.price, rp.description from Ride r inner join Customer c on c.customer_id = r.customer_id inner join [Customer Phone] cp on cp.customer_id = c.customer_id inner join Vehicle v on v.vehicle_id = r.ride_vehicle_id inner join [Ride Payment] rp on rp.ride_id = r.ride_id left join [Payment Type] pt on pt.payment_type_id = rp.payment_type_id where r.ride_id =" + a, SqlCon);
                    SqlDataReader dr = Komut.ExecuteReader();
                    while (dr.Read())
                    {
                        ar.id = int.Parse(RideDGV.CurrentRow.Cells[0].Value.ToString());
                        ar.PhoneTxt.Text = dr[1].ToString();
                        ar.LicencePlateCB.SelectedItem = dr[2].ToString();
                        //ar.BeginPointTxt.Text = dr[3].ToString();
                        //ar.EndPointTxt.Text = dr[4].ToString();
                        ar.DistanceTxt.Text = dr[5].ToString();
                        ar.PaymentTypeCB.SelectedItem = dr[6].ToString();
                        ar.PriceTxt.Text = dr[7].ToString();
                        ar.descriptionTxt.Text = dr[8].ToString();
                    }
                    SqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
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
                    id = int.Parse(RideDGV.CurrentRow.Cells[0].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", id);
                    SqlCon.Execute("SurusSil", param, commandType: CommandType.StoredProcedure);
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
            Ride r = new Ride();
            AddUserControl(r);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            DynamicParameters param = new DynamicParameters();
            if (CPhoneRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Müşteri Telefonu");
                param.Add("@tarih1", BeginDTP.Value);
                param.Add("@tarih2", EndDTP.Value);
                List<RideTable> list = SqlCon.Query<RideTable>
                    ("SurusArama", param, commandType: CommandType.StoredProcedure).ToList<RideTable>();
                RideDGV.DataSource = list;
                RideDGV.Columns[0].Visible = false;
                RideDGV.Columns[1].HeaderText = "Tarih";
                RideDGV.Columns[2].Visible = false; ;
                RideDGV.Columns[3].HeaderText = "Müşteri Ad";
                RideDGV.Columns[4].HeaderText = "Müşteri Soyad";
                RideDGV.Columns[5].HeaderText = "Telefon No";
                RideDGV.Columns[6].HeaderText = "Plaka";
                RideDGV.Columns[7].HeaderText = "Sürücü Ad";
                RideDGV.Columns[8].HeaderText = "Sürücü Soyad";
                RideDGV.Columns[9].HeaderText = "Tutar";
                RideDGV.Columns[10].Visible = false;
            }
            else if (DriverNameRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Sürücü Adı");
                param.Add("@tarih1", BeginDTP.Value);
                param.Add("@tarih2", EndDTP.Value);
                List<RideTable> list = SqlCon.Query<RideTable>
                    ("SurusArama", param, commandType: CommandType.StoredProcedure).ToList<RideTable>();
                RideDGV.DataSource = list;
                RideDGV.Columns[0].Visible = false;
                RideDGV.Columns[1].HeaderText = "Tarih";
                RideDGV.Columns[2].Visible = false; ;
                RideDGV.Columns[3].HeaderText = "Müşteri Ad";
                RideDGV.Columns[4].HeaderText = "Müşteri Soyad";
                RideDGV.Columns[5].HeaderText = "Telefon No";
                RideDGV.Columns[6].HeaderText = "Plaka";
                RideDGV.Columns[7].HeaderText = "Sürücü Ad";
                RideDGV.Columns[8].HeaderText = "Sürücü Soyad";
                RideDGV.Columns[9].HeaderText = "Tutar";
                RideDGV.Columns[10].Visible = false;
            }
            else if (LicensePlateRB.Checked)
            {
                param.Add("@AramaMetni", SearchTxt.Text.Trim());
                param.Add("@Kosul", "Araç Plakası");
                param.Add("@tarih1", BeginDTP.Value);
                param.Add("@tarih2", EndDTP.Value);
                List<RideTable> list = SqlCon.Query<RideTable>
                    ("SurusArama", param, commandType: CommandType.StoredProcedure).ToList<RideTable>();
                RideDGV.DataSource = list;
                RideDGV.Columns[0].Visible = false;
                RideDGV.Columns[1].HeaderText = "Tarih";
                RideDGV.Columns[2].Visible = false; ;
                RideDGV.Columns[3].HeaderText = "Müşteri Ad";
                RideDGV.Columns[4].HeaderText = "Müşteri Soyad";
                RideDGV.Columns[5].HeaderText = "Telefon No";
                RideDGV.Columns[6].HeaderText = "Plaka";
                RideDGV.Columns[7].HeaderText = "Sürücü Ad";
                RideDGV.Columns[8].HeaderText = "Sürücü Soyad";
                RideDGV.Columns[9].HeaderText = "Tutar";
                RideDGV.Columns[10].Visible = false;
            }
        }
    }
}
