using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szallodafoglalas.Models
{
    internal class Hotel
    {
        public string Id { get; }
        public string Name { get; }
        public int OneBed { get; }
        public int TwoBed { get; }

        public Hotel(string id, string name, int oneBed, int twoBed)
        {
            Id = id;
            Name = name;
            OneBed = oneBed;
            TwoBed = twoBed;
        }
    }
}
