using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApiServer.Domain
{
    public abstract class PropertyBasedViewModel: BaseViewModel
    {

        private bool _hasChanghes;
        private Dictionary<string, object> _changedValues = new Dictionary<string, object>();
        private Dictionary<string, object> _originalValues = new Dictionary<string, object>();

        public bool HasChanges 
        {
            get => this._hasChanghes;
            set 
            {
                this._hasChanghes = value;
                OnPropertyChanged();
            }
        }

        protected abstract void AcceptChanges();
        
        
        protected void SetProperty(object value, [CallerMemberName] string propertyName = null)
        {
            if (this._originalValues.ContainsKey(propertyName))
            {
                var prop = this.GetType().GetProperties().FirstOrDefault(x => x.Name == propertyName + "IsChanged");

                if (!this._originalValues[propertyName].Equals(value))
                {
                    if (!this._changedValues.ContainsKey(propertyName))
                    {
                        this._changedValues.Add(propertyName, value);
                    }
                    else
                    {
                        this._changedValues[propertyName] = value;
                    }
                    prop.SetValue(this, true);
                }
                else 
                {
                    this._changedValues.Remove(propertyName);
                    prop.SetValue(this, false);    
                }
            }
            else 
            {
                this._originalValues.Add(propertyName, value);
            }
            this.HasChanges = this._changedValues.Any();
        }

        protected object GetProperty([CallerMemberName] string propertyName = null) 
        {
            if (this._changedValues.ContainsKey(propertyName))
            {
                return this._changedValues.FirstOrDefault(x => x.Key == propertyName).Value;
            }
            else if (this._originalValues.ContainsKey(propertyName))
            {
                return this._originalValues.FirstOrDefault(x => x.Key == propertyName).Value;
            }
            else 
            {
                throw new InvalidOperationException("Properties do not contain value");
            }
        }

        protected object GetOriginalValue([CallerMemberName] string propertyName = null) 
        {
            if (this._originalValues.ContainsKey(propertyName))
            {
                return this._originalValues[propertyName];
            }
            else 
            {
                return "";
            }
        }
    }
}
