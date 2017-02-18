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
        public List<Modification> Modifications { get; private set; }

        private static DataStore _defaultDataStore;

        public static DataStore DataStoreSingleton { get { return GetDefaultDataStore(); } }

        public static DataStore GetDefaultDataStore()
        {
            if (_defaultDataStore == null)
            {
                _defaultDataStore = new DataStore();

                _defaultDataStore.BooleanList = new List<bool>();
                _defaultDataStore.BooleanList.Add(false);
                _defaultDataStore.BooleanList.Add(true);

                _defaultDataStore.Electronics = Electronics.GetDefaultElectronics();
                PowerPlant.LoadFuelTankList();

                _defaultDataStore.ChassisList = FileAccessHelper.LoadListFromXmlFile<Chassis>("Resources\\ChassisList.xml");
                _defaultDataStore.PowerPlantList = FileAccessHelper.LoadListFromXmlFile<PowerPlant>("Resources\\PowerPlantList.xml");
                _defaultDataStore.Modifications = FileAccessHelper.LoadListFromXmlFile<Modification>("Resources\\ModificationList.xml");
            }
            return _defaultDataStore;
        }
    }
}
