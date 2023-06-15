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
    public partial class Shift : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        public Shift()
        {
            InitializeComponent();
            addShift();
            VeriListe();
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
                ShiftTypeCB.Items.Add(dr[1]);

            }

            SqlCon.Close();
        }
        void VeriListe()
        {

            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");         //trim boşluk silmek için
            List<DriverShiftTable> list = SqlCon.Query<DriverShiftTable>
                ("VardiyaArama", param, commandType: CommandType.StoredProcedure).ToList<DriverShiftTable>();
            ShiftDGV.DataSource = list;
            ShiftDGV.Columns[0].Visible = false;
            ShiftDGV.Columns[1].HeaderText = "Sürücü Adı";
            ShiftDGV.Columns[2].HeaderText = "Sürücü Soyadı";
            ShiftDGV.Columns[3].HeaderText = "Telefon Numarası";
            ShiftDGV.Columns[4].HeaderText = "Vardiyası";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (ShiftTypeCB.SelectedIndex != -1)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AramaMetni", ShiftTypeCB.SelectedItem);         //trim boşluk silmek için
                List<DriverShiftTable> list = SqlCon.Query<DriverShiftTable>
                    ("VardiyaArama", param, commandType: CommandType.StoredProcedure).ToList<DriverShiftTable>();
                ShiftDGV.DataSource = list;
                ShiftDGV.Columns[0].Visible = false;
                ShiftDGV.Columns[1].HeaderText = "Sürücü Adı";
                ShiftDGV.Columns[2].HeaderText = "Sürücü Soyadı";
                ShiftDGV.Columns[3].HeaderText = "Telefon Numarası";
                ShiftDGV.Columns[4].HeaderText = "Vardiyası";
            }
            else
            {
                DialogResult result = MessageBox.Show("Lütfen önce vardiya tipi seçiniz.", "Uyarı!", MessageBoxButtons.OK);
            }
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            VeriListe();
        }
    }
}
