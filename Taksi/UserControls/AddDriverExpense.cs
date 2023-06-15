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
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class AddDriverExpense : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public int id = 0;
        public int driverid;
        public AddDriverExpense()
        {
            InitializeComponent();
            expenseType();
            paymentType();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AddDriverExpensePanel.Controls.Clear();
            AddDriverExpensePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void expenseType()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select * from [Driver Expense Type]", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                DriverExpenseTypeCB.Items.Add(dr[1]);

            }

            SqlCon.Close();
        }
        private void paymentType()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("Select * from [Payment Type]", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                CostTypeCB.Items.Add(dr[1]);

            }

            SqlCon.Close();
        }

        void Listele()
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
            de.driverid = driverid;
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
        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            DriverExpense de = new DriverExpense();
            AddUserControl(de);
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            DriverExpense de = new DriverExpense();
            AddUserControl(de);
        }

        private bool IsNumeric(string text)
        {
            return text.All(c => char.IsDigit(c));
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                // gider combobox validasyonu
                if (DriverExpenseTypeCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir gider tipi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ödeme combobox validasyonu
                if (CostTypeCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bir ödeme tipi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // tutar alanı validasyonu
                if (string.IsNullOrWhiteSpace(CostTxt.Text) || !IsNumeric(CostTxt.Text))
                {
                    MessageBox.Show("Geçerli bir yıl giriniz (yalnızca 4 rakamdan oluşmalıdır ve boş olamaz).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                param.Add("@surucu_id", driverid);
                param.Add("@gider_tip", DriverExpenseTypeCB.SelectedItem.ToString());
                param.Add("@tutar", CostTxt.Text.Trim());
                param.Add("@odeme_tip", CostTypeCB.SelectedItem.ToString());
                SqlCon.Execute("SurucuGiderEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Kayıt başarıyla gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();

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
    }
}
