using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackResults.Model
{
    public class TrackEvent
    {
        public string Name { get; set; }
        public string Time { get; set; }

        public TrackEvent(string name, string time)
        {
            Name = name;
            Time = time;
        }

        public override string ToString()
        {
            return $"{Name}\t{Time}";
        }
    }
}
