﻿using System;
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
            var modificationForm = new Modification(vehicle);
            modificationForm.Show();
        }
    }
}