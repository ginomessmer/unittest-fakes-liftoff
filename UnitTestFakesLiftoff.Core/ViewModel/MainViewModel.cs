using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestFakesLiftoff.Core.Common;
using UnitTestFakesLiftoff.Core.Service;

namespace UnitTestFakesLiftoff.Core.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IAppService service;

        public string _currentWeatherText;
        public string CurrentWeatherText
        {
            get { return _currentWeatherText; }
            set
            {
                _currentWeatherText = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            service = new AppService();
            this.CurrentWeatherText = service.GetCurrentWeather();
        } 
    }
}
