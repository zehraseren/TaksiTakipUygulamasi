using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Configuration;
using Dapper;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class AddVehicle : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id;
        public AddVehicle()
        {
            InitializeComponent();
            addStation();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddVehiclePanel.Controls.Clear();
            AddVehiclePanel.Controls.Add(userControl);
            userControl.BringToFront();
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
                SelectStationCB.Items.Add(dr[1]);
            }
            SqlCon.Close();
        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Vehicle vh = new Vehicle();
            AddUserControl(vh);
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

        private bool IsAlphaNumeric(string text)
        {
            return text.All(c => char.IsLetterOrDigit(c));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                // plaka alanı validasyonu
                if (string.IsNullOrWhiteSpace(LicencePlateTxt.Text) || !IsAlphaNumeric(LicencePlateTxt.Text))
                {
                    MessageBox.Show("Geçerli bir plaka giriniz (yalnızca harf ve rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // durak combobox validasyonu
                if (SelectStationCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir durak seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Marka alanı validasyonu
                if (string.IsNullOrWhiteSpace(BrandTxt.Text) || !IsAlphaNumeric(BrandTxt.Text))
                {
                    MessageBox.Show("Geçerli bir marka giriniz (yalnızca harflerden ve rakamlardan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // model alanı validasyonu
                if (string.IsNullOrWhiteSpace(BrandTxt.Text) || !IsAlphaNumeric(BrandTxt.Text))
                {
                    MessageBox.Show("Geçerli bir model giriniz (yalnızca harflerden ve rakamlardan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yıl alanı validasyonu
                if (string.IsNullOrWhiteSpace(YearTxt.Text) || !IsNumeric(YearTxt.Text) || YearTxt.Text.Length != 4)
                {
                    MessageBox.Show("Geçerli bir yıl giriniz (yalnızca 4 rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                param.Add("@plaka", LicencePlateTxt.Text.Trim());
                //param.Add("@konum", Convert.ToDecimal(LocationTxt.Text));
                param.Add("@marka", BrandTxt.Text.Trim());
                param.Add("@model", ModelTxt.Text.Trim());
                param.Add("@yil", YearTxt.Text.Trim());
                param.Add("@durak_ad", SelectStationCB.SelectedItem.ToString());
                param.Add("@sil", false);
                SqlCon.Execute("AracEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
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
            Vehicle vh = new Vehicle();
            AddUserControl(vh);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Vehicle vh = new Vehicle();
            AddUserControl(vh);
        }
    }
}
