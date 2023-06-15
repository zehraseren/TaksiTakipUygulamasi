using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Configuration;
using Dapper;

namespace Taksi.UserControls
{
    public partial class AddDriver : UserControl
    {
        //driver dan gelen id'yi tutmak için değişken tanımlandı
        public int id;
        //sql bağlantısı yapıldı
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public AddDriver()
        {
            InitializeComponent();
            //CityCB combobox'ına sayfa açılır açılmaz tüm şehirler getirildi
            addProvince();
            //ShiftCB combobox'ına sayfa açılır açılmaz tüm vardiyalar getirildi
            addShift();
            //StationCB combobox'ına sayfa açılır açılmaz tüm duraklar getirildi
            addStation();
            //VehicleCB combobox'ına sayfa açılır açılmaz tüm araçlar getirildi
            addVehicle();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddDriverPanel.Controls.Clear();
            AddDriverPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
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

        private void addShift()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select * from Shift", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                ShiftCB.Items.Add(dr[1]);

            }

            SqlCon.Close();
        }
        private void addStation()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select * from Station", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                StationCB.Items.Add(dr[1]);

            }

            SqlCon.Close();
        }

        private void addVehicle()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select * from Vehicle", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                VehicleCB.Items.Add(dr[4]);
            }

            SqlCon.Close();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Driver d = new Driver();
            AddUserControl(d);
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
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                #region validation
                // TC alanı validasyonu
                if (string.IsNullOrWhiteSpace(IDNoTxt.Text) || !IsNumeric(IDNoTxt.Text) || IDNoTxt.Text.Length != 11)
                {
                    MessageBox.Show("Geçerli bir kimlik numarası giriniz (yalnızca 11 rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

                // vardiya combobox validasyonu
                if (ShiftCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir vardiya seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // durak combobox validasyonu
                if (StationCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir durak seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // araç combobox validasyonu
                if (VehicleCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir araç seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                param.Add("@tc", IDNoTxt.Text.Trim());
                param.Add("@adi", FirstNameTxt.Text.Trim());
                param.Add("@soyadi", LastNameTxt.Text.Trim());
                param.Add("@telefon", PhoneTxt.Text.Trim());
                param.Add("@vardiya_ad", ShiftCB.SelectedItem.ToString());
                param.Add("@durak_ad", StationCB.SelectedItem.ToString());
                param.Add("@plaka", VehicleCB.SelectedItem.ToString());
                param.Add("@sehir", CityCB.SelectedItem.ToString());
                param.Add("@ilce", DistrictCB.SelectedItem.ToString());
                param.Add("@adres", AddressTxt.Text.Trim());
                param.Add("@sil", false);
                SqlCon.Execute("SurucuEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Kayıt başarıyla gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Driver d = new Driver();
            AddUserControl(d);
        }

        private void CityCB_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
