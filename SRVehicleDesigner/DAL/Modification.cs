using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using NUnit.Framework;

namespace SRVehicleDesigner.DAL
{
    [DataContract(Namespace = "")]
    public enum RuleType {[EnumMember]Constant, [EnumMember]Multiplier, [EnumMember]Dictionary, [EnumMember]ModificationLevelMultiplier }

    [DataContract(Namespace = "")]
    public enum ModificationType {[EnumMember]Single, [EnumMember]Level, [EnumMember]Numeric }

    [DataContract(Namespace = "")]
    public class Rule
    {
        [DataMember(Order = 0)]
        public RuleType RuleType { get; private set; }
        [DataMember(Order = 1)]
        public string Base { get; private set; }
        [DataMember(Order = 2)]
        public double Constant { get; private set; }
        [DataMember(Order = 3)]
        public Dictionary<string, string> DataDictionary { get; private set; }
        [DataMember(Order = 4)]
        public string RuleExplanation { get; private set; }
    }

    [DataContract(Namespace = "")]
    public class Modification
    {
        [DataMember(Order = 0)]
        public string Name { get; private set; }
        [DataMember(Order = 1)]
        public int Level { get; private set; }
        [DataMember(Order = 2)]
        public List<Accessory> AccessoryList { get; private set; }
        [DataMember(Order = 3)]
        public Rule CargoFactorRule { get; private set; }
        [DataMember(Order = 4)]
        public Rule DesignPointRule { get; private set; }
        [DataMember(Order = 5)]
        public Rule LoadRule { get; private set; }
        [DataMember(Order = 6)]
        public Rule MaximumRule { get; private set; }
        [DataMember(Order = 7)]
        public ModificationType ModificationType { get; private set; }


        public override string ToString()
        {
            return (ModificationType == ModificationType.Level) ? $"{Name} {Level.ToString()}" : $"{Name}";
        }

    }
}
