using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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
    }

    public class Electronics
    {
        public List<Component> AutoNavList { get; private set; }
        public List<Component> PilotList { get; private set; }
        public List<Component> SensorList { get; private set; }
        public List<Component> EcmList { get; private set; }
        public List<Component> EccmList { get; private set; }
        public List<Component> EdList { get; private set; }
        public List<Component> EcdList { get; private set; }

        public static Electronics LoadData()
        {
            var electronics = new Electronics();

            electronics.AutoNavList = Helper.LoadXmlFile<Component>("Resources\\AutoNavList.xml");
            electronics.PilotList = Helper.LoadXmlFile<Component>("Resources\\PilotList.xml");
            electronics.SensorList = Helper.LoadXmlFile<Component>("Resources\\SensorList.xml");
            electronics.EcmList = Helper.LoadXmlFile<Component>("Resources\\EcmList.xml");
            electronics.EccmList = Helper.LoadXmlFile<Component>("Resources\\EccmList.xml");
            electronics.EdList = Helper.LoadXmlFile<Component>("Resources\\EdList.xml");
            electronics.EcdList = Helper.LoadXmlFile<Component>("Resources\\EcdList.xml");

            return electronics;
        }
    }
}
