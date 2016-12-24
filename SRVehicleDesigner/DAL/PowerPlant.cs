using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SRVehicleDesigner
{
    [DataContract(Namespace = "")]
    public class AllowedChassisRule
    {
        [DataMember(Order = 0)]
        public ChassisGroup AllowedChassisGroup { get; private set; }
        [DataMember(Order = 1)]
        public AllowedChassisNameList AllowedChassisNameList { get; private set; }
    }

    [CollectionDataContract(ItemName = "AllowedChassisName", Namespace ="")]
    public class AllowedChassisNameList : List<string> { }

    [DataContract(Namespace = "")]
    public class PowerPlant
    {
        [DataMember(Order = 0)]
        public string Type { get; private set; }
        [DataMember(Order = 1)]
        public List<AllowedChassisRule> AllowedChassisRuleList { get; private set; }
        [DataMember(Order = 2)]
        public int SpeedBase { get; private set; }
        [DataMember(Order = 3)]
        public int SpeedMax { get; private set; }
        [DataMember(Order = 4)]
        public int AccelBase { get; private set; }
        [DataMember(Order = 5)]
        public int AccelMax { get; private set; }
        [DataMember(Order = 6)]
        public int LoadBase { get; private set; }
        [DataMember(Order = 7)]
        public int LoadMax { get; private set; }
        [DataMember(Order = 8)]
        public int Sig { get; private set; }
        [DataMember(Order = 9)]
        public decimal EconomyBase { get; private set; }
        [DataMember(Order = 10)]
        public decimal EconomyMax { get; private set; }
        [DataMember(Order = 11)]
        public string EconomyUnit { get; private set; }
        [DataMember(Order = 12)]
        public int FuelSizeBase { get; private set; }
        [DataMember(Order = 13)]
        public string FuelSizeUnit { get; private set; }
        [DataMember(Order = 14)]
        public int DesignPoints { get; private set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
