using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base-Class Tester");
            Player me = new Player("Fred", true, 4, false, 5, 50);
            Monster fred = new Monster();
            fred.Name = "Frederick the Fearsome";
            fred.RewardXP = 4;
            fred.RewardXP = 19;
        }
    }
}
