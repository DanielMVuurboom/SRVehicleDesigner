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

namespace SRVehicleDesigner.Views
{
    /// <summary>
    /// Interaction logic for SRVehicleDesigner.xaml
    /// </summary>
    public partial class SRVehicleDesignerMainView : Window
    {
        public SRVehicleDesignerMainView()
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
                var vehicleDetailView = new VehicleDetailView(newVehicleDialog.Vehicle);
                VehicleDetails.Content = vehicleDetailView;
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
                var vehicle = Vehicle.GetVehicle(openFileDialog.FileName);
                var vehicleDetailView = new VehicleDetailView(vehicle);
                VehicleDetails.Content = vehicleDetailView;
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
    }
}
