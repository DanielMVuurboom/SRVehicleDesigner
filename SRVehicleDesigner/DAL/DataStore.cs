using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVehicleDesigner.DAL
{
    public class DataStore
    {
        public List<Chassis> ChassisList { get; private set; }
        public List<ChassisGroup> ChassisGroupList { get { return ChassisList.Select(c => c.ChassisGroup).Distinct().ToList(); } }
        public List<PowerPlant> PowerPlantList { get; private set; }
        public List<bool> BooleanList { get; private set; }
        public Electronics Electronics { get; private set; }

        public static DataStore LoadData()
        {
            var dataStore = new DataStore();

            dataStore.BooleanList = new List<bool>();
            dataStore.BooleanList.Add(false);
            dataStore.BooleanList.Add(true);

            dataStore.Electronics = Electronics.LoadData();

            dataStore.ChassisList = Helper.LoadXmlFile<Chassis>("Resources\\ChassisList.xml");
            PowerPlant.FuelTankList = Helper.LoadXmlFile<FuelTank>("Resources\\FuelTankList.xml");
            dataStore.PowerPlantList = Helper.LoadXmlFile<PowerPlant>("Resources\\PowerPlantList.xml");

            return dataStore;
        }
    }
}
