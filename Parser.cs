using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCode_Galaxy_game
{
    public class Parser
    {
        public void ResultWrite(int totalResourses, WorldState actualTime, string userName)
        {
            using(StreamWriter writer = new StreamWriter(File.Open(@"F:\ConsoleApplication1\ResultWrite.txt", FileMode.Append), Encoding.Unicode))
            {
                writer.WriteLine("Name: {0}; Result: {1}; Time: {2};", userName, totalResourses, actualTime);
                writer.NewLine = "";
            }
        }
    }
}
