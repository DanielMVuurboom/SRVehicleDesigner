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
        public NewVehicleDialog(DataStore dataStore)
        {
            InitializeComponent();
            DataContext = dataStore;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        public Vehicle Vehicle { get
            {
                throw new NotImplementedException();
            } }
    }
}
