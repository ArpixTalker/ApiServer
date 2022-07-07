using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using ApiServer.Domain;
using System.Windows.Input;

namespace ModuleA.ViewModels
{
    public class SettingViewModel : PropertyBasedViewModel
    {
        private bool _noAuthAllowedIsChanged;

        private bool _apiKeyStringIsChanged;
        private bool _apiKeyAllowedIsChanged;

        private bool _bearerTokenStringIsChanged;
        private bool _bearerTokenAllowedIsChanged;

        private bool _basicAuthAllowedIsChanged;
        private bool _BasicAuthUserNameIsCHanged;
        private bool _basicAuthPasswordIsChanged;

        private bool _serverAvailabityIsChanged;
        private bool _getTimeAllowedIsChanged;
        private bool _getUserByIdIsChanged;
        private bool _addUserIsChanged;
        private bool _removeUsersChanged;
        private bool _disableUserIsChanged;
        private bool _getOrderByIdIsChanged;
        private bool _getOrderForUserIsChanged;
        private bool _finishOrderIsChanged;
        private bool _addOrderIsChanged;

        #region NoAuth

        public bool NoAuthAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool NoAuthAllowedIsChanged
        {
            get => this._noAuthAllowedIsChanged;
            set
            {
                this._noAuthAllowedIsChanged = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region ApiKey
        public bool ApiKeyAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }
        public bool ApiKeyAllowedIsChanged
        {
            get => _apiKeyAllowedIsChanged;
            set
            {
                this._apiKeyAllowedIsChanged = value;
                OnPropertyChanged();
            }
        }

        public string ApiKeyString
        {
            get => (string)GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool ApiKeyStringIsChanged
        {
            get { return this._apiKeyStringIsChanged; }
            set
            {
                this._apiKeyStringIsChanged = value;
                OnPropertyChanged();
            }
        }

        public string ApiKeyStringOriginalValue
        {
            get { return (string)GetOriginalValue(nameof(this.ApiKeyString)); }
        }

        #endregion

        #region BearerToken

        public bool BearerTokenAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool BearerTokenAllowedIsChanged
        {
            get => this._bearerTokenAllowedIsChanged;
            set
            {
                this._bearerTokenAllowedIsChanged = value;
                OnPropertyChanged();
            }
        }

        public string BearerTokenString
        {
            get => (string)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool BearerTokenStringIsChanged
        {
            get => this._bearerTokenStringIsChanged;
            set 
            {
                this._bearerTokenStringIsChanged = value;
                OnPropertyChanged();
            }
        }

        public string BearerTokenStringOriginalValue
        {
            get => (string)this.GetOriginalValue(nameof(this.BearerTokenString));
        }

        #endregion

        #region BasicAuth

        public bool BasicAuthAllowed
        {
            get => (bool)this.GetProperty();
            set 
            {
                this.SetProperty(value);
                this.OnPropertyChanged();
            }
        }

        public bool BasicAuthAllowedIsChanged 
        {
            get => this._basicAuthAllowedIsChanged;
            set 
            {
                this._basicAuthAllowedIsChanged = value;
                OnPropertyChanged();
            }
        }

        public string BasicAuthUserNameString 
        {
            get => (string)this.GetProperty();
            set 
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool BasicAuthUserNameStringIsChanged
        {
            get => this._BasicAuthUserNameIsCHanged;
            set 
            {
                this._BasicAuthUserNameIsCHanged = value;
                OnPropertyChanged();
            }
        }

        public string BasicAuthUserNameStringOriginalValue 
        {
            get => (string)this.GetOriginalValue(nameof(this.BasicAuthUserNameString));
        }

        public string BasicAuthPasswordString 
        {
            get => (string)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool BasicAuthPasswordStringIsChanged
        {
            get => this._basicAuthPasswordIsChanged;
            set 
            {
                this._basicAuthPasswordIsChanged = value;
                OnPropertyChanged();
            }
        }

        public string BasicAuthPasswordStringOriginalValue
        {
            get => (string)this.GetOriginalValue(nameof(this.BasicAuthPasswordString));
        }



        #endregion

        #region APIS
        public bool ServerAvailablitiyAllowed 
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool ServerAvailablitiyAllowedIsChanged
        {
            get => this._serverAvailabityIsChanged;
            set 
            {
                this._serverAvailabityIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool GetTimeAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool GetTimeAllowedIsChanged
        {
            get => this._getTimeAllowedIsChanged;
            set
            {
                this._getTimeAllowedIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool GetUserByIdAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool GetUserByIdAllowedIsChanged
        {
            get => this._getUserByIdIsChanged;
            set
            {
                this._getUserByIdIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool AddUserIsAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool AddUserIsAllowedIsChanged
        {
            get => this._addUserIsChanged;
            set
            {
                this._addUserIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool RemoveUserByIdAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool RemoveUserByIdAllowedIsChanged
        {
            get => this._removeUsersChanged;
            set
            {
                this._removeUsersChanged = value;
                OnPropertyChanged();
            }
        }

        public bool GetOrderByIdAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool GetOrderByIdAllowedIsChanged
        {
            get => this._getOrderByIdIsChanged;
            set
            {
                this._getOrderByIdIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool AddOrderAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool AddOrderAllowedIsChanged
        {
            get => this._addOrderIsChanged;
            set
            {
                this._addOrderIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool FinishOrderAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool FinishOrderAllowedIsChanged
        {
            get => this._finishOrderIsChanged;
            set
            {
                this._finishOrderIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool GetOrdersForUserAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool GetOrdersForUserAllowedIsChanged
        {
            get => this._getOrderForUserIsChanged;
            set
            {
                this._getOrderForUserIsChanged = value;
                OnPropertyChanged();
            }
        }

        public bool DisableUserAllowed
        {
            get => (bool)this.GetProperty();
            set
            {
                this.SetProperty(value);
                OnPropertyChanged();
            }
        }

        public bool DisableUserAllowedIsChanged
        {
            get => this._disableUserIsChanged;
            set
            {
                this._disableUserIsChanged = value;
                OnPropertyChanged();
            }
        }



        #endregion

        private ICommand _updateCHangesCommand;


        public SettingViewModel()
        {
            this.NoAuthAllowed = false;

            this.ApiKeyAllowed = true;
            this.ApiKeyString = "SomeAPIKEyString";

            this.BearerTokenAllowed = true;
            this.BearerTokenString = "SomeBearerTokenString";

            this.BasicAuthAllowed = true;
            this.BasicAuthUserNameString = "SomeUsername";
            this.BasicAuthPasswordString = "SomePassword";

            this._updateCHangesCommand = new DelegateCommand(() => UpdateChanges(), () => CanUpdateChanges());

            this.ServerAvailablitiyAllowed = true;
            this.GetTimeAllowed = true;
            this.GetUserByIdAllowed = true;
            this.AddUserIsAllowed = true;
            this.RemoveUserByIdAllowed = true;
            this.GetOrderByIdAllowed = true;
            this.GetOrdersForUserAllowed = true;
            this.FinishOrderAllowed = true;
            this.DisableUserAllowed = true;
            this.AddOrderAllowed = true;
        }


        public ICommand UpdateChangesCommand => this._updateCHangesCommand;

        protected override void AcceptChanges() 
        {
            // TODO: Reset original values and clear changed values
        }

        private void UpdateChanges() {
        
            // TODO: Update to database
        }

        private bool CanUpdateChanges() 
        {
            return base.HasChanges;
        }
    }
}
