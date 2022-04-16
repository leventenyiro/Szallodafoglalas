using System;
using System.Collections.Generic;
using Szallodafoglalas.Services;

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

        public Reservation(string hotelId, int bed, string name, string email, string tel, DateTime date)
        {
            Id = IdGenerator.generate(6);
            HotelId = hotelId;
            Bed = bed;
            Name = name;
            Email = email;
            Tel = tel;
            Date = date;
        }
    }
}
