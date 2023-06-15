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
    public partial class UserPanel : UserControl
    {
        public int id;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);

        public UserPanel()
        {
            InitializeComponent();
            RolName();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddUserPanel.Controls.Clear();
            AddUserPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        void RolName()
        {
            UserRoleCB.Items.Clear();
            UserRoleCB.Text = "";
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            SqlCommand Komut = new SqlCommand("select * from [User Role]", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                UserRoleCB.Items.Add(dr[1]);
            }
            SqlCon.Close();
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

                // Ad alanı validasyonu
                if (string.IsNullOrWhiteSpace(userTxt.Text))
                {
                    MessageBox.Show("Geçerli bir kullanıcı adı giriniz (boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // şifre alanı validasyonu
                if (string.IsNullOrWhiteSpace(PasswordTxt.Text))
                {
                    MessageBox.Show("Geçerli bir şifre giriniz (boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // rol combobox validasyonu
                if (UserRoleCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir rol seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // durum combobox validasyonu
                if (StatusCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir durum seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                param.Add("@kadi", userTxt.Text.Trim());
                param.Add("@sifre", PasswordTxt.Text.Trim());
                param.Add("@rol_name", UserRoleCB.SelectedItem.ToString());
                param.Add("Adi", FirstNameTxt.Text.Trim());
                param.Add("Soyadi", LastNameTxt.Text.Trim());
                param.Add("@durum", StatusCB.SelectedItem.ToString());
                param.Add("@telefon", PhoneTxt.Text.Trim());
                param.Add("@sil", false);
                SqlCon.Execute("KullaniciEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Kayıt başarıyla gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User us = new User();
                AddUserControl(us);
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

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            User us = new User();
            AddUserControl(us);
        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            User us = new User();
            AddUserControl(us);
        }

        private void cancelBtnHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            AddUserControl(hm);
        }
    }
}
