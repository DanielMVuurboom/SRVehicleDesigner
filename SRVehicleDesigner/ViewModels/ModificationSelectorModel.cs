using SRVehicleDesigner.BLL;
using SRVehicleDesigner.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner.ViewModels
{
    public class ModificationSelectorModel
    {
        public Modification Modification { get; private set; }
        public VehicleViewModel Vehicle { get; private set; }
        public string AllowedRange
        {
            get { return $"{Modification.MinimumRule.CalculateFor(Vehicle)} - {Modification.MaximumRule.CalculateFor(Vehicle)}"; }
        }

        public ModificationSelectorModel(Modification modification, VehicleViewModel vehicle)
        {
            Modification = modification;
            Vehicle = vehicle;
        }
    }
}
