using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szallodafoglalas.Models
{
    internal class Reservation
    {
        public string Id { get; set; }
        public string HotelId { get; }
        public int Bed { get; }
        public string Name { get; }
        public string Email { get; }
        public string Tel { get; }
        public DateTime Date { get; }

        public Reservation(string id, string hotelId, int bed, string name, string email, string tel, DateTime date)
        {
            Id = id;
            HotelId = hotelId;
            Bed = bed;
            Name = name;
            Email = email;
            Tel = tel;
            Date = date;
        }
    }
}
