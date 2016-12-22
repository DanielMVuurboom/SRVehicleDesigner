using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRVehicleDesigner
{
    public partial class Selection : Form
    {
        private DataStore _dataStore;

        public Selection()
        {
            InitializeComponent();
            _dataStore = DataStore.LoadData();
            chassisGroupBox.DataSource = _dataStore.ChassisGroupList;
        }

        private void chassisGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chassisBox.DataSource = _dataStore.ChassisList.Where(c => c.ChassisGroup == (ChassisGroup)chassisGroupBox.SelectedItem).ToList();
        }
    }
}
