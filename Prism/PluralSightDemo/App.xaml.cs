using System.Windows;
using PluralSightDemo.Views;
using System.Windows.Controls;
using PluralSightDemo.Core.Regions;
using Prism.Modularity;
using Prism.Regions;
using Prism.Ioc;
using Prism.DryIoc;
using ModuleA;
using Prism.Mvvm;
using System;
using Modules.ApiServer;
using Modules.ApiServer.Views;
using ApiServer.Core.Interfaces;
using ApiServer.Core;
using ApiServer;

namespace PluralSightDemo
{
    /// <summary>
    /// Actual application class
    /// </summary>
    public partial class App : PrismApplication
    {
        /// <summary>
        /// Creates main window
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell() 
        {
            return Container.Resolve<ShellWindow>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="containerRegistry"></param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry) 
        {
            containerRegistry.RegisterForNavigation<ServerMainView>();
            containerRegistry.RegisterForNavigation<SettingsView>();
            containerRegistry.RegisterInstance<IServerInstance>(new ApiServerInstance(12345));
        }

        /// <summary>
        /// Mapps custom region adapters
        /// </summary>
        /// <param name="mappings"></param>
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings mappings)
        {
            base.ConfigureRegionAdapterMappings(mappings);
            mappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
        }

        /// <summary>
        /// Lets developer add modules to module catalogue
        /// </summary>
        /// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module_ApiServer>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) => 
            {
                var viewName = viewType.FullName;
                var assemblyName = viewType.Assembly.FullName;
                var vmName = $"{viewName.Replace("Controls", "ViewModels")}ViewModel, {assemblyName}";
                return Type.GetType(vmName);
            });
        }
    }
}
