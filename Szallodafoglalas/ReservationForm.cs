using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szallodafoglalas.AutoDir;
using Szallodafoglalas.Models;

namespace Szallodafoglalas
{
    public partial class ReservationForm : Form
    {
        HotelDb hotelDb;
        Reservation reservation;
        public ReservationForm(Reservation reservation)
        {
            InitializeComponent();
            hotelDb = new HotelDb();
            this.reservation = reservation;

            var hotelName = hotelDb.Hotels.Where(x => x.Id == reservation.HotelId).Select(x => x.Name);
            labelReservationDetails.Text = $"{reservation.Id} - {hotelName}, ágyak száma: {reservation.Bed}\n" +
                $"{reservation.Date} - {reservation.Name}\n{reservation.Email}, {reservation.Tel}";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.AddDays(1) < reservation.Date)
            {
                hotelDb.Reservations.Remove(reservation);
                hotelDb.SaveChanges();
            }
            else
                MessageBox.Show("24 órán belüli foglalást már nem lehet törölni!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
}
