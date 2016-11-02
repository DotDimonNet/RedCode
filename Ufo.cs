using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCode_Galaxy_game
{
    public class Ufo
    {
        public int Power { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        public void MassiveAttack(int[] sizeUfo, int Damage, WorldState actualTime)
        {

        }
        public void OneAttack( int Damage, WorldState actualTime)
        {

        }
        public Random Random()
        {
            Random random = new Random((int)DateTime.Now.Millisecond);
            return random;
        }
    }
    public class Ufo_1 : Ufo
    {
        public int number;
        public void Create()
        {
            number++;
            Name = "Star Warrior Light " + number;
            Power = 20;
            Health = 60;
            Damage = Random().Next(Power - 2, Power + 2);
        }
    }
    class Ufo_2 : Ufo
    {
        public int number;
        Random random = new Random();
        public void Create()
        {
            number++;
            Name = "Star Warrior Medium " + number;
            Power = 40;
            Health = 200;
            Damage = Random().Next(Power - 2, Power + 20);
        }
    }
    class Ufo_3 : Ufo
    {
        public int number;
        Random random = new Random();
        public void Create()
        {
            number++;
            Name = "Star Warrior Heavy " + number;
            Power = 80;
            Health = 400;
            Damage = Random().Next(Power - 2, Power + 10);
        }
    }
}
