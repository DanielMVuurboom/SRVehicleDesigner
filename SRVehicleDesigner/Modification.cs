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
            Text = vehicle.Name;

            handlingRoadBox.DataSource = Handling.GetValidHandlingOptions(_vehicle.BaseChassis.RoadHandling);
            handlingOffRoadBox.DataSource = Handling.GetValidHandlingOptions(_vehicle.BaseChassis.OffRoadHandling);
            speedBox.Text = _vehicle.Speed.ToString();
            accelBox.Text = _vehicle.Accel.ToString();
            economyLabel.Text = economyLabel.Text + " (" + _vehicle.EconomyUnit + ")";
            economyBox.Text = _vehicle.Economy.ToString();
            fuelSizeLabel.Text = fuelSizeLabel.Text + " (" + _vehicle.FuelSizeUnit + ")";
            fuelSizeBox.Text = _vehicle.FuelSize.ToString();
        }

        private void handlingRoadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)handlingRoadBox.SelectedItem != _vehicle.RoadHandling)
            {
                throw new NotImplementedException();
            }
        }

        private void handlingOffRoadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)handlingOffRoadBox.SelectedItem != _vehicle.OffRoadHandling)
            {
                throw new NotImplementedException();
            }
        }

        private void speedBox_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(speedBox.Text) != _vehicle.Speed)
            {
                throw new NotImplementedException();
            }
        }

        private void accelBox_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(accelBox.Text) != _vehicle.Accel)
            {
                throw new NotImplementedException();
            }
        }

        private void economyBox_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(economyBox.Text) != _vehicle.Economy)
            {
                throw new NotImplementedException();
            }
        }

        private void fuelSizeBox_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(fuelSizeBox.Text) != _vehicle.FuelSize)
            {
                throw new NotImplementedException();
            }
        }
    }
}
