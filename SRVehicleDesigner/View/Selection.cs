using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRVehicleDesigner.DAL;
using System.IO;

namespace SRVehicleDesigner
{
    public partial class Selection : Form
    {
        private DataStore _dataStore;

        public Selection()
        {
            InitializeComponent();
            _dataStore = DataStore.GetDefaultDataStore();
            chassisGroupBox.DataSource = _dataStore.ChassisGroupList;
            droneBox.DataSource = _dataStore.BooleanList;
        }


        private void chassisGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chassisBox.DataSource = _dataStore.ChassisList.Where(c => c.ChassisGroup == (ChassisGroup)chassisGroupBox.SelectedItem).ToList();
        }

        private void chassisBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chassis = (Chassis)chassisBox.SelectedItem;
            powerPlantBox.DataSource = _dataStore.PowerPlantList.Where(
                pp => pp.AllowedChassisRuleList.Any(
                    acr => acr.AllowedChassisGroup == chassis.ChassisGroup && 
                    (acr.AllowedChassisNameList.Contains(chassis.Name) || acr.AllowedChassisNameList.Contains("All"))
            )).ToList();
        }

        private void newVehicleButton_Click(object sender, EventArgs e)
        {
            var vehicle = new Vehicle((Chassis)chassisBox.SelectedItem, (PowerPlant)powerPlantBox.SelectedItem, (bool)droneBox.SelectedItem);
            var modificationForm = new Modification(vehicle, _dataStore);
            modificationForm.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SRVehicleDesigner");
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            Vehicle vehicle;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    vehicle = FileAccessHelper.LoadFromFile<Vehicle>(openFileDialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading vehicle from disk. Original error: " + ex.Message);
                    return;
                }
                var modificationForm = new Modification(vehicle, _dataStore); 
                modificationForm.Show();
            }
        }
    }
}
