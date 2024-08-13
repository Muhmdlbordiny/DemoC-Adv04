using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_Adv04.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }
		private Location location;

		public Location Location
		{
			get { return location; }
			set {
                if (!value.Equals( location))
                {
                location = value;
                //Notify Subscribe
                BallLocationChange?.Invoke(this);

                }
                }
		}
        //Event 
        public event Action<Ball>? BallLocationChange;
        public override string ToString()
        {
            return $"{Id} , {Location}";
        }

    }
}
