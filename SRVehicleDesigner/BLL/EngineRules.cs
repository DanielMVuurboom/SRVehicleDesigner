﻿using System;
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

            for (int i = baseHandling; i >= (baseHandling + 1) / 2; i--)
            {
                returnval.Add(i);
            }

            return returnval;
        }
    }
}
