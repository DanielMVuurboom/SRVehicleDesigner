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

        public static DataStore LoadData()
        {
            var dataStore = new DataStore();

            string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources\\ChassisList.xml");
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<Chassis>));
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            dataStore.ChassisList = (List<Chassis>)dcs.ReadObject(reader);

            return dataStore;
        }
    }
}
