using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static Taksi.Classes.Tables;

namespace Taksi.UserControls
{
    public partial class Station : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.AppSettings["TaxiConnection"]);
        int id = 0;
        public Station()
        {
            InitializeComponent();
            VeriListe();
        }


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            StationPanel.Controls.Clear();
            StationPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddStationButton_Click(object sender, EventArgs e)
        {
            AddStation ast = new AddStation();
            ast.label1.Text = "Yeni Durak";
            AddUserControl(ast);
        }

        public void VeriListe()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@AramaMetni", "");         //trim boşluk silmek için
            List<StationTable> list = SqlCon.Query<StationTable>
                ("DurakArama", param, commandType: CommandType.StoredProcedure).ToList<StationTable>();
            StationDGV.DataSource = list;
            StationDGV.Columns[0].Visible = false;
            StationDGV.Columns[1].HeaderText = "Ad";
            StationDGV.Columns[2].HeaderText = "Telefon";
            StationDGV.Columns[3].HeaderText = "Şehir";
            StationDGV.Columns[4].HeaderText = "İlçe";
            StationDGV.Columns[5].HeaderText = "Adres";
            StationDGV.Columns[6].Visible = false;
            StationDGV.Columns[7].Visible = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            AddStation ast = new AddStation();
            ast.label1.Text = "Durak Düzenle";
            AddUserControl(ast);
            SqlCommand Komut = new SqlCommand("Select s.station_id, s.station_name, s.station_phone, sa.province, sa.district, sa.address_line,s.station_coordinate, s.station_delete from Station s inner join [Station Address] sa on sa.adress_id = s.address_id  where s.station_id =" + int.Parse(StationDGV.CurrentRow.Cells[0].Value.ToString()), SqlCon);
            SqlDataReader dr = Komut.ExecuteReader();
            while (dr.Read())
            {
                ast.id = int.Parse(StationDGV.CurrentRow.Cells[0].Value.ToString());
                ast.StationNameTxt.Text = dr[1].ToString();
                ast.PhoneTxt.Text = dr[2].ToString();
                ast.CityCB.SelectedItem = dr[3].ToString();
                ast.DistrictCB.SelectedItem = dr[4].ToString();
                ast.AddressTxt.Text = dr[5].ToString();
            }
            SqlCon.Close();
        }

        private void ShowInMapRB_CheckedChanged(object sender, EventArgs e)
        {
            StationMap sm = new StationMap();
            AddUserControl(sm);
        }
    }
}
