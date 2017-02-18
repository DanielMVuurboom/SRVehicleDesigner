using SRVehicleDesigner.DAL;
using SRVehicleDesigner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner.BLL
{
    public static class ModificationRuleLogic
    {
        public static string CalculateFor(this Rule rule, VehicleViewModel vehicle)
        {
            switch (rule.RuleType)
            {
                case RuleType.Constant:
                    return rule.Constant.ToString();
                case RuleType.Dictionary:
                    return rule.DataDictionary[vehicle.GetType().GetProperty(rule.Base).GetValue(vehicle).ToString()];
                case RuleType.Multiplier:
                    return (rule.Constant * double.Parse(vehicle.GetType().GetProperty(rule.Base).GetValue(vehicle).ToString())).ToString();
                default:
                    return $"{rule.RuleType} not implemented";
            }
        }
    }
}
