using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Taksi.UserControls
{
    public partial class AddCustomer : UserControl
    {
        //customer dan gelen id'yi tutmak için değişken tanımlandı
        public int id;
        //sql bağlantısı yapıldı
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public AddCustomer()
        {
            InitializeComponent();
            //CityCB combobox'ına sayfa açılır açılmaz tüm şehirler getirildi
            addProvince();
            SqlCon.Close();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddCustomerPanel.Controls.Clear();
            AddCustomerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //veritabanındaki Provinces tablosundan tüm şehirler CityCB comboboxına getirildi
        private void addProvince()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select * from Provinces", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                CityCB.Items.Add(dr[1]);
            }

            SqlCon.Close();
        }

        //Müşteriler sayfasına dönme butonu
        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            AddUserControl(cus);
        }
        //Müşteriler sayfasına dönme butonu
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            AddUserControl(cus);
        }

        private bool IsAlpha(string text)
        {
            return text.All(c => char.IsLetter(c));
        }

        // Metin içinde sadece rakamların olup olmadığını kontrol eden yardımcı fonksiyon
        private bool IsNumeric(string text)
        {
            return text.All(c => char.IsDigit(c));
        }

        //vazgeç butonu(anasayfa)
        private void GoToHomeButton_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            AddUserControl(hm);
        }
        //Kaydet butonu
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                #region validation
                // Ad alanı validasyonu
                if (string.IsNullOrWhiteSpace(FirstNameTxt.Text) || !IsAlpha(FirstNameTxt.Text))
                {
                    MessageBox.Show("Geçerli bir ad giriniz (yalnızca harflerden oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Soyad alanı validasyonu
                if (string.IsNullOrWhiteSpace(LastNameTxt.Text) || !IsAlpha(LastNameTxt.Text))
                {
                    MessageBox.Show("Geçerli bir soyad giriniz (yalnızca harflerden oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Telefon alanı validasyonu
                if (string.IsNullOrWhiteSpace(PhoneTxt.Text) || !IsNumeric(PhoneTxt.Text) || PhoneTxt.Text.Length != 11)
                {
                    MessageBox.Show("Geçerli bir telefon numarası giriniz (yalnızca 11 rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Şehir combobox validasyonu
                if (CityCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir şehir seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // İlçe combobox validasyonu
                if (DistrictCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir ilçe seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Adres alanı validasyonu
                if (string.IsNullOrWhiteSpace(AddressTxt.Text))
                {
                    MessageBox.Show("Adres boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion                

                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                param.Add("@adi", FirstNameTxt.Text.Trim());
                param.Add("@soyadi", LastNameTxt.Text.Trim());
                param.Add("@telefon", PhoneTxt.Text.Trim());
                param.Add("@sehir", CityCB.SelectedItem.ToString());
                param.Add("@ilce", DistrictCB.SelectedItem.ToString());
                param.Add("@adres", AddressTxt.Text.Trim());
                param.Add("@sil", false);
                SqlCon.Execute("MusteriEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Kayıt başarıyla gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Customer cus = new Customer();
                AddUserControl(cus);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlCon.Close();
            }

        }
        //CityCB de bir şehir seçilince seçilen şehrin ilçeleri DistrictCB ye getirildi
        private void CityCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DistrictCB.Items.Clear();
            DistrictCB.Text = "";

            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            SqlCommand Komut = new SqlCommand("Select * from Districts where sehir = @p1", SqlCon);
            Komut.Parameters.AddWithValue("@p1", CityCB.SelectedIndex + 1);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                DistrictCB.Items.Add(dr[1]);
            }
            SqlCon.Close();
        }

        //Otomatik sürüş oluşturma
        private void RideButton_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            #region Müşteri ekleme
            #region validation
            // Ad alanı validasyonu
            if (string.IsNullOrWhiteSpace(FirstNameTxt.Text) || !IsAlpha(FirstNameTxt.Text))
            {
                MessageBox.Show("Geçerli bir ad giriniz (yalnızca harflerden oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Soyad alanı validasyonu
            if (string.IsNullOrWhiteSpace(LastNameTxt.Text) || !IsAlpha(LastNameTxt.Text))
            {
                MessageBox.Show("Geçerli bir soyad giriniz (yalnızca harflerden oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Telefon alanı validasyonu
            if (string.IsNullOrWhiteSpace(PhoneTxt.Text) || !IsNumeric(PhoneTxt.Text) || PhoneTxt.Text.Length != 11)
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz (yalnızca 11 rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Şehir combobox validasyonu
            if (CityCB.SelectedIndex == -1)
            {
                MessageBox.Show("Bir şehir seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // İlçe combobox validasyonu
            if (DistrictCB.SelectedIndex == -1)
            {
                MessageBox.Show("Bir ilçe seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adres alanı validasyonu
            if (string.IsNullOrWhiteSpace(AddressTxt.Text))
            {
                MessageBox.Show("Adres boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion


            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            param.Add("@adi", FirstNameTxt.Text.Trim());
            param.Add("@soyadi", LastNameTxt.Text.Trim());
            param.Add("@telefon", PhoneTxt.Text.Trim());
            param.Add("@sehir", CityCB.SelectedItem.ToString());
            param.Add("@ilce", DistrictCB.SelectedItem.ToString());
            param.Add("@adres", AddressTxt.Text.Trim());
            param.Add("@sil", false);
            SqlCon.Execute("MusteriEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
            #endregion

            //priority si 1 olan arac
            SqlCommand Komut = new SqlCommand("select vehicle_id, vehicle_licence_plate, vehicle_priority from Vehicle where vehicle_priority = 1", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();

            //sırada araç varsa
            if (dr.Read())
            {
                #region Sıradaki aracı bulma
                int id = int.Parse(dr[0].ToString());
                string plate = dr[1].ToString();
                #endregion

                #region Sürüş oluşturma
                DynamicParameters param3 = new DynamicParameters();
                //string mesafeStr = "0";
                param3.Add("@id", 0);
                param3.Add("@telefon", PhoneTxt.Text.Trim());
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
                #endregion

                #region Aracı sıradan çıkarma
                DynamicParameters param2 = new DynamicParameters();
                param2.Add("@id", id);
                param2.Add("@sira", 1);
                SqlCon.Execute("SiradanCikar", param2, commandType: CommandType.StoredProcedure);
                #endregion

                MessageBox.Show("Sürüş Oluşturuldu");
                Home hm = new Home();
                AddUserControl(hm);
            }
            //sırada araç yoksa(müşteri sıraya alınır).
            else
            {
                SqlCon.Close();
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                //en son sıradaki müşteri
                SqlCommand Komut1 = new SqlCommand("select max(customer_priority) from Customer where customer_delete = 0", SqlCon);
                SqlDataReader dr1 = Komut1.ExecuteReader();
                dr1.Read();
                //listede müşteri varsa(sqldatareader null dönmüyorsa)
                if (!dr1.IsDBNull(0))
                {
                    int maxpr = int.Parse(dr1[0].ToString());
                    //müşteri kayıtlıysa
                    if (id != 0)
                    {
                        #region müşteri sıraya alındı

                        DynamicParameters param1 = new DynamicParameters();
                        param1.Add("@oncelik", maxpr);
                        param1.Add("@id", id);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlCon.Execute("MusteriSirayaEkle", param1, commandType: CommandType.StoredProcedure);
                        MessageBox.Show("Boş araç yok. Müşteri sıraya alındı.");

                        #endregion
                    }
                    //müşteri kayıtlı değlse
                    else
                    {
                        #region müşteri sıraya alındı
                        //son eklenen müşterinin id'si
                        SqlCommand Komut3 = new SqlCommand("select IDENT_CURRENT ('Customer')", SqlCon);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlDataReader dr3 = Komut3.ExecuteReader();


                        if (dr3.Read())
                        {

                            int cid = int.Parse(dr3[0].ToString());
                            DynamicParameters param1 = new DynamicParameters();
                            param1.Add("@oncelik", maxpr);
                            param1.Add("@id", cid);
                            SqlCon.Close();
                            if (SqlCon.State == ConnectionState.Closed)
                            {
                                SqlCon.Open();
                            }
                            SqlCon.Execute("MusteriSirayaEkle", param1, commandType: CommandType.StoredProcedure);
                            MessageBox.Show("Boş araç yok. Müşteri sıraya alındı.");
                        }

                        #endregion
                    }
                }
                //listede müşteri yoksa(sqldatareader null dönüyorsa)
                else
                {
                    //müşteri kayıtlıysa
                    if (id != 0)
                    {
                        #region müşteri sıraya alındı

                        DynamicParameters param1 = new DynamicParameters();
                        param1.Add("@oncelik", 0);
                        param1.Add("@id", id);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlCon.Execute("MusteriSirayaEkle", param1, commandType: CommandType.StoredProcedure);
                        MessageBox.Show("Boş araç yok. Müşteri sıraya alındı.");

                        #endregion
                    }
                    //müşteri kayıtlı değilse
                    else
                    {
                        #region müşteri sıraya alındı
                        //son eklenen müşterinin id'si
                        SqlCommand Komut3 = new SqlCommand("select IDENT_CURRENT ('Customer')", SqlCon);
                        SqlCon.Close();
                        if (SqlCon.State == ConnectionState.Closed)
                        {
                            SqlCon.Open();
                        }
                        SqlDataReader dr3 = Komut3.ExecuteReader();


                        if (dr3.Read())
                        {
                            int cid = int.Parse(dr3[0].ToString());
                            DynamicParameters param1 = new DynamicParameters();
                            param1.Add("@oncelik", 0);
                            param1.Add("@id", cid);
                            SqlCon.Close();
                            if (SqlCon.State == ConnectionState.Closed)
                            {
                                SqlCon.Open();
                            }
                            SqlCon.Execute("MusteriSirayaEkle", param1, commandType: CommandType.StoredProcedure);
                            MessageBox.Show("Boş araç yok. Müşteri sıraya alındı.");
                        }

                        #endregion
                    }
                }
                Home hm = new Home();
                AddUserControl(hm);
            }
            SqlCon.Close();
        }


    }
}
