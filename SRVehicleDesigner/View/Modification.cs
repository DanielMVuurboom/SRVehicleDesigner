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
            handlingRoadBox.SelectedItem = ((List<int>)handlingRoadBox.DataSource).First(i => i == _vehicle.RoadHandling);
            handlingOffRoadBox.SelectedItem = ((List<int>)handlingOffRoadBox.DataSource).First(i => i == _vehicle.OffRoadHandling);
            speedBox.Text = _vehicle.Speed.ToString();
            accelBox.Text = _vehicle.Accel.ToString();
            economyBox.Text = string.Format("{0:0.00}", _vehicle.Economy);
            fuelSizeBox.Text = _vehicle.FuelSize.ToString();
        }

        private void handlingRoadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)handlingRoadBox.SelectedItem != _vehicle.RoadHandling)
            {
                _vehicle.SetRoadHandling((int)handlingRoadBox.SelectedItem);
                Invalidate();
            }
        }

        private void handlingOffRoadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)handlingOffRoadBox.SelectedItem != _vehicle.OffRoadHandling)
            {
                _vehicle.SetOffRoadHandling((int)handlingOffRoadBox.SelectedItem);
                Invalidate();
            }
        }

        private void speedBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            var valid = int.TryParse(speedBox.Text, out value);
            if (!valid || _vehicle.BasePowerPlant.SpeedBase > value || value > _vehicle.BasePowerPlant.SpeedMax)
            {
                e.Cancel = true;
                errorProvider.SetError(speedBox, $"Speed should be between {_vehicle.BasePowerPlant.SpeedBase} and {_vehicle.BasePowerPlant.SpeedMax}");
            }
        }

        private void speedBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(speedBox, string.Empty);
            _vehicle.SetSpeed(int.Parse(speedBox.Text));
            Invalidate();
        }

        private void accelBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            var valid = int.TryParse(accelBox.Text, out value);
            if (!valid || _vehicle.BasePowerPlant.AccelBase > value || value > _vehicle.BasePowerPlant.AccelMax)
            {
                e.Cancel = true;
                errorProvider.SetError(accelBox, $"Accel should be between {_vehicle.BasePowerPlant.AccelBase} and {_vehicle.BasePowerPlant.AccelMax}");
            }
        }

        private void accelBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(accelBox, string.Empty);
            _vehicle.SetAccel(int.Parse(accelBox.Text));
            Invalidate();
        }

        private void economyBox_Validating(object sender, CancelEventArgs e)
        {
            decimal value;
            var valid = decimal.TryParse(economyBox.Text, out value);
            if (!valid || _vehicle.BasePowerPlant.EconomyBase > value || value > _vehicle.BasePowerPlant.EconomyMax)
            {
                e.Cancel = true;
                errorProvider.SetError(economyBox, $"Economy should be between {_vehicle.BasePowerPlant.EconomyBase} and {_vehicle.BasePowerPlant.EconomyMax}");
            }

        }

        private void economyBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(economyBox, string.Empty);
            _vehicle.SetEconomy(economyBox.Text);
            Invalidate();
        }

        private void fuelSizeBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void fuelSizeBox_Validated(object sender, EventArgs e)
        {

        }
    }
}
