using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Mvvm;
using ModuleA.ViewModels;
using Modules.ApiServer.Views;
using ApiServer.Core.Interfaces;

namespace Modules.ApiServer
{
    public class Module_ApiServer : IModule
    {
        private readonly IRegionManager _regionManager;
        public Module_ApiServer(IRegionManager _regionManager)
        {
            this._regionManager = _regionManager;
        }
        /// <summary>
        /// Event method - module is initialized
        /// </summary>
        /// <param name="containerProvider"></param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegion region = _regionManager.Regions["ContentRegion"];
            ServerMainView view1 = containerProvider.Resolve<ServerMainView>();
            region.Add(view1);
            //To display any view in region collection, it has to be in the collection and must be activated. Deactivating view does not display previous view. It has to be activated again
            region.Activate(view1);
        }

        /// <summary>
        /// Registering types
        /// </summary>
        /// <param name="containerRegistry"></param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //ViewModelLocationProvider.Register<ServerMainView>(() =>
            //{
            //    return new ServerMainViewModel() { };
            //});
        }
    }
}
