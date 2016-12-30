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
    public class FileAccessHelper
    {
        internal static List<T> LoadListFromXmlFile<T>(string relativeFilePath)
        {
            string path = Path.Combine(System.Windows.Forms.Application.StartupPath, relativeFilePath);
            var dcs = new DataContractSerializer(typeof(List<T>));
            var fs = new FileStream(path, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            var returnval = (List<T>)dcs.ReadObject(reader);
            fs.Close();
            return returnval;
        }

        internal static void SaveToFile<T>(T objectToWrite, Stream fs)
        {
            var dcs = new DataContractSerializer(typeof(T));
            dcs.WriteObject(fs, objectToWrite);
            fs.Close();
        }

        internal static T LoadFromFile<T>(Stream fs)
        {
            var dcs = new DataContractSerializer(typeof(T));
            var returnval = (T)dcs.ReadObject(fs);
            fs.Close();
            return returnval;
        }

    }
}
