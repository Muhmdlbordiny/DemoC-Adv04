using DemoC_Adv04.Fifa;
using DemoC_Adv04.Youtube;
using System.Collections;

namespace DemoC_Adv04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Event Ex01
            //Ball ball = new Ball() { Id =1};
            //Console.WriteLine(ball);
            // ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);
            //Player p01 = new Player() { PlayerName = "Messi", TeamName = "miami" };
            //Player p02 = new Player() { PlayerName = "Alba", TeamName = "miami" };
            //Player p03 = new Player() { PlayerName = "Badry", TeamName = "Barchlona" };
            //Player p04 = new Player() { PlayerName = "Lmal", TeamName = "Barchlona" };
            //Player p05 = new Player() { PlayerName = "Gavi", TeamName = "Barchlona" };
            //Refree R01 = new Refree() { RefreeName = "Ibrahim Nour eldien" };
            //ball.Location = new Location() { X = 1, Y = 2, Z = 1 };
            //ball.BallLocationChange += p01.Run;
            //ball.BallLocationChange += p02.Run;
            //ball.BallLocationChange += p03.Run;
            //ball.BallLocationChange += p04.Run;
            //ball.BallLocationChange += R01.Lock;
            //ball.Location = new Location() { X = 1, Y = 8, Z = 1 };
            //Console.WriteLine("After Badry Changing with Gavi");
            //ball.BallLocationChange -= p03.Run;
            //ball.BallLocationChange += p05.Run;
            //ball.Location = new Location() { X = 1, Y = 2, Z = 3};



            //Console.WriteLine(ball); 
            #endregion
            #region Even Ex02
            //Channels channels = new Channels() { ChannelName = "AbC"};
            //channels.AddNewVedio(new Vedios() { Title = "Tiltle#1", Description = "Desc#01"});
            //Subscribes S01 = new Subscribes() { SubscriberName = "Mohamed" };
            //Subscribes S02 = new Subscribes() { SubscriberName = "Mahmoud" };
            //Subscribes S03 = new Subscribes() { SubscriberName = "Ali" };
            //Subscribes S04 = new Subscribes() { SubscriberName = "Aya" };
            //Subscribes S05 = new Subscribes() { SubscriberName = "Yara" };
            //channels.UploadVedio += S01.Notify;
            //channels.UploadVedio += S02.Notify;
            //channels.UploadVedio += S03.Notify;
            //channels.UploadVedio += S04.Notify;
            //channels.UploadVedio += S05.Notify;
            //channels.AddNewVedio(new Vedios() { Title = "Tiltle#2", Description = "Desc#02" });
            //channels.UploadVedio -= S05.Notify;
            //channels.AddNewVedio(new Vedios() { Title = "Tiltle#3", Description = "Desc#03" }); 
            #endregion
            #region HashTable
            ////Collection L Built in Datastructure in C#
            ////Lists
            ////hashtable

            ////Non-Generic
            ////Generics
            ////Lists
            ////Non-Generic -> ArrayList
            ////generic : List , Linkedlist , Stack , queue

            //// Hashtable 
            ////Generic Collection 
            ////Non Generic Collection :HashTable
            //Hashtable ht = new Hashtable();
            //Console.WriteLine($"Count : {ht.Count}");
            //ht.Add("Ahmed", 999);
            //ht.Add("Mohamed", 1000);
            //ht.Add("Yara", 1100);
            //Console.WriteLine($"Count : {ht.Count}");

            //ht["Ahmed"] = 2555; //  set & Get
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($" Key : {item.Key} , Value : {item.Value}");
            //}
            //foreach (object item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            
            ///Generic Version of The HashTable :Dictionary
            ///Dictionary<string,long> dic = new Dictionary<string,long>();
            ///dic.Add("Mido", 25455);
            ///dic.Add("Ali", 3455);
            ///dic.Add("Miso", 255);
            ///foreach ( KeyValuePair<string,long>item in dic)
            ///{
            ///    Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");
            ///}





        }
    }
}
