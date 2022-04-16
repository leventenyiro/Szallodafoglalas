using System;
using System.Collections.Generic;

namespace Szallodafoglalas.Models
{
    public partial class Hotel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int OneBed { get; set; }
        public int TwoBed { get; set; }
    }
}
