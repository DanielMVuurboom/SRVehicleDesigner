﻿using System;
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
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, relativeFilePath);
            var dcs = new DataContractSerializer(typeof(List<T>));
            var fs = new FileStream(path, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            var returnval = (List<T>)dcs.ReadObject(reader);
            fs.Close();
            return returnval;
        }

        internal static void SaveToFile<T>(T objectToWrite, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var dcs = new DataContractSerializer(typeof(T));
                dcs.WriteObject(fs, objectToWrite);
            }
        }

        internal static T LoadFromFile<T>(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var dcs = new DataContractSerializer(typeof(T));
                var returnval = (T)dcs.ReadObject(fs);
                return returnval;
            }
        }

    }
}
