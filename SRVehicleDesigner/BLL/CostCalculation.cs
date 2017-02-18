using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRVehicleDesigner.DAL;

namespace SRVehicleDesigner.BLL
{
    public class CostCalculation
    {
        public static double CalculateDesignMultiplier(ChassisGroup chassisGroup, bool drone, IList<Accessory> accessoryList)
        {
            double designMultiplier;

            switch (chassisGroup)
            {
                case ChassisGroup.Bikes:
                    designMultiplier = 0.5;
                    break;
                case ChassisGroup.Cars:
                    designMultiplier = 1;
                    break;
                case ChassisGroup.Hovercraft:
                default:
                    designMultiplier = 2.5;
                    break;
            }

            //TODO: Include special accessories

            if (drone)
            {
                designMultiplier = designMultiplier / 10;
            }
            return designMultiplier;
        }
    }
}
