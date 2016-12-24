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
                case AdjustmentType.Speed:
                case AdjustmentType.Accel:
                    NewValue = _target;
                    DesignPointCost = ((int)_target - (int)_current) * 2;
                    break;
                case AdjustmentType.Economy:
                    var fivePercentOfBase = _powerPlant.EconomyBase / 20;
                    var increaseQuantumCount = (int)Math.Ceiling(((decimal)_target - (decimal)_current) / fivePercentOfBase);
                    NewValue = (decimal)_current + fivePercentOfBase * increaseQuantumCount;
                    DesignPointCost = increaseQuantumCount * 5;
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
                    IsValid = (_current is int && _target is int && EngineRules.GetValidHandlingOptions(_chassis.RoadHandling).Contains((int)_target));
                    break;
                case AdjustmentType.OffRoadHandling:
                    IsValid = (_current is int && _target is int && EngineRules.GetValidHandlingOptions(_chassis.OffRoadHandling).Contains((int)_target));
                    break;
                case AdjustmentType.Speed:
                    IsValid = (_current is int && _target is int && ValidateBetween(_powerPlant.SpeedBase, _powerPlant.SpeedMax));
                    break;
                case AdjustmentType.Accel:
                    IsValid = (_current is int && _target is int && ValidateBetween(_powerPlant.AccelBase, _powerPlant.AccelMax));
                    break;
                case AdjustmentType.Economy:
                    IsValid = (_current is decimal && _target is decimal && ValidateBetween(_powerPlant.EconomyBase, _powerPlant.EconomyMax));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private bool ValidateBetween(int min, int max)
        {
            return min <= (int)_target && (int)_target <= max;
        }

        private bool ValidateBetween(decimal min, decimal max)
        {
            return min <= (decimal)_target && (decimal)_target <= max;
        }

        public string GetValidationMessage()
        {
            string message;

            switch (AdjustmentType)
            {
                case AdjustmentType.Speed:
                    message = $"Speed should be between {_powerPlant.SpeedBase} and {_powerPlant.SpeedMax}";
                    break;
                case AdjustmentType.Accel:
                    message = $"Accel should be between {_powerPlant.AccelBase} and {_powerPlant.AccelMax}";
                    break;
                case AdjustmentType.Economy:
                    message = $"Economy should be between {_powerPlant.EconomyBase} and {_powerPlant.EconomyMax}";
                    break;
                default:
                    throw new NotImplementedException();
            }

            return message;
        }
    }
}
