using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRVehicleDesigner.BLL;
using System.Reflection;
using System.Runtime.Serialization;

namespace SRVehicleDesigner.DAL
{
    [DataContract]
    public class Vehicle
    {
        [DataMember]
        public Chassis BaseChassis { get; private set; }
        [DataMember]
        public PowerPlant BasePowerPlant { get; private set; }

        public ChassisGroup ChassisGroup => BaseChassis.ChassisGroup;
        public string Chassis => BaseChassis.Name;
        public PowerPlantType PowerPlant => BasePowerPlant.Type;
        [DataMember]
        public bool Drone { get; private set; }
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Body { get; private set; }
        [DataMember]
        public int Armor { get; private set; }
        [DataMember]
        public decimal CargoFactor { get; private set; }
        [DataMember]
        public decimal CargoFactorFree { get; private set; }
        [DataMember]
        public decimal Load { get; private set; }
        [DataMember]
        public decimal LoadFree { get; private set; }

        [DataMember]
        public int RoadHandling { get; private set; }
        [DataMember]
        public int OffRoadHandling { get; private set; }
        [DataMember]
        public int Speed { get; private set; }
        [DataMember]
        public int Accel { get; private set; }
        [DataMember]
        public decimal Economy { get; private set; }
        public string EconomyUnit => BasePowerPlant.EconomyUnit;
        [DataMember]
        public int FuelSize { get; private set; }
        public string FuelSizeUnit => BasePowerPlant.FuelSizeUnit;

        [DataMember]
        public int AutoNav { get; private set; }
        [DataMember]
        public int Pilot { get; private set; }
        [DataMember]
        public int Sensor { get; private set; }
        [DataMember]
        public int Sig { get; private set; }
        [DataMember]
        public int Ecm { get; private set; }
        [DataMember]
        public int Eccm { get; private set; }
        [DataMember]
        public int Ed { get; private set; }
        [DataMember]
        public int Ecd { get; private set; }

        [DataMember]
        public int SetupTime { get; private set; }
        public TakeOffProfile TakeOffProfile => BaseChassis.TakeOffProfile;

        [DataMember]
        public List<Seating> SeatingList { get; private set; }
        [DataMember]
        public List<EntryPoint> EntryPointList { get; private set; }
        [DataMember]
        public List<Accessory> AccessoryList { get; private set; }

        [DataMember]
        public int DesignPoints { get; private set; }
        [DataMember]
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
            CargoFactorFree = CargoFactor;
            Load = BasePowerPlant.LoadBase;
            LoadFree = Load;

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
            AccessoryList = BaseChassis.AccessoryList.OrderBy(a => a.ToString()).ToList();

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
                LoadFree -= adjustment.LoadReduction;
                //NOTE: if Load/CF ajustment is invalid (because the *Max is exceed), their Apply will not be executed, resulting in negative *Free values.
                if (LoadFree < 0)
                {
                    var moreLoad = new Adjustment(this, AdjustmentType.Load, Load, Load - LoadFree );
                    Apply(moreLoad);
                }
                CargoFactorFree -= adjustment.CargoFactorReduction;
                if (CargoFactorFree < 0)
                {
                    var moreCargo = new Adjustment(this, AdjustmentType.CargoFactor, CargoFactor, CargoFactor - CargoFactorFree);
                    Apply(moreCargo);
                }
                AccessoryList = AccessoryList.Union(adjustment.AccessoriesToAdd).Except(adjustment.AccessoriesToRemove).OrderBy(a => a.ToString()).ToList();
            }
        }
    }
}
