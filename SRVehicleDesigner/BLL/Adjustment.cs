using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SRVehicleDesigner.BLL
{
    public enum AdjustmentType
    {
        RoadHandling,
        OffRoadHandling,
        Speed,
        Accel,
        Economy,
        FuelSize,
        Load,
        CargoFactor
    }

    public class Adjustment
    {
        private Chassis _chassis;
        private PowerPlant _powerPlant;
        private object _current;
        private object _target;

        public AdjustmentType AdjustmentType { get; private set; }
        public bool IsValid { get; private set; }
        public int DesignPointCost { get; private set; }
        public decimal CargoFactorReduction { get; private set; }
        public decimal LoadReduction { get; private set; }
        public object NewValue { get; private set; }

        public Adjustment(Vehicle vehicle, AdjustmentType type, object current, object target)
        {
            _chassis = vehicle.BaseChassis;
            _powerPlant = vehicle.BasePowerPlant;
            AdjustmentType = type;
            _current = current;
            _target = target;
            Validate();
            Calculate();
        }

        private void Calculate()
        {
            switch (AdjustmentType)
            {
                case AdjustmentType.RoadHandling:
                case AdjustmentType.OffRoadHandling:
                    NewValue = _target;
                    DesignPointCost = ((int)_current - (int)_target) * 25;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void Validate()
        {
            switch (AdjustmentType)
            {
                case AdjustmentType.RoadHandling:
                case AdjustmentType.OffRoadHandling:
                    IsValid = (_current is int && _target is int);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
