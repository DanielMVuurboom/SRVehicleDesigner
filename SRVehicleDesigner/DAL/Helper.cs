using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace SRVehicleDesigner.DAL
{
    public class Helper
    {
        internal static List<T> LoadXmlFile<T>(string relativeFilePath)
        {
            string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, relativeFilePath);
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<T>));
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            return (List<T>)dcs.ReadObject(reader);
        }
    }
}
