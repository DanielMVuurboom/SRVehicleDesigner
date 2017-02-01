using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRVehicleDesigner.BLL;
using SRVehicleDesigner.DAL;
using System.Reflection;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace SRVehicleDesigner.DAL
{
    [DataContract]
    public class Vehicle
    {
        [DataMember]
        public Chassis BaseChassis { get; private set; }
        [DataMember]
        public PowerPlant BasePowerPlant { get; private set; }

        [DataMember]
        public bool Drone { get; private set; }
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public int Body { get; private set; }
        [DataMember]
        public int Armor { get; private set; }
        [DataMember]
        public decimal CargoFactor { get; private set; }
        [DataMember]
        public decimal CargoFactorFree { get; private set; }
        [DataMember]
        public decimal Load { get; private set; }
        [DataMember]
        public decimal LoadFree { get; private set; }

        [DataMember]
        public int RoadHandling { get; private set; }
        [DataMember]
        public int OffRoadHandling { get; private set; }
        [DataMember]
        public int Speed { get; private set; }
        [DataMember]
        public int Accel { get; private set; }
        [DataMember]
        public decimal Economy { get; private set; }
        [DataMember]
        public int FuelSize { get; private set; }

        [DataMember]
        public int AutoNav { get; private set; }
        [DataMember]
        public int Pilot { get; private set; }
        [DataMember]
        public int Sensor { get; private set; }
        [DataMember]
        public int Sig { get; private set; }
        [DataMember]
        public int Ecm { get; private set; }
        [DataMember]
        public int Eccm { get; private set; }
        [DataMember]
        public int Ed { get; private set; }
        [DataMember]
        public int Ecd { get; private set; }

        [DataMember]
        public int SetupTime { get; private set; }

        [DataMember]
        public List<Seating> SeatingList { get; private set; }
        [DataMember]
        public List<EntryPoint> EntryPointList { get; private set; }
        [DataMember]
        public List<Accessory> AccessoryList { get; private set; }

        [DataMember]
        public int DesignPoints { get; private set; }
        [DataMember]
        public double DesignMultiplier { get; private set; }

        public void StoreVehicle(string fileName)
        {
            FileAccessHelper.SaveToFile<Vehicle>(this, fileName);
        }

        public static Vehicle GetVehicle(string fileName)
        {
            return FileAccessHelper.LoadFromFile<Vehicle>(fileName);
        }
    }
}
