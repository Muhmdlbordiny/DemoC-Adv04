using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_Adv04.Fifa
{
    internal class Refree
    {
        public string RefreeName {  get; set; }
        public void Lock(Ball ball)
        {
            Console.WriteLine($" Refree :{RefreeName} is Looking At Ball {ball} ");
        }
    }
}
