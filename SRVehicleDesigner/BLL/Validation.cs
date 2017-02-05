using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRVehicleDesigner.DAL;

namespace SRVehicleDesigner.BLL
{
    public class Validation
    {
        public static string ValidityDescriptor(string propertyName, Chassis chassis, PowerPlant powerPlant)
        {
            string message;

            switch (propertyName)
            {
                case "Speed":
                    message = $"Speed should be between {powerPlant.SpeedBase} and {powerPlant.SpeedMax}";
                    break;
                case "Accel":
                    message = $"Accel should be between {powerPlant.AccelBase} and {powerPlant.AccelMax}";
                    break;
                case "Economy":
                    message = $"Economy should be between {powerPlant.EconomyBase} and {powerPlant.EconomyMax}";
                    break;
                case "FuelSize":
                    message = $"Fuel should be a positive integer";
                    break;
                case "CargoFactor":
                    message = $"CargoFactor should be between {chassis.CargoFactorBase} and {chassis.CargoFactorMax}";
                    break;
                case "Load":
                    message = $"Load should be between {powerPlant.LoadBase} and {powerPlant.LoadMax}";
                    break;
                case "Name":
                    message = $"Name can be any text";
                    break;
                default:
                    message = $"No validity descriptor available for field [{propertyName}]";
                    break;
            }
            return message;
        }

        public static bool Validate(object value, string propertyName, Chassis chassis, PowerPlant powerPlant)
        {
            bool IsValid = false;
            switch (propertyName)
            {
                case "RoadHandling":
                    IsValid = (value is int && EngineRules.GetValidHandlingOptions(chassis.RoadHandling).Contains((int)value));
                    break;
                case "OffRoadHandling":
                    IsValid = (value is int && EngineRules.GetValidHandlingOptions(chassis.OffRoadHandling).Contains((int)value));
                    break;
                case "AutoNav":
                case "Pilot":
                case "Sensor":
                case "Ecm":
                case "Eccm":
                case "Ed":
                case "Ecd":
                    var componentlist = (List<Component>)Electronics.GetDefaultElectronics().GetType().GetProperty($"{propertyName}List").GetValue(Electronics.GetDefaultElectronics());
                    IsValid = (value is int && componentlist.Any(c => c.Level == (int)value));
                    break;
                case "Speed":
                    IsValid = (value is int && ValidateBetween(value, powerPlant.SpeedBase, powerPlant.SpeedMax));
                    break;
                case "Accel":
                    IsValid = (value is int && ValidateBetween(value, powerPlant.AccelBase, powerPlant.AccelMax));
                    break;
                case "Economy":
                    IsValid = (value is decimal && ValidateBetween(value, powerPlant.EconomyBase, powerPlant.EconomyMax));
                    break;
                case "FuelSize":
                    IsValid = (value is int && (int)value >= 0);
                    break;
                case "CargoFactor":
                    IsValid = (value is decimal && ValidateBetween(value, chassis.CargoFactorBase, chassis.CargoFactorMax));
                    break;
                case "Load":
                    IsValid = (value is decimal && ValidateBetween(value, powerPlant.LoadBase, powerPlant.LoadMax));
                    break;
                case "Name":
                case "LoadFree":
                case "CargoFactorFree":
                case "DesignPoints":
                case "DesignMultiplier":
                    IsValid = true;
                    break;
                default:
                    throw new NotImplementedException();
            }
            return IsValid;
        }

        private static bool ValidateBetween(object _target,  int min, int max)
        {
            return min <= (int)_target && (int)_target <= max;
        }

        private static bool ValidateBetween(object _target, decimal min, decimal max)
        {
            return min <= (decimal)_target && (decimal)_target <= max;
        }
    }
}
