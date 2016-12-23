using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner
{
    public class Vehicle
    {
        private Chassis _baseChassis;
        private PowerPlant _basePowerPlant;

        public ChassisGroup ChassisGroup => _baseChassis.ChassisGroup;
        public string Chassis => _baseChassis.Name;
        public string PowerPlant => _basePowerPlant.Type;
        public bool Drone { get; private set; }
        public string Name { get; set; }

        public int Body { get; private set; }
        public int Armor { get; private set; }
        public int CargoFactor { get; private set; }
        public int Load { get; private set; }

        public int RoadHandling { get; private set; }
        public int OffRoadHandling { get; private set; }
        public int Speed { get; private set; }
        public int Accel { get; private set; }
        public double Economy { get; private set; }
        public string EconomyUnit => _basePowerPlant.EconomyUnit;
        public int FuelSize { get; private set; }
        public string FuelSizeUnit => _basePowerPlant.FuelSizeUnit;

        public int AutoNav { get; private set; }
        public int Pilot { get; private set; }
        public int Sensor { get; private set; }
        public int Sig { get; private set; }

        public int SetupTime { get; private set; }
        public TakeOffProfile TakeOffProfile => _baseChassis.TakeOffProfile;

        public List<Seating> SeatingList { get; private set; }
        public List<EntryPoint> EntryPointList { get; private set; }
        public List<Accessory> AccessoryList { get; private set; }

        public int DesignPoints { get; private set; }
        public double DesignMultiplier { get; private set; }
        public int Cost => Convert.ToInt32(Math.Round(DesignMultiplier * DesignPoints * 100));

        public Vehicle(Chassis chassis, PowerPlant powerPlant, bool drone)
        {
            _baseChassis = chassis;
            _basePowerPlant = powerPlant;
            Drone = drone;

            Name = "Unnamed " + Chassis;

            Body = _baseChassis.Body;
            Armor = _baseChassis.Armor;
            CargoFactor = _baseChassis.CargoFactorBase;
            Load = _basePowerPlant.LoadBase;

            RoadHandling = _baseChassis.RoadHandling;
            OffRoadHandling = _baseChassis.OffRoadHandling;
            Speed = _basePowerPlant.SpeedBase;
            Accel = _basePowerPlant.AccelBase;
            Economy = _basePowerPlant.EconomyBase;
            FuelSize = _basePowerPlant.FuelSizeBase;

            AutoNav = _baseChassis.AutoNav;
            Pilot = _baseChassis.Pilot;
            Sensor = _baseChassis.Sensor;
            Sig = _basePowerPlant.Sig;

            SetupTime = _baseChassis.SetupTime;

            SeatingList = new List<Seating>(_baseChassis.SeatingList);
            EntryPointList = new List<EntryPoint>(_baseChassis.EntryPointList);
            AccessoryList = new List<Accessory>(_baseChassis.AccessoryList);

            DesignPoints = _baseChassis.DesignPoints + _basePowerPlant.DesignPoints;
            DesignMultiplier = CalculateDesignMultiplier();
        }

        private double CalculateDesignMultiplier()
        {
            double designMultiplier;

            switch (ChassisGroup)
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

            if (Drone)
            {
                designMultiplier = designMultiplier / 100;
            }
            return designMultiplier;
        }
    }
}
