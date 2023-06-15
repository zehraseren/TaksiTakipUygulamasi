using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Taksi.UserControls
{
    public partial class AddStation : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id;
        public AddStation()
        {
            InitializeComponent();
            addProvince();
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

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddStationPanel.Controls.Clear();
            AddStationPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Station st = new Station();
            AddUserControl(st);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Station st = new Station();
            AddUserControl(st);
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                // durak adı alanı validasyonu
                if (string.IsNullOrWhiteSpace(StationNameTxt.Text))
                {
                    MessageBox.Show("Geçerli bir durak adı giriniz (boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                param.Add("@adi", StationNameTxt.Text.Trim());
                param.Add("@telefon", PhoneTxt.Text.Trim());
                param.Add("@sehir", CityCB.SelectedItem.ToString());
                param.Add("@ilce", DistrictCB.SelectedItem.ToString());
                param.Add("@adres", AddressTxt.Text.Trim());
                param.Add("@sil", false);
                SqlCon.Execute("DurakEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
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
            Station st = new Station();
            AddUserControl(st);
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
