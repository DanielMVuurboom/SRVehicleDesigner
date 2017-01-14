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
using Microsoft.Win32;
using SRVehicleDesigner.DAL;
using SRVehicleDesigner.BLL;
using System.IO;
using System.Reflection;

namespace SRVehicleDesigner
{
    /// <summary>
    /// Interaction logic for SRVehicleDesigner.xaml
    /// </summary>
    public partial class SRVehicleDesignerMain : Window
    {
        public SRVehicleDesignerMain()
        {
            InitializeComponent();
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var newVehicleDialog = new NewVehicleDialog();
            if (newVehicleDialog.ShowDialog() == true)
            {
                DataContext = newVehicleDialog.Vehicle;
            }
        }

        private void OpenCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                DataContext = Vehicle.GetVehicle(openFileDialog.FileName);
            }
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (DataContext is Vehicle);
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML File (*.xml)|*.xml";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = $"{((Vehicle)DataContext).Name}.xml";
            if (saveFileDialog.ShowDialog() == true)
            {
                ((Vehicle)DataContext).StoreVehicle(saveFileDialog.FileName);
            }
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
            var vehicle = DataContext as Vehicle;
            int oldValue = (int)vehicle.GetType().GetProperty(type.ToString()).GetValue(vehicle);
            if (comboBox.SelectedIndex != oldValue)
            {
                var adjustment = new Adjustment(vehicle, type, oldValue, comboBox.SelectedIndex);
                vehicle.Apply(adjustment);
            }
        }
        private void comboBox_int_SelectionChanged(AdjustmentType type, ComboBox comboBox)
        {
            var vehicle = DataContext as Vehicle;
            var oldValue = vehicle.GetType().GetProperty(type.ToString()).GetValue(vehicle);
            if (comboBox.SelectedValue != null && comboBox.SelectedValue != oldValue)
            {
                var adjustment = new Adjustment(vehicle, type, oldValue, comboBox.SelectedValue);
                vehicle.Apply(adjustment);
            }
        }
    }
}
