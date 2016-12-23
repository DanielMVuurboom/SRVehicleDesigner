using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SRVehicleDesigner
{
    [DataContract(Namespace = "")]
    public enum ChassisGroup {[EnumMember]Bikes, [EnumMember]Cars }

    [DataContract(Namespace = "")]
    public class Handling
    {
        [DataMember(Order = 0)]
        public int Road { get; private set; }
        [DataMember(Order = 1)]
        public int OffRoad { get; private set; }
    }

    [DataContract(Namespace = "")]
    public enum SeatingType {[EnumMember]Bench, [EnumMember]Bucket, [EnumMember]Ejection }

    [DataContract(Namespace = "")]
    public class Seating
    {
        [DataMember(Order = 0)]
        public SeatingType SeatingType;
        [DataMember(Order = 1)]
        public int SeatingCount { get; private set; }
    }

    [DataContract(Namespace = "")]
    public enum EntryPointType {[EnumMember]Door, [EnumMember]DoubleDoor, [EnumMember]DoubleGate, [EnumMember]DoubleTrunkDoor, [EnumMember]Open, [EnumMember]Ramp, [EnumMember]RoofHatch, [EnumMember]TrunkDoor }

    [DataContract(Namespace = "")]
    public class EntryPoint
    {
        [DataMember(Order = 0)]
        public EntryPointType EntryPointType;
        [DataMember(Order = 1)]
        public int EntryPointCount { get; private set; }
    }

    [DataContract(Namespace = "")]
    public enum TakeOffProfile {[EnumMember]NotApplicable }

    [DataContract(Namespace = "")]
    public enum Accessory {[EnumMember]RemoteControlInterface, [EnumMember]RiggerAdaptation, [EnumMember]LivingAmenitiesBasic }

    [DataContract(Namespace = "")]
    public class Chassis
    {
        [DataMember(Order = 0)]
        public ChassisGroup ChassisGroup;
        [DataMember(Order = 1)]
        public string Name { get; private set; }
        [DataMember(Order = 2)]
        public Handling Handling { get; private set; }
        [DataMember(Order = 3)]
        public int Body { get; private set; }
        [DataMember(Order = 4)]
        public int Armor { get; private set; }
        [DataMember(Order = 5)]
        public int StartingCargoFactor { get; private set; }
        [DataMember(Order = 6)]
        public int MaxCargoFactor { get; private set; }
        [DataMember(Order = 7)]
        public int AutoNav { get; private set; }
        [DataMember(Order = 8)]
        public int Pilot { get; private set; }
        [DataMember(Order = 9)]
        public int Sensor { get; private set; }
        [DataMember(Order = 10)]
        public List<Seating> SeatingList { get; private set; }
        [DataMember(Order = 11)]
        public List<EntryPoint> EntryPointList { get; private set; }
        [DataMember(Order = 12)]
        public int SetupTime { get; private set; }
        [DataMember(Order = 13)]
        public TakeOffProfile TakeOffProfile;
        [DataMember(Order = 14)]
        public int DesignPoints { get; private set; }
        [DataMember(Order = 15)]
        public List<Accessory> Accessories { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
