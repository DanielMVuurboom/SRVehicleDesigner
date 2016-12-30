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
using SRVehicleDesigner.DAL;
using System.Reflection;

namespace SRVehicleDesigner
{
    public partial class Modification : Form
    {
        private readonly Vehicle _vehicle;
        private readonly DataStore _dataStore;
        private readonly ToolTip _toolTip;

        public Modification(Vehicle vehicle, DataStore datastore)
        {
            InitializeComponent();
            _vehicle = vehicle;
            _dataStore = datastore;
            _toolTip = new ToolTip();

            _toolTip.SetToolTip(cargoFactorBox, $"Between {_vehicle.BaseChassis.CargoFactorBase} and {_vehicle.BaseChassis.CargoFactorMax}");
            _toolTip.SetToolTip(loadBox, $"Between {_vehicle.BasePowerPlant.LoadBase} and {_vehicle.BasePowerPlant.LoadMax}");

            handlingRoadBox.DataSource = EngineRules.GetValidHandlingOptions(_vehicle.BaseChassis.RoadHandling);
            handlingOffRoadBox.DataSource = EngineRules.GetValidHandlingOptions(_vehicle.BaseChassis.OffRoadHandling);
            _toolTip.SetToolTip(speedBox, $"Between {_vehicle.BasePowerPlant.SpeedBase} and {_vehicle.BasePowerPlant.SpeedMax}");
            _toolTip.SetToolTip(accelBox, $"Between {_vehicle.BasePowerPlant.AccelBase} and {_vehicle.BasePowerPlant.AccelMax}");
            economyLabel.Text = $"{economyLabel.Text} ({_vehicle.EconomyUnit})";
            _toolTip.SetToolTip(economyBox, $"Between {_vehicle.BasePowerPlant.EconomyBase} and {_vehicle.BasePowerPlant.EconomyMax}");
            fuelSizeLabel.Text = $"{fuelSizeLabel.Text} ({_vehicle.FuelSizeUnit})";
            _toolTip.SetToolTip(fuelSizeBox, $"From {_vehicle.BasePowerPlant.FuelSizeBase} upwards");

            autoNavBox.DataSource = _dataStore.Electronics.AutoNavList;
            pilotBox.DataSource = _dataStore.Electronics.PilotList;
            sensorBox.DataSource = _dataStore.Electronics.SensorList;
            ecmBox.DataSource = _dataStore.Electronics.EcmList;
            eccmBox.DataSource = _dataStore.Electronics.EccmList;
            edBox.DataSource = _dataStore.Electronics.EdList;
            ecdBox.DataSource = _dataStore.Electronics.EcdList;

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
            cargoFactorBox.Text = string.Format("{0:0}", _vehicle.CargoFactor);
            cargoFactorFreeBox.Text = string.Format("{0:0.00}", _vehicle.CargoFactorFree);
            loadBox.Text = string.Format("{0:0}", _vehicle.Load);
            loadFreeBox.Text = string.Format("{0:0.00}", _vehicle.LoadFree);

            handlingRoadBox.SelectedItem = ((List<int>)handlingRoadBox.DataSource).First(i => i == _vehicle.RoadHandling);
            handlingOffRoadBox.SelectedItem = ((List<int>)handlingOffRoadBox.DataSource).First(i => i == _vehicle.OffRoadHandling);
            speedBox.Text = _vehicle.Speed.ToString();
            accelBox.Text = _vehicle.Accel.ToString();
            economyBox.Text = string.Format("{0:0.000}", _vehicle.Economy);
            fuelSizeBox.Text = _vehicle.FuelSize.ToString();

            autoNavBox.SelectedItem = _dataStore.Electronics.AutoNavList.First(c => c.Level == _vehicle.AutoNav);
            pilotBox.SelectedItem = _dataStore.Electronics.PilotList.First(c => c.Level == _vehicle.Pilot);
            sigBox.Text = _vehicle.Sig.ToString();
            sensorBox.SelectedItem = _dataStore.Electronics.SensorList.First(c => c.Level == _vehicle.Sensor);
            ecmBox.SelectedItem = _dataStore.Electronics.EcmList.First(c => c.Level == _vehicle.Ecm);
            eccmBox.SelectedItem = _dataStore.Electronics.EccmList.First(c => c.Level == _vehicle.Eccm);
            edBox.SelectedItem = _dataStore.Electronics.EdList.First(c => c.Level == _vehicle.Ed);
            ecdBox.SelectedItem = _dataStore.Electronics.EcdList.First(c => c.Level == _vehicle.Ecd);
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

        private void autoNavBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.AutoNav, _vehicle.AutoNav, ((DAL.Component)autoNavBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void pilotBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Pilot, _vehicle.Pilot, ((DAL.Component)pilotBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void sensorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Sensor, _vehicle.Sensor, ((DAL.Component)sensorBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void ecmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Ecm, _vehicle.Ecm, ((DAL.Component)ecmBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void eccmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Eccm, _vehicle.Eccm, ((DAL.Component)eccmBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void edBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Ed, _vehicle.Ed, ((DAL.Component)edBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }

        private void ecdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adjustment = new Adjustment(_vehicle, AdjustmentType.Ecd, _vehicle.Ecd, ((DAL.Component)ecdBox.SelectedItem).Level);
            _vehicle.Apply(adjustment);
            Invalidate();
        }
    }
}
