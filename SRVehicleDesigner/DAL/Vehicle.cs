using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRVehicleDesigner.BLL;
using System.Reflection;

namespace SRVehicleDesigner
{
    public class Vehicle
    {
        public Chassis BaseChassis { get; private set; }
        public PowerPlant BasePowerPlant { get; private set; }

        public ChassisGroup ChassisGroup => BaseChassis.ChassisGroup;
        public string Chassis => BaseChassis.Name;
        public string PowerPlant => BasePowerPlant.Type;
        public bool Drone { get; private set; }
        public string Name { get; set; }

        public int Body { get; private set; }
        public int Armor { get; private set; }
        public decimal CargoFactor { get; private set; }
        public decimal Load { get; private set; }

        public int RoadHandling { get; private set; }
        public int OffRoadHandling { get; private set; }
        public int Speed { get; private set; }
        public int Accel { get; private set; }
        public decimal Economy { get; private set; }
        public string EconomyUnit => BasePowerPlant.EconomyUnit;
        public int FuelSize { get; private set; }
        public string FuelSizeUnit => BasePowerPlant.FuelSizeUnit;

        public int AutoNav { get; private set; }
        public int Pilot { get; private set; }
        public int Sensor { get; private set; }
        public int Sig { get; private set; }

        public int SetupTime { get; private set; }
        public TakeOffProfile TakeOffProfile => BaseChassis.TakeOffProfile;

        public List<Seating> SeatingList { get; private set; }
        public List<EntryPoint> EntryPointList { get; private set; }
        public List<Accessory> AccessoryList { get; private set; }

        public int DesignPoints { get; private set; }
        public double DesignMultiplier { get; private set; }
        public int Cost => Convert.ToInt32(Math.Round(DesignMultiplier * DesignPoints * 100));

        public Vehicle(Chassis chassis, PowerPlant powerPlant, bool drone)
        {
            BaseChassis = chassis;
            BasePowerPlant = powerPlant;
            Drone = drone;

            Name = "Unnamed " + Chassis;

            Body = BaseChassis.Body;
            Armor = BaseChassis.Armor;
            CargoFactor = BaseChassis.CargoFactorBase;
            Load = BasePowerPlant.LoadBase;

            RoadHandling = BaseChassis.RoadHandling;
            OffRoadHandling = BaseChassis.OffRoadHandling;
            Speed = BasePowerPlant.SpeedBase;
            Accel = BasePowerPlant.AccelBase;
            Economy = BasePowerPlant.EconomyBase;
            FuelSize = BasePowerPlant.FuelSizeBase;

            AutoNav = BaseChassis.AutoNav;
            Pilot = BaseChassis.Pilot;
            Sensor = BaseChassis.Sensor;
            Sig = BasePowerPlant.Sig;

            SetupTime = BaseChassis.SetupTime;

            SeatingList = new List<Seating>(BaseChassis.SeatingList);
            EntryPointList = new List<EntryPoint>(BaseChassis.EntryPointList);
            AccessoryList = new List<Accessory>(BaseChassis.AccessoryList);

            DesignPoints = BaseChassis.DesignPoints + BasePowerPlant.DesignPoints;
            DesignMultiplier = CostCalculation.CalculateDesignMultiplier(ChassisGroup, Drone, AccessoryList);
        }

        internal void Apply(Adjustment adjustment)
        {
            if (adjustment.IsValid)
            {
                PropertyInfo prop = GetType().GetProperty(adjustment.AdjustmentType.ToString());
                prop.SetValue(this, adjustment.NewValue, null);
                DesignPoints += adjustment.DesignPointCost;
                Load -= adjustment.LoadReduction;
                if (Load < 0)
                {
                    var moreLoad = new Adjustment(this, AdjustmentType.Load, Load, 0);
                    Apply(moreLoad);
                }
                CargoFactor -= adjustment.CargoFactorReduction;
                if (CargoFactor < 0)
                {
                    var moreCargo = new Adjustment(this, AdjustmentType.CargoFactor, CargoFactor, 0);
                    Apply(moreCargo);
                }

            }
        }
    }
}
