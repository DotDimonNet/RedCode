using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCode_Galaxy_game
{
    public class Soldier
    {
        WorldState actualTime = new WorldState();
        Random random = new Random();
        public int Power { get; set; }
        public double Reload { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
    
        public void AttackHighLevel(double Reload, int Damage, int armySize, WorldState actualTime)
        {

        }
        public void AttackLowLevel(double Reload, int Damage, int armySize, WorldState actualTime)
        {

        }
        public void Repair(int health, WorldState actualTime)
        {

        }
        public Random Random()
        {
            Random random = new Random((int)DateTime.Now.Millisecond);
            return random;
        }
    }
    public class Infanty : Soldier
    {
        public int number;
        public void Create()
        {
            number++;
            Cost = 50;
            Name = "Galaxy Cat " + number;
            Power = 20;
            Health = 100;
            Reload = 0.1;
            Damage = Random().Next(Power - 4, Power + 7); 
        }
        public void HorrorAttack(WorldState actualTime)
        {
            AttackLowLevel(Reload, Damage, number, actualTime);
            Repair(Health, actualTime);
        }
    }
    class Hammer : Soldier
    {
        public int number;
        Random random = new Random();
        public void Create()
        {
            number++;
            Cost = 150;
            Name = "Mercedes " + number;
            Power = 50;
            Health = 200;
            Reload = 0.5;
            Damage = Random().Next(Power - 5, Power + 10);
        }
        public void BaseAttack(WorldState actualTime)
        {
            AttackLowLevel(Reload, Damage, number, actualTime);
            AttackHighLevel(2 * Reload, Damage, 1, actualTime);
        }
    }
    class Tank : Soldier
    {
        public int number;
        Random random = new Random();
        public void Create()
        {
            number++;
            Cost = 300;
            Name = "Leopard " + number;
            Power = 100;
            Health = 500;
            Reload = 1.0;
            Damage = Random().Next(Power - 5, Power + 20);
        }
        public void BaseAttack(WorldState actualTime)
        {
            AttackLowLevel(0.5 * Reload, Damage, number, actualTime);
            AttackHighLevel(Reload, Damage, number, actualTime);
        }
        public void MassiveAttack(WorldState actualTime)
        {
            AttackHighLevel(2 * Reload, 2 * Damage, number, actualTime);
            actualTime.CreateTimeExpressions();
        }
    }
}
