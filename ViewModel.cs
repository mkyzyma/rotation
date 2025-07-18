using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged("Value");
                OnPropertyChanged("Angle");
                OnPropertyChanged("AngleText");
            }
        }

        public int Angle
        {
            get
            {
                if (_value < 0)
                {
                    return 360 + _value;
                }

                return _value;
            }
        }

        public string AngleText
        {
            get
            {
                return Angle.ToString() + " º";
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
