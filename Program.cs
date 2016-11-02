using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCode_Galaxy_game
{
    class Program
    {
        //public static TimeSpan operator + (TimeSpan time1, TimeSpan time2)
        //{
        //    return time1.Add(time2);
        //}
        static void Main(string[] args)
        {
            WorldState actualTime = new WorldState();
            Infanty inf = new Infanty();
            inf.Create();
            Hammer inf2 = new Hammer();
            inf2.Create();
            Infanty inf1 = new Infanty();
            inf1.Create();
            Hammer inf3 = new Hammer();
            inf3.Create();
            Parser pars = new Parser();
            pars.ResultWrite(100, actualTime, "Dima");
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}",inf.Damage,inf1.Damage,inf2.Damage,inf3.Damage,inf.Name,inf1.Name,inf3.Name);
            Console.ReadKey();
        }
    }
}
