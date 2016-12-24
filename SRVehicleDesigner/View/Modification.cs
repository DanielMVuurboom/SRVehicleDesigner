﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRVehicleDesigner.BLL;
using System.Reflection;

namespace SRVehicleDesigner
{
    public partial class Modification : Form
    {
        private Vehicle _vehicle;

        public Modification(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;

            handlingRoadBox.DataSource = EngineRules.GetValidHandlingOptions(_vehicle.BaseChassis.RoadHandling);
            handlingOffRoadBox.DataSource = EngineRules.GetValidHandlingOptions(_vehicle.BaseChassis.OffRoadHandling);
            economyLabel.Text = $"{economyLabel.Text} ({_vehicle.EconomyUnit})";
            fuelSizeLabel.Text = $"{fuelSizeLabel.Text} ({_vehicle.FuelSizeUnit})";
            bodyBox.Select();
        }

        private void Modification_Paint(object sender, PaintEventArgs e)
        {
            Text = _vehicle.Name;
            nameLabel.Text = _vehicle.Name;
            costLabel.Text = $"{_vehicle.Cost} nuYen";
            designPointLabel.Text = $"{ _vehicle.DesignPoints} DP";

            bodyBox.Text = _vehicle.Body.ToString();
            armorBox.Text = _vehicle.Armor.ToString();
            cargoFactorBox.Text = _vehicle.CargoFactor.ToString();
            cargoFactorFreeBox.Text = string.Format("{0:0.00}", _vehicle.CargoFactorFree);
            loadBox.Text = _vehicle.Load.ToString();
            loadFreeBox.Text = string.Format("{0:0.00}", _vehicle.LoadFree);

            handlingRoadBox.SelectedItem = ((List<int>)handlingRoadBox.DataSource).First(i => i == _vehicle.RoadHandling);
            handlingOffRoadBox.SelectedItem = ((List<int>)handlingOffRoadBox.DataSource).First(i => i == _vehicle.OffRoadHandling);
            speedBox.Text = _vehicle.Speed.ToString();
            accelBox.Text = _vehicle.Accel.ToString();
            economyBox.Text = string.Format("{0:0.000}", _vehicle.Economy);
            fuelSizeBox.Text = _vehicle.FuelSize.ToString();
        }

        private void generic_Validating(object sender, CancelEventArgs e, AdjustmentType adjustmentType)
        {
            var control = (Control)sender;
            var property = _vehicle.GetType().GetProperty(adjustmentType.ToString());
            var converter = TypeDescriptor.GetConverter(property.PropertyType);
            var value = converter.ConvertFrom("0");
            var validConversion = true;
            try
            { 
                value = converter.ConvertFrom(control.Text);
            } catch
            {
                validConversion = false;
            }

            var adjustment = new Adjustment(_vehicle, adjustmentType, property.GetValue(_vehicle), value);
            if (!validConversion || !adjustment.IsValid)
            {
                e.Cancel = true;
                errorProvider.SetError(control, adjustment.GetValidationMessage());
            }
            control.Tag = adjustment;
        }

        private void generic_Validated(object sender, EventArgs e)
        {
            var control = (Control)sender;
            errorProvider.SetError(control, string.Empty);
            _vehicle.Apply((Adjustment)control.Tag);
            Invalidate();
        }

        private void cargoFactorBox_Validating(object sender, CancelEventArgs e)
        {
            generic_Validating(sender, e, AdjustmentType.CargoFactor);
        }

        private void loadBox_Validating(object sender, CancelEventArgs e)
        {
            generic_Validating(sender, e, AdjustmentType.Load);
        }

        private void handlingRoadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.RoadHandling, _vehicle.RoadHandling, handlingRoadBox.SelectedItem);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void handlingOffRoadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.OffRoadHandling, _vehicle.OffRoadHandling, handlingOffRoadBox.SelectedItem);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void speedBox_Validating(object sender, CancelEventArgs e)
        {
            generic_Validating(sender, e, AdjustmentType.Speed);
        }

        private void accelBox_Validating(object sender, CancelEventArgs e)
        {
            generic_Validating(sender, e, AdjustmentType.Accel);
        }

        private void economyBox_Validating(object sender, CancelEventArgs e)
        {
            generic_Validating(sender, e, AdjustmentType.Economy);
        }

        private void fuelSizeBox_Validating(object sender, CancelEventArgs e)
        {
            generic_Validating(sender, e, AdjustmentType.FuelSize);
        }
    }
}
