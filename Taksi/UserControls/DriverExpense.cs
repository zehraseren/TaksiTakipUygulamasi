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
    public partial class DriverExpense : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        int id = 0;
        public int driverid;
        public int driverExpId;
        public DriverExpense()
        {
            InitializeComponent();
            ExpenseTypeCBContext();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            DriverExpensePanel.Controls.Clear();
            DriverExpensePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDriverExpense ex = new AddDriverExpense();
            AddUserControl(ex);
            ex.driverid = driverid;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                AddDriverExpense ex = new AddDriverExpense();
                AddUserControl(ex);
                ex.driverid = driverid;
                SqlCommand Komut = new SqlCommand("select de.driver_expense_id, de.driver_expense_amount, det.type_name, p.payment_type_name from [Driver Expense] de inner join [Driver Expense Type] det on det.driver_type_id = de.driver_expense_type_id inner join [Payment Type] p on p.payment_type_id = de.payment_type_id where de.driver_expense_id =" + int.Parse(DriverExpenseDGV.CurrentRow.Cells[0].Value.ToString()), SqlCon);
                SqlDataReader dr = Komut.ExecuteReader();
                while (dr.Read())
                {
                    ex.id = int.Parse(DriverExpenseDGV.CurrentRow.Cells[0].Value.ToString());
                    ex.DriverExpenseTypeCB.SelectedItem = dr[2].ToString();
                    ex.CostTypeCB.SelectedItem = dr[3].ToString();
                    ex.CostTxt.Text = dr[1].ToString();
                }

                SqlCon.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ExpenseTypeCBContext()
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            SqlCommand Komut = new SqlCommand("select * from [Driver Expense Type]", SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                ExpenseTypeCB.Items.Add(dr[1]);

            }


            SqlCon.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ExpenseTypeCB.Text = "";
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");
            param.Add("@id", driverid);
            List<DriverExpenseTable> list = SqlCon.Query<DriverExpenseTable>
                ("SurucuGiderArama", param, commandType: CommandType.StoredProcedure).ToList<DriverExpenseTable>();
            DriverExpenseDGV.DataSource = list;
            DriverExpenseDGV.Columns[0].Visible = false;
            DriverExpenseDGV.Columns[1].HeaderText = "Ad";
            DriverExpenseDGV.Columns[2].HeaderText = "Soyad";
            DriverExpenseDGV.Columns[3].HeaderText = "TC Kimlik No";
            DriverExpenseDGV.Columns[4].HeaderText = "Tarih";
            DriverExpenseDGV.Columns[5].HeaderText = "Tutar";
            DriverExpenseDGV.Columns[6].HeaderText = "Gider Tipi";
            DriverExpenseDGV.Columns[7].HeaderText = "Ödeme Tipi";
        }

        private void ExpenseTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", ExpenseTypeCB.Text);
            param.Add("@id", driverid);
            List<DriverExpenseTable> list = SqlCon.Query<DriverExpenseTable>
                ("SurucuGiderArama", param, commandType: CommandType.StoredProcedure).ToList<DriverExpenseTable>();
            DriverExpenseDGV.DataSource = list;
            DriverExpenseDGV.Columns[0].HeaderText = "Sıra No";
            DriverExpenseDGV.Columns[1].HeaderText = "Ad";
            DriverExpenseDGV.Columns[2].HeaderText = "Soyad";
            DriverExpenseDGV.Columns[3].HeaderText = "TC Kimlik No";
            DriverExpenseDGV.Columns[4].HeaderText = "Tarih";
            DriverExpenseDGV.Columns[5].HeaderText = "Tutar";
            DriverExpenseDGV.Columns[6].HeaderText = "Gider Tipi";
            DriverExpenseDGV.Columns[7].HeaderText = "Ödeme Tipi";
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
            Driver d = new Driver();
            AddUserControl(d);
        }

        private void DriverExpensePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
