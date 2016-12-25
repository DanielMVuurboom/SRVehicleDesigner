using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SRVehicleDesigner.DAL
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
    public enum PowerPlantType {[EnumMember]Electric, [EnumMember]Methane, [EnumMember]Gas, [EnumMember]Diesel, [EnumMember]Jet }

    [DataContract(Namespace = "")]
    public class FuelTank
    {
        [DataMember(Order = 0)]
        public PowerPlantType PowerPlantType { get; private set; }
        [DataMember(Order = 1)]
        public int CapacityIncreaseQuantum { get; private set; }
        [DataMember(Order = 2)]
        public int DesignPointCost { get; private set; }
        [DataMember(Order = 3)]
        public decimal CargoFactorReduction { get; private set; }
    }

    [DataContract(Namespace = "")]
    public class PowerPlant
    {
        private static List<FuelTank> _fuelTankList;

        [DataMember(Order = 0)]
        public PowerPlantType Type { get; private set; }
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

        public FuelTank Fueltank => _fuelTankList.First(ft => ft.PowerPlantType == Type);

        public static void LoadFuelTankList()
        {
            if (_fuelTankList == null)
            {
                _fuelTankList = Helper.LoadXmlFile<FuelTank>("Resources\\FuelTankList.xml");
            }
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
