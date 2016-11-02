using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCode_Galaxy_game
{
    public class Building
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Time { get; set; }
    }
    public class Mine : Building
    {
        public void Create()
        {
            Name = "Mine";
            Cost = 300;
            Time = 20;
        }
        public void CreatePatrons (int[] sizeInfanty, int[] typePatrons, WorldState actualTime)
        {
            
        }
        public void Delivery (int[] sizeInfanty, int[] typePatrons, WorldState actualTime)
        {

        }
    }
}
