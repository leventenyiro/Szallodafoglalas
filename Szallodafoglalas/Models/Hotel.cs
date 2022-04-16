using System;
using System.Collections.Generic;
using Szallodafoglalas.Services;

namespace Szallodafoglalas.Models
{
    public partial class Hotel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int OneBed { get; set; }
        public int TwoBed { get; set; }

        public Hotel(string name, int oneBed, int twoBed)
        {
            Id = IdGenerator.generate(6);
            Name = name;
            OneBed = oneBed;
            TwoBed = twoBed;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - Beds: (one: {OneBed}, two: {TwoBed})";
        }
    }
}
