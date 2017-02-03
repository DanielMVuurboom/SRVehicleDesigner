using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRVehicleDesigner.BLL;
using SRVehicleDesigner.DAL;
using System.Reflection;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections;

namespace SRVehicleDesigner.ViewModels
{
    public class VehicleViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public Chassis BaseChassis { get; private set; }
        public PowerPlant BasePowerPlant { get; private set; }

        public ChassisGroup ChassisGroup => BaseChassis.ChassisGroup;
        public string Chassis => BaseChassis.Name;
        public PowerPlantType PowerPlant => BasePowerPlant.Type;
        public bool Drone { get; private set; }
        public string Name { get { return _name; } set { SetProperty(ref _name, value); } }
        private string _name;

        public int Body { get; private set; }
        public int Armor { get; private set; }
        public decimal CargoFactor { get { return _cargoFactor; } set { SetProperty(ref _cargoFactor, value); } } 
        private decimal _cargoFactor;
        public decimal CargoFactorFree { get { return _cargoFactorFree; } private set { SetProperty(ref _cargoFactorFree, value); } }
        private decimal _cargoFactorFree;
        public decimal Load { get { return _load; } set { SetProperty(ref _load, value); } }
        private decimal _load;
        public decimal LoadFree { get { return _loadFree; } private set { SetProperty(ref _loadFree, value); } }
        private decimal _loadFree;

        public int RoadHandling { get { return _roadHandling; } set { SetProperty(ref _roadHandling, value); } }
        private int _roadHandling;
        public int OffRoadHandling { get { return _offRoadHandling; } set { SetProperty(ref _offRoadHandling, value); } }
        private int _offRoadHandling;
        public int Speed { get { return _speed; } set { SetProperty(ref _speed, value); } }
        private int _speed;
        public int Accel { get { return _accel; } set { SetProperty(ref _accel, value); } }
        private int _accel;
        public decimal Economy { get { return _economy; } set { SetProperty(ref _economy, value); } }
        private decimal _economy;
        public string EconomyUnit => BasePowerPlant.EconomyUnit;
        public int FuelSize { get { return _fuelSize; } set { SetProperty(ref _fuelSize, value); } }
        private int _fuelSize;
        public string FuelSizeUnit => BasePowerPlant.FuelSizeUnit;

        public int AutoNav{ get { return _autoNav; } set { SetProperty(ref _autoNav, value); } }
        private int _autoNav;
        public int Pilot  { get { return _pilot; } set { SetProperty(ref _pilot, value); } }
        private int _pilot;
        public int Sensor { get { return _sensor; } set { SetProperty(ref _sensor, value); } }
        private int _sensor;
        public int Sig    { get { return _sig; } set { SetProperty(ref _sig, value); } }
        private int _sig;
        public int Ecm    { get { return _ecm; } set { SetProperty(ref _ecm, value); } }
        private int _ecm;
        public int Eccm   { get { return _eccm; } set { SetProperty(ref _eccm, value); } }
        private int _eccm;
        public int Ed    { get { return _ed; } set { SetProperty(ref _ed, value); } }
        private int _ed;
        public int Ecd { get { return _ecd; } set { SetProperty(ref _ecd, value); } }
        private int _ecd;

        public int SetupTime { get; private set; }
        public TakeOffProfile TakeOffProfile => BaseChassis.TakeOffProfile;

        public List<Seating> SeatingList { get; private set; }
        public List<EntryPoint> EntryPointList { get; private set; }
        public List<Accessory> AccessoryList { get; private set; }

        public int DesignPoints { get { return _designPoints; } private set { SetProperty(ref _designPoints, value); OnPropertyChanged("Cost"); } }
        private int _designPoints;
        public double DesignMultiplier { get { return _designMultiplier; } private set { SetProperty(ref _designMultiplier, value); OnPropertyChanged("Cost"); } }
        private double _designMultiplier;
        public int Cost => Convert.ToInt32(Math.Round(DesignMultiplier * DesignPoints * 100));

        public bool HasErrors { get { return _validationErrors.Count > 0; } }
        private Dictionary<string, ICollection<string>> _validationErrors = new Dictionary<string, ICollection<string>>();

        public bool InitializationComplete = false;

        public VehicleViewModel(Chassis chassis, PowerPlant powerPlant, bool drone)
        {
            BaseChassis = chassis;
            BasePowerPlant = powerPlant;
            Drone = drone;

            Name = "Unnamed " + Chassis;

            Body = BaseChassis.Body;
            Armor = BaseChassis.Armor;
            CargoFactor = BaseChassis.CargoFactorBase;
            CargoFactorFree = CargoFactor;
            Load = BasePowerPlant.LoadBase;
            LoadFree = Load;

            RoadHandling = BaseChassis.RoadHandling;
            OffRoadHandling = BaseChassis.OffRoadHandling;
            Speed = BasePowerPlant.SpeedBase;
            Accel = BasePowerPlant.AccelBase;
            Economy = BasePowerPlant.EconomyBase;
            FuelSize = BasePowerPlant.FuelSizeBase;

            AutoNav = BaseChassis.AutoNav;
            Pilot = BaseChassis.Pilot;
            Sensor = BaseChassis.Sensor;
            Sig = BasePowerPlant.Sig;

            SetupTime = BaseChassis.SetupTime;

            SeatingList = new List<Seating>(BaseChassis.SeatingList);
            EntryPointList = new List<EntryPoint>(BaseChassis.EntryPointList);
            AccessoryList = BaseChassis.AccessoryList.OrderBy(a => a.ToString()).ToList();

            DesignPoints = BaseChassis.DesignPoints + BasePowerPlant.DesignPoints;
            DesignMultiplier = CostCalculation.CalculateDesignMultiplier(ChassisGroup, Drone, AccessoryList);
        }
        
        public VehicleViewModel() { }

        internal void Apply(Adjustment adjustment)
        {
            if (adjustment.IsValid)
            {
                DesignPoints += adjustment.DesignPointCost;
                LoadFree -= adjustment.LoadReduction;
                //NOTE: if Load/CF ajustment is invalid (because the *Max is exceed), their Apply will not be executed, resulting in negative *Free values.
                if (LoadFree < 0)
                {
                    Load -= LoadFree;
                }
                CargoFactorFree -= adjustment.CargoFactorReduction;
                if (CargoFactorFree < 0)
                {
                    CargoFactor -= CargoFactorFree;
                }
                AccessoryList = AccessoryList.Union(adjustment.AccessoriesToAdd).Except(adjustment.AccessoriesToRemove).OrderBy(a => a.ToString()).ToList();
            }
        }

        protected void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(member, val)) return;
            if (InitializationComplete)
            {
                var adjustment = new Adjustment(propertyName, BaseChassis, BasePowerPlant, member, val);
                if (adjustment.IsValid)
                {
                    Apply(adjustment);
                    member = val;
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    if (_validationErrors.ContainsKey(propertyName))
                    {
                        _validationErrors.Remove(propertyName);
                    }
                }
                else
                {
                    if (!_validationErrors.ContainsKey(propertyName))
                    {
                        _validationErrors.Add(propertyName, new List<string>());
                    }
                    _validationErrors[propertyName].Add(adjustment.GetValidationMessage());
                    RaiseErrorsChanged(propertyName);
                }
            }
            else
            {
                member = val;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)
            || !_validationErrors.ContainsKey(propertyName))
                return null;

            return _validationErrors[propertyName];
        }

        private void RaiseErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    }
}
