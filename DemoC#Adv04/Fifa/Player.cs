using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_Adv04.Fifa
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        
        //callBack Function 
        public void Run(Ball ball)
        {
            Console.WriteLine($"Player: {PlayerName} is Running..... at Ball {ball} ");
        }
    }
}
