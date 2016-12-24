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

            handlingRoadBox.DataSource = Handling.GetValidHandlingOptions(_vehicle.BaseChassis.RoadHandling);
            handlingOffRoadBox.DataSource = Handling.GetValidHandlingOptions(_vehicle.BaseChassis.OffRoadHandling);
            economyLabel.Text = economyLabel.Text + " (" + _vehicle.EconomyUnit + ")";
            fuelSizeLabel.Text = fuelSizeLabel.Text + " (" + _vehicle.FuelSizeUnit + ")";
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

        private void Modification_Paint(object sender, PaintEventArgs e)
        {
            Text = _vehicle.Name;
            nameLabel.Text = _vehicle.Name;
            costLabel.Text = _vehicle.Cost + " nuYen";
            handlingRoadBox.SelectedItem = ((List<int>)handlingRoadBox.DataSource).First(i => i == _vehicle.RoadHandling);
            handlingOffRoadBox.SelectedItem = ((List<int>)handlingOffRoadBox.DataSource).First(i => i == _vehicle.OffRoadHandling);
            speedBox.Text = _vehicle.Speed.ToString();
            accelBox.Text = _vehicle.Accel.ToString();
            economyBox.Text = _vehicle.Economy.ToString();
            fuelSizeBox.Text = _vehicle.FuelSize.ToString();
        }
    }
}
