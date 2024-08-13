using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_Adv04.Youtube
{
    internal class Channels
    {
        public string ChannelName {  get; set; }
        List<Vedios> vedios {  get; set; }
        public void AddNewVedio(Vedios Vedios)
        {
            vedios.Add(Vedios);
            //notfiy subscriber
            UploadVedio?.Invoke(Vedios,this);
        }
        public event Action<Vedios,Channels>? UploadVedio;
        public override string ToString()
        {
            return $"Channel Name : {ChannelName}";
        }
        public Channels()
        {
            vedios = new List<Vedios>();
        }
    }
}
