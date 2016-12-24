using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRVehicleDesigner.BLL;

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

        private void loadBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            var valid = int.TryParse(loadBox.Text, out value);
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Load, _vehicle.Load, value);

            if (!valid || !adjustment.IsValid)
            {
                e.Cancel = true;
                errorProvider.SetError(loadBox, adjustment.GetValidationMessage());
            }
            loadBox.Tag = adjustment;

        }

        private void loadBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(loadBox, string.Empty);
            _vehicle.Apply((Adjustment)loadBox.Tag);
            Invalidate();
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
            int value;
            var valid = int.TryParse(speedBox.Text, out value);
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Speed, _vehicle.Speed, value);

            if (!valid || !adjustment.IsValid)
            {
                e.Cancel = true;
                errorProvider.SetError(speedBox, adjustment.GetValidationMessage());
            }
            speedBox.Tag = adjustment;
        }

        private void speedBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(speedBox, string.Empty);
            _vehicle.Apply((Adjustment)speedBox.Tag);
            Invalidate();
        }

        private void accelBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            var valid = int.TryParse(accelBox.Text, out value);
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Accel, _vehicle.Accel, value);

            if (!valid || !adjustment.IsValid)
            {
                e.Cancel = true;
                errorProvider.SetError(accelBox, adjustment.GetValidationMessage());
            }
            accelBox.Tag = adjustment;
        }

        private void accelBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(accelBox, string.Empty);
            _vehicle.Apply((Adjustment)accelBox.Tag);
            Invalidate();
        }

        private void economyBox_Validating(object sender, CancelEventArgs e)
        {
            decimal value;
            var valid = decimal.TryParse(economyBox.Text, out value);
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Economy, _vehicle.Economy, value);

            if (!valid || !adjustment.IsValid)
            {
                e.Cancel = true;
                errorProvider.SetError(economyBox, adjustment.GetValidationMessage());
            }
            economyBox.Tag = adjustment;
        }

        private void economyBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(economyBox, string.Empty);
            _vehicle.Apply((Adjustment)economyBox.Tag);
            Invalidate();
        }

        private void fuelSizeBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            var valid = int.TryParse(fuelSizeBox.Text, out value);
            var adjustment = new Adjustment(_vehicle, AdjustmentType.FuelSize, _vehicle.FuelSize, value);

            if (!valid || !adjustment.IsValid)
            {
                e.Cancel = true;
                errorProvider.SetError(fuelSizeBox, adjustment.GetValidationMessage());
            }
            fuelSizeBox.Tag = adjustment;
        }

        private void fuelSizeBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(fuelSizeBox, string.Empty);
            _vehicle.Apply((Adjustment)fuelSizeBox.Tag);
            Invalidate();
        }
    }
}
