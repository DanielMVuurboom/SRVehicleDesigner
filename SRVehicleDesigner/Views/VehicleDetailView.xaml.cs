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
using SRVehicleDesigner.DAL;

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
            Vehicle.InitializationComplete = true;
        }

        private void AddModificationButton_Click(object sender, RoutedEventArgs e)
        {
            var mod = (Modification)AvailableModifications.SelectedItem;
            switch (mod.ModificationType)
            {
                case ModificationType.Numeric:
                    var max = mod.MaximumRule.CalculateFor(Vehicle);
                    var dialog = new SelectModificationAmountDialog(mod.MaximumRule);
                    if (dialog.ShowDialog() == true) { }
                    break;
            }
        }

        private void RemoveModificationButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
