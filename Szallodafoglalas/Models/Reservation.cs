using System;
using System.Collections.Generic;

namespace Szallodafoglalas.Models
{
    public partial class Reservation
    {
        public string Id { get; set; } = null!;
        public string HotelId { get; set; } = null!;
        public int Bed { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
