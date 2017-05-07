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
using SRVehicleDesigner.ViewModels;

namespace SRVehicleDesigner.Views
{
    /// <summary>
    /// Interaction logic for SelectModificationDialog.xaml
    /// </summary>
    public partial class SelectModificationDialog : Window
    {
        public ModificationSelectorModel SelectorModel { get; private set; }
        public int SelectedAmount { get { return _selectedAmount; } }
        private int _selectedAmount;

        public SelectModificationDialog(Modification modification, VehicleViewModel vehicle)
        {
            SelectorModel = new ModificationSelectorModel(modification, vehicle);
            DataContext = SelectorModel;
            InitializeComponent();
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(amountBox.Text, out _selectedAmount))
            {
                DialogResult = true;
                return;
            }
            DialogResult = false;
        }
    }
}
