using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksi.UserControls
{
    public partial class VehicleExpense : UserControl
    {
        public VehicleExpense()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            VehicleExpensePanel.Controls.Clear();
            VehicleExpensePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddVehicleExpense ave = new AddVehicleExpense();
            AddUserControl(ave);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddVehicleExpense ave = new AddVehicleExpense();
            AddUserControl(ave);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Vehicle vh = new Vehicle();
            AddUserControl(vh);
        }
    }
}
