using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFakesLiftoff.Core.Service
{
    public class AppService : IAppService
    {
        public string DisplayCurrentTimeOfDay()
        {
            return DateTime.Now.TimeOfDay.ToString();
        }

        public string GetCurrentWeather()
        {
            // Do it with some network stuff
            return "Sonny";
        }
    }
}
