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

        private static Electronics _defaultElectronics;

        public static Electronics GetDefaultElectronics()
        {
            if (_defaultElectronics == null)
            {
                _defaultElectronics = new Electronics();

                _defaultElectronics.AutoNavList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\AutoNavList.xml");
                _defaultElectronics.PilotList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\PilotList.xml");
                _defaultElectronics.SensorList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\SensorList.xml");
                _defaultElectronics.EcmList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\EcmList.xml");
                _defaultElectronics.EccmList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\EccmList.xml");
                _defaultElectronics.EdList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\EdList.xml");
                _defaultElectronics.EcdList = FileAccessHelper.LoadListFromXmlFile<Component>("Resources\\EcdList.xml");
            }
            return _defaultElectronics;
        }
    }
}
