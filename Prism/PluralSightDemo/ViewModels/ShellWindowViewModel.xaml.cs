using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Modules.ApiServer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Prism.Events;
using Module.ApiServer.Events;
using ApiServer.Domain;

namespace PluralSightDemo.ViewModels
{
    /// <summary>
    /// Interaction logic for MainWindowViewModel.xaml
    /// </summary>
    public partial class ShellWindowViewModel : BaseViewModel
    {

        private IRegionManager _regionManager;
        private IEventAggregator _eventAggregator;
        private int _serverStatus;

        private ICommand _navMainCommad, _navSettingsCommand;
        public ShellWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this._regionManager = regionManager;
            this._eventAggregator = eventAggregator;
            this._navMainCommad = new DelegateCommand(() => { NavigateMain(); }, () => true);
            this._navSettingsCommand = new DelegateCommand(() => { NavigateSettings(); }, () => true);
            this._eventAggregator.GetEvent<ServerStatusChangedEvent>().Subscribe(OnServerStatusChanged);
        }

        public ICommand NavigateMainCommand => this._navMainCommad;
        public ICommand NavigateSettingsCommand => this._navSettingsCommand;


        public string WindowTitle => "Api Server 0.1";

        public int ServerStatus 
        {
            get => this._serverStatus;
            set 
            {
                this._serverStatus = value;
                OnPropertyChanged();
            }
        }

        private bool CanNavigate() => true;

        private void NavigateMain() 
        {
            this._regionManager.RequestNavigate("ContentRegion", "ServerMainView");
        }

        private void NavigateSettings() 
        {
            this._regionManager.RequestNavigate("ContentRegion", "SettingsView");
        }

        private void OnServerStatusChanged(int serverStatus) 
        {
            this.ServerStatus = serverStatus;
        }
    }
}
