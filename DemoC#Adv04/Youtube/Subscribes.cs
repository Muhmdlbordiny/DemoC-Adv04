using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_Adv04.Youtube
{
    internal class Subscribes
    {
        public string SubscriberName { get; set; }
        public void Notify(Vedios v, Channels c)
        {
            Console.WriteLine($"New vedio has been Added !! , {SubscriberName} , refer to {v} , and Channels is {c}");
        }
        public override string ToString()
        {
            return $"Subscriber Name  is {SubscriberName}";
        }

    }
}
