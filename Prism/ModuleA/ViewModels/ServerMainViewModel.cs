using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using ApiServer.Core.Interfaces;
using System.Windows.Input;
using System.Threading;
using Prism.Regions;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ApiServer.Domain;
using Prism.Events;
using Module.ApiServer.Events;


namespace ModuleA.ViewModels
{
    public class ServerMainViewModel : BaseViewModel
    {
        private IServerInstance _serverInstance;
        private IEventAggregator _eventAggregator;

        private ICommand _toggleServerCommand;
        private Task _serverTask;
        private CancellationTokenSource _cts;
        private string _togglebuttonText;
        private bool _serverRunning;
        

        public string ToggleButtonText 
        {
            get => this._togglebuttonText;
            set 
            {
                this._togglebuttonText = value;
                OnPropertyChanged();
            }
        }

        public ServerMainViewModel
        (
            IServerInstance serverInstance, 
            IEventAggregator eventAggregator)
        {
            this._serverInstance = serverInstance;
            this._eventAggregator = eventAggregator;

            this._toggleServerCommand = new DelegateCommand(() => ToggleServerRunning(), () => true);
            this._cts = new CancellationTokenSource();
            this.ToggleButtonText = "Start Server";
            this._serverRunning = false;
            this._eventAggregator = eventAggregator;

        }

        public ICommand ToggleServerCommand => this._toggleServerCommand;

        private void ToggleServerRunning() 
        {

            if (this._serverRunning)
            {
                
                this._eventAggregator.GetEvent<ServerStatusChangedEvent>().Publish(1);
                //this._cts.Cancel();
                this._eventAggregator.GetEvent<ServerStatusChangedEvent>().Publish(0);
                this.ToggleButtonText = "Start Server";
                this._serverRunning = false;
            }
            else 
            {
                this._eventAggregator.GetEvent<ServerStatusChangedEvent>().Publish(1);
                //this._serverTask = Task.Factory.StartNew(() => {
                //    this._serverInstance.StartServer(_cts);
                //});
                this._eventAggregator.GetEvent<ServerStatusChangedEvent>().Publish(2);
                this.ToggleButtonText = "Stop Server";
                this._serverRunning = true;
            }
        }
    }
}
