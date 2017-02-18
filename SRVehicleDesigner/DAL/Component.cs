using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner.DAL
{
    [DataContract(Namespace = "")]
    public class Component
    {
        [DataMember(Order = 0)]
        public int Level { get; private set; }
        [DataMember(Order = 1)]
        public List<Accessory> AccessoryList { get; private set; }
        [DataMember(Order = 2)]
        public int CargoFactor { get; private set; }
        [DataMember(Order = 3)]
        public int DesignPoints { get; private set; }
        [DataMember(Order = 4)]
        public int Load { get; private set; }
        [DataMember(Order = 5)]
        public string Name { get; private set; }

        public override string ToString()
        {
            return $"{Name} {Level.ToString()}".Trim();
        }
    }
}
