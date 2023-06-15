using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class Home : UserControl
    {
        int id;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public Home()
        {
            InitializeComponent();

        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomePanel.Controls.Clear();
            HomePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private bool IsNumeric(string text)
        {
            return text.All(c => char.IsDigit(c));
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            //Telefon numarası girilen müşterinin bilgilerini getirme.
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            // Telefon alanı validasyonu
            if (string.IsNullOrWhiteSpace(SearchTxt.Text) || !IsNumeric(SearchTxt.Text) || SearchTxt.Text.Length != 11)
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz (yalnızca 11 rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddCustomer ad = new AddCustomer();
            string searchphone = SearchTxt.Text.Trim();
            ad.PhoneTxt.Text = searchphone;

            AddUserControl(ad);
            ad.RideButton.Visible = true;
            ad.SaveButton.Visible = false;

            ad.CancelButton.Visible = false;
            ad.GoToHomeButton.Visible = true;

            SqlCommand Komut = new SqlCommand("Select c.customer_id, c.customer_firstname, c.customer_lastname, cp.phone_number, ca.province, ca.district, ca.address_line, c.customer_delete from Customer c inner join [Customer Phone] cp on cp.customer_id = c.customer_id inner join [Customer Address] ca on ca.customer_id = c.customer_id where c.customer_delete = 0 and cp.phone_number ='" + searchphone + "'", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                ad.id = int.Parse(dr[0].ToString());
                ad.FirstNameTxt.Text = dr[1].ToString();
                ad.LastNameTxt.Text = dr[2].ToString();
                //ad.PhoneTxt.Text = dr[3].ToString();
                ad.CityCB.SelectedItem = dr[4].ToString();
                ad.DistrictCB.SelectedItem = dr[5].ToString();
                ad.AddressTxt.Text = dr[6].ToString();
            }

            SqlCon.Close();
        }

        //sıraya araç ekleme
        private void addlistBtn_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();

            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            //sırasız listede araç varsa
            if (dataGridView2.CurrentCell != null)
            {
                //sıralı listede araç varsa
                if (dataGridView1.CurrentCell != null)
                {
                    id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    SqlCommand Komut = new SqlCommand("select max(vehicle_priority) from Vehicle where vehicle_delete = 0", SqlCon);
                    int a = Convert.ToInt32(Komut.ExecuteScalar());
                    param.Add("@oncelik", a);
                    param.Add("@id", id);
                    SqlCon.Execute("SirayaEkle", param, commandType: CommandType.StoredProcedure);
                    //toolStripStatusLabel1.Visible = true;
                    //toolStripStatusLabel1.Text = "Silindi!";                        
                }
                //sıralı listede araç yoksa
                else
                {
                    SqlCommand Komut1 = new SqlCommand("select c.customer_id, c.customer_priority, cp.phone_number from Customer c inner join [Customer Phone] cp on cp.customer_id = c.customer_id where customer_priority = 1", SqlCon);
                    SqlDataReader dr1 = Komut1.ExecuteReader();
                    //bekleyen müşteri varsa
                    if (dr1.Read())
                    {
                        int cid = int.Parse(dr1[0].ToString());
                        string phone = dr1[2].ToString();
                        int cprio = int.Parse(dr1[1].ToString());
                        int vid = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                        string plate = dataGridView2.CurrentRow.Cells[2].Value.ToString();

                        DynamicParameters param3 = new DynamicParameters();
                        //string mesafeStr = "0";
                        param3.Add("@id", 0);
                        param3.Add("@telefon", phone);
                        param3.Add("@plaka", plate);
                        param3.Add("@mesafe", Convert.ToDecimal("0"));
                        param3.Add("@odeme_tip", "");
                        param3.Add("@tutar", 0);
                        param3.Add("@aciklama", "");
                        param3.Add("@sil", false);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlCon.Execute("SurusEkleveDuzenle", param3, commandType: CommandType.StoredProcedure);

                        DynamicParameters param1 = new DynamicParameters();
                        param1.Add("@id", cid);
                        param1.Add("@sira", cprio);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlCon.Execute("MusteriSiradanCikar", param1, commandType: CommandType.StoredProcedure);
                        MessageBox.Show("Araç bekleyen müşteriye atandı!");
                        //toolStripStatusLabel1.Visible = true;
                        //toolStripStatusLabel1.Text = "Silindi!";


                    }
                    //bekleyen müşteri yoksa
                    else
                    {
                        id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                        param.Add("@oncelik", 0);
                        param.Add("@id", id);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlCon.Execute("SirayaEkle", param, commandType: CommandType.StoredProcedure);
                        //toolStripStatusLabel1.Visible = true;
                        //toolStripStatusLabel1.Text = "Silindi!";
                    }
                }
            }
            SqlCon.Close();

            Home hm = new Home();
            AddUserControl(hm);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat, lon;
            lat = 41.025742;
            lon = 28.974201;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.Zoom = 13;
            GMapOverlay o = new GMapOverlay("o");
            GMapMarker m = new GMarkerGoogle(new PointLatLng(lat, lon), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);

            gMapControl1.Overlays.Add(o);
            o.Markers.Add(m);
            gMapControl1.Invalidate();
            gMapControl1.Update();
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");         //trim boşluk silmek için
            List<VehicleTable> list = SqlCon.Query<VehicleTable>
                ("SirasizArac", param, commandType: CommandType.StoredProcedure).ToList<VehicleTable>();
            dataGridView2.DataSource = list;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].HeaderText = "Araç Plaka";
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;

            SqlCon.Close();
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            param.Add("@AramaMetni", "");
            list = SqlCon.Query<VehicleTable>
                ("SiraliArac", param, commandType: CommandType.StoredProcedure).ToList<VehicleTable>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Sıra";
            dataGridView1.Columns[2].HeaderText = "Araç Plaka";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            SqlCon.Close();

            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            param.Add("@AramaMetni", "");
            List<CustomerTable> list1 = SqlCon.Query<CustomerTable>
                ("SiraliMusteri", param, commandType: CommandType.StoredProcedure).ToList<CustomerTable>();
            CallPastDGV.DataSource = list1;
            CallPastDGV.Columns[0].Visible = false;
            CallPastDGV.Columns[1].HeaderText = "Sıra";
            CallPastDGV.Columns[2].Visible = false;
            CallPastDGV.Columns[3].Visible = false;
            CallPastDGV.Columns[4].HeaderText = "Telefon Numarası";
            CallPastDGV.Columns[5].Visible = false;

            SqlCon.Close();
        }

        private void removelistBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                if (dataGridView1.CurrentCell != null)
                {
                    int a = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int b = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", a);
                    param.Add("@sira", b);

                    SqlCon.Execute("SiradanCikar", param, commandType: CommandType.StoredProcedure);
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
            Home hm = new Home();
            AddUserControl(hm);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void removeCusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                if (CallPastDGV.CurrentCell != null)
                {
                    int a = Convert.ToInt32(CallPastDGV.CurrentRow.Cells[0].Value.ToString());
                    int b = Convert.ToInt32(CallPastDGV.CurrentRow.Cells[1].Value.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", a);
                    param.Add("@sira", b);

                    SqlCon.Execute("MusteriSiradanCikar", param, commandType: CommandType.StoredProcedure);
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
            Home hm = new Home();
            AddUserControl(hm);

        }
    }
}
