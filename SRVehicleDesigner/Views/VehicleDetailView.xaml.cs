using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SRVehicleDesigner.ViewModels;
using SRVehicleDesigner.BLL;

namespace SRVehicleDesigner.Views
{
    /// <summary>
    /// Interaction logic for VehicleDetailView.xaml
    /// </summary>
    public partial class VehicleDetailView : UserControl
    {
        public VehicleViewModel Vehicle { get; }
        public VehicleDetailView(VehicleViewModel vehicle)
        {
            InitializeComponent();
            Vehicle = vehicle;
            DataContext = vehicle;
        }

        private void roadHandlingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_int_SelectionChanged(AdjustmentType.RoadHandling, (ComboBox)sender);
        }

        private void offRoadHandlingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_int_SelectionChanged(AdjustmentType.OffRoadHandling, (ComboBox)sender);
        }

        private void autoNavBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.AutoNav, (ComboBox)sender);
        }

        private void pilotBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.Pilot, (ComboBox)sender);
        }

        private void sensorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.Sensor, (ComboBox)sender);
        }

        private void ecmBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.Ecm, (ComboBox)sender);
        }

        private void eccmBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.Eccm, (ComboBox)sender);
        }

        private void edBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.Ed, (ComboBox)sender);
        }

        private void ecdBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Component_SelectionChanged(AdjustmentType.Ecd, (ComboBox)sender);
        }

        private void comboBox_Component_SelectionChanged(AdjustmentType type, ComboBox comboBox)
        {
            var vehicle = DataContext as VehicleViewModel;
            int oldValue = (int)vehicle.GetType().GetProperty(type.ToString()).GetValue(vehicle);
            if (comboBox.SelectedIndex != oldValue)
            {
                var adjustment = new Adjustment(type, vehicle.BaseChassis, vehicle.BasePowerPlant, oldValue, comboBox.SelectedIndex);
                vehicle.Apply(adjustment);
            }
        }
        private void comboBox_int_SelectionChanged(AdjustmentType type, ComboBox comboBox)
        {
            var vehicle = DataContext as VehicleViewModel;
            var oldValue = vehicle.GetType().GetProperty(type.ToString()).GetValue(vehicle);
            if (comboBox.SelectedValue != null && comboBox.SelectedValue != oldValue)
            {
                var adjustment = new Adjustment(type, vehicle.BaseChassis, vehicle.BasePowerPlant, oldValue, comboBox.SelectedValue);
                vehicle.Apply(adjustment);
            }
        }
    }
}
