using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using SRVehicleDesigner.DAL;
using SRVehicleDesigner.ViewModels;

namespace SRVehicleDesigner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeAutoMapper();
            base.OnStartup(e);
        }

        private void InitializeAutoMapper()
        {
            Mapper.Initialize(cfg => { cfg.CreateMap<Vehicle, VehicleViewModel>(); cfg.CreateMap<VehicleViewModel, Vehicle>(); });
            Mapper.AssertConfigurationIsValid();
        }
    }
}
