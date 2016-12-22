using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SRVehicleDesigner
{
    [DataContract(Namespace = "")]
    public enum ChassisGroup { Bikes }

    [DataContract(Namespace = "")]
    public class Handling
    {
        public int Road { get; set; }
        public int OffRoad { get; set; }
    }

    [DataContract(Namespace = "")]
    public enum SeatingType { Bench, Bucket, Ejection }

    [DataContract(Namespace = "")]
    public class Seating
    {
        [EnumMember]
        public SeatingType SeatingType;
        [DataMember]
        public int SeatingCount { get; set; }
    }

    [DataContract(Namespace = "")]
    public enum EntryPointType { Door, DoubleDoor, DoubleGate, DoubleTrunkDoor, Open, Ramp, RooftopHatch, TrunkDoor }

    [DataContract(Namespace = "")]
    public class EntryPoint
    {
        [EnumMember]
        public EntryPointType EntryPointType;
        [DataMember]
        public int EntryPointCount { get; set; }
    }

    [DataContract(Namespace = "")]
    public enum TakeOffProfile { NotApplicable }

    [DataContract(Namespace = "")]
    public enum Accessory { RemoteControlInterface, RiggerAdaptation }

    [DataContract(Namespace = "")]
    public class Chassis
    {
        [EnumMember]
        public ChassisGroup ChassisGroup;
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Handling Handling { get; set; }
        [DataMember]
        public int Body { get; set; }
        [DataMember]
        public int Armor { get; set; }
        [DataMember]
        public int StartingCargoFactor { get; set; }
        [DataMember]
        public int MaxCargoFactor { get; set; }
        [DataMember]
        public int AutoNav { get; set; }
        [DataMember]
        public int Sensor { get; set; }
        [DataMember]
        public List<Seating> SeatingList { get; set; }
        [DataMember]
        public List<EntryPoint> EntryPointList { get; set; }
        [DataMember]
        public int SetupTime { get; set; }
        [EnumMember]
        public TakeOffProfile TakeOffProfile;
        [DataMember]
        public int DesignPoints { get; set; }
        [DataMember]
        public List<Accessory> Accessories { get; set; }
    }
}
