using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner
{
    public enum ChassisGroup { Bikes }

    public class Handling
    {
        public int Road { get; set; }
        public int OffRoad { get; set; }
    }

    public enum SeatingType { Bench, Bucket, Ejection }

    public class Seating
    {
        public SeatingType SeatingType { get; set; }
        public int SeatingCount { get; set; }
    }

    public enum EntryPointType { Door, DoubleDoor, DoubleGate, DoubleTrunkDoor, Open, Ramp, RooftopHatch, TrunkDoor }

    public class EntryPoint
    {
        public EntryPointType EntryPointType { get; set; }
        public int EntryPointCount { get; set; }
    }

    public enum TakeOffProfile { NotApplicable }

    public enum Accessory { RemoteControlInterface, RiggerAdaptation }

    public class Chassis
    {
        public ChassisGroup ChassisGroup { get; set; }
        public string Name { get; set; }
        public Handling Handling { get; set; }
        public int Body { get; set; }
        public int Armor { get; set; }
        public int StartingCargoFactor { get; set; }
        public int MaxCargoFactor { get; set; }
        public int AutoNav { get; set; }
        public int Sensor { get; set; }
        public List<Seating> SeatingList { get; set; }
        public List<EntryPoint> EntryPointList { get; set; }
        public int SetupTime { get; set; }
        public TakeOffProfile TakeOffProfile { get; set; }
        public int DesignPoints { get; set; }
        public List<Accessory> Accessories { get; set; }
    }
}
