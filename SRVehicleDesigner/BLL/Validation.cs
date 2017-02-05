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
    }
}
