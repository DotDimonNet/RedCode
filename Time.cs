using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCode_Galaxy_game
{
    public class WorldState
    {
        public void CreateTimeExpressions()
        {
            TimeSpan actualTime = new TimeSpan(0, 0, 0);
            TimeSpan repairTime = new TimeSpan(0, 0, 5);
            TimeSpan attackLowTime = new TimeSpan(0, 0, 3);
            TimeSpan attackHighTime = new TimeSpan(0, 0, 5);
            TimeSpan attackReloadTime = new TimeSpan(0, 0, 1);
            TimeSpan attackLightUfoTime = new TimeSpan(0, 0, 3);
            TimeSpan attackMediumUfoTime = new TimeSpan(0, 0, 4);
            TimeSpan attackHeavyUfoTime = new TimeSpan(0, 0, 5);
        }
        public TimeSpan Time(TimeSpan actualTime)
        {
            return actualTime;
        }
    }
}
