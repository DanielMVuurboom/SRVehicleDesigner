using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner.BLL
{
    public class EngineRules
    {
        public static List<int> GetValidHandlingOptions(int baseHandling)
        {
            var returnval = new List<int>();

            for (int i = baseHandling; i > baseHandling/2; i--)
            {
                returnval.Add(i);
            }

            return returnval;
        }

        public static int GetHandlingDesignPointCost(int delta)
        {
            return -delta * 25;
        }

        public static decimal GetRoundedEconomy(string score, decimal economyBase)
        {
            var fivePercent = economyBase / 20;
            return Math.Ceiling(decimal.Parse(score) / fivePercent) * fivePercent;
        }

        public static int GetEconomyDesignPointCost(decimal delta, decimal economyBase)
        {
            var fivePercent = economyBase / 20;
            return (int)Math.Ceiling(delta / fivePercent) * 5;
        }
    }
}
