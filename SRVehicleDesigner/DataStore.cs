using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace SRVehicleDesigner
{
    public class DataStore
    {
        public List<Chassis> ChassisList { get; private set; }
        public List<ChassisGroup> ChassisGroupList { get { return ChassisList.Select(c => c.ChassisGroup).Distinct().ToList(); } }
        public List<PowerPlant> PowerPlantList { get; private set; }

        public static DataStore LoadData()
        {
            var dataStore = new DataStore();

            dataStore.ChassisList = LoadXmlFile<Chassis>("Resources\\ChassisList.xml");
            dataStore.PowerPlantList = LoadXmlFile<PowerPlant>("Resources\\PowerPlantList.xml");

            return dataStore;
        }

        private static List<T> LoadXmlFile<T>(string relativeFilePath)
        {
            string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, relativeFilePath);
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<T>));
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            return (List<T>)dcs.ReadObject(reader);
        }
    }
}
