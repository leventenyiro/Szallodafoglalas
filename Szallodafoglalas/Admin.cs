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
    public partial class Admin : Form
    {
        private HotelDb hotelDb;
        public Admin()
        {
            InitializeComponent();
            hotelDb = new HotelDb();
            RefreshListBoxHotel();
        }

        private void RefreshListBoxHotel()
        {
            listBoxReserveHotel.Items.Clear();
            foreach (var item in hotelDb.Hotels)
            {
                listBoxHotel.Items.Add(item.ToString());
            }
        }

        private void RefreshListBoxReserveHotel(DateTime date)
        {
            listBoxHotel.Items.Clear();
            /*foreach (var item in hotelDb.Hotels)
            {
                listBoxReserveHotel.Items.Add(item.ToString()); // ez biztos jó? - hány hely van még
                /*
                    -- az 1-es hotelben hány 1-es ágy van lefoglalva 2022-04-19-én
                    select id, name, onebed - (select count(*) from reservation where hotel_id = hotel.id and bed = 1 and date = "2022-04-19") as "freeOneBed",
	                    twobed - (select count(*) from reservation where hotel_id = hotel.id and bed = 2 and date = "2022-04-19") as "freeTwoBed"
                    from hotel
                
                // int oneBedReservation = hotelDb.Reservations.Where(x => x.Bed == 1 && x.HotelId == item.Id && x.Date == date).Count();
                try
                {
                    //List<Reservation> reservations = hotelDb.Reservations.ToList();
                    //int oneBedReservation = reservations.Where(x => x.Bed == 1 && x.HotelId == item.Id && x.Date == date).Count();
                    //int twoBedReservation = hotelDb.Reservations.Where(x => x.Bed == 2 && x.HotelId == item.Id).Count();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }*/

            var hotelReservations = hotelDb.Hotels.Select(x => new {
                x.Id,
                x.Name,
                freeOneBed = x.OneBed - hotelDb.Reservations.Where(y => y.Bed == 1 && y.HotelId == x.Id && y.Date == date).Count(),
                freeTwoBed = x.TwoBed - hotelDb.Reservations.Where(y => y.Bed == 2 && y.HotelId == x.Id && y.Date == date).Count()
            });

            foreach (var item in hotelReservations)
            {
                listBoxReserveHotel.Items.Add($"{item.Name} - Ágyak száma erre a napra: (egyes: {item.freeOneBed}, kettes: {item.freeTwoBed})");
            }
        }

        private void buttonAddHotel_Click(object sender, EventArgs e)
        {
            if (textBoxHotelName.TextLength == 0)
                MessageBox.Show("Nincs megadva a hotel neve!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (numericUpDownOneBed.Value == 0 && numericUpDownTwoBed.Value == 0)
                MessageBox.Show("Legalább egy szobát tartalmaznia kell a hotelnek!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    hotelDb.Add(new Hotel(textBoxHotelName.Text, (int)numericUpDownOneBed.Value, (int)numericUpDownTwoBed.Value));
                    hotelDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Szerverhiba!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshListBoxHotel();
                    
                    textBoxHotelName.Text = "";
                    numericUpDownOneBed.Value = 0;
                    numericUpDownTwoBed.Value = 0;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshListBoxReserveHotel(dateTimePickerReserveDate.Value);
        }
    }
}
