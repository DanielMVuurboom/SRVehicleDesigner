using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    designMultiplier = 0;
                    break;
            }

            //TODO: Include special accessories

            if (drone)
            {
                designMultiplier = designMultiplier / 100;
            }
            return designMultiplier;
        }
    }
}
