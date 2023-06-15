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
    public partial class AddVehicleExpense : UserControl
    {
        public AddVehicleExpense()
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
            VehicleExpense ve = new VehicleExpense();
            AddUserControl(ve);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            VehicleExpense ve = new VehicleExpense();
            AddUserControl(ve);
        }
    }
}
