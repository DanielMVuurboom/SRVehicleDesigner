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
using System.Windows.Shapes;
using SRVehicleDesigner.DAL;

namespace SRVehicleDesigner
{
    /// <summary>
    /// Interaction logic for NewVehicleDialog.xaml
    /// </summary>
    public partial class NewVehicleDialog : Window
    {
        public Vehicle Vehicle { get; private set; }

        public NewVehicleDialog(DataStore dataStore)
        {
            InitializeComponent();
            DataContext = dataStore;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            Vehicle = new Vehicle((Chassis)chassisBox.SelectedItem, (PowerPlant)powerPlantBox.SelectedItem, droneCheck.IsChecked == true);
            if (nameBox.Text != string.Empty)
            {
                Vehicle.Name = nameBox.Text;
            }
            DialogResult = true;
        }

        private void chassisGroupBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            chassisBox.ItemsSource = ((DataStore)DataContext).ChassisList.Where(c => c.ChassisGroup == (ChassisGroup)chassisGroupBox.SelectedItem);
            powerPlantBox.ItemsSource = new List<PowerPlant>();
            btnDialogOk.IsEnabled = false;
        }

        private void chassisBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            powerPlantBox.ItemsSource = ((DataStore)DataContext).PowerPlantList.Where(pp => pp.IsValidFor((Chassis)chassisBox.SelectedItem));
            btnDialogOk.IsEnabled = false;
        }

        private void powerPlanBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDialogOk.IsEnabled = true;
        }
    }
}
