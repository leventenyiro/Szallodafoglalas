﻿using System;
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
            listBoxReservationHotel.Items.Clear();
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
                x.OneBed,
                ReservedOneBed = hotelDb.Reservations.Where(y => y.Bed == 1 && y.HotelId == x.Id && y.Date == date).Count(),
                x.TwoBed,
                ReservedTwoBed = hotelDb.Reservations.Where(y => y.Bed == 2 && y.HotelId == x.Id && y.Date == date).Count()
            });

            foreach (var item in hotelReservations)
            {
                listBoxReservationHotel.Items.Add($"{item.Name} - (egy ágy: {item.ReservedOneBed} / {item.OneBed}, két ágy: {item.ReservedTwoBed} / {item.TwoBed})");
            }

            if (listBoxReservationHotel.Items.Count == 0)
                MessageBox.Show("Erre a napra nincs szabad szállás!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RefreshListBoxReservation()
        {
            //var reservations = hotelDb.Reservations.Select(x => new { x.Id, Hotel = hotelDb.Hotels.Where(y => y.Id == x.HotelId).Select(y => y.Name) });
            var reservations = hotelDb.Reservations.Join(hotelDb.Hotels, a => a.HotelId, b => b.Id, (a, b) => new {a, b}).ToList();
            foreach (var item in reservations)
            {
                listBoxReservation.Items.Add($"{item.a.Id} - {item.b.Name} - {item.a.Bed} - ");
            }
        }

        private void tabPageHotels_Click(object sender, EventArgs e)
        {
            RefreshListBoxHotel();
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

        private void tabPageReserve_Click(object sender, EventArgs e)
        {
            RefreshListBoxReservation();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshListBoxReserveHotel(dateTimePickerReserveDate.Value);
            //buttonReserve.Enabled = true;
        }

        private void listBoxReservationHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reservationInHotel = hotelDb.Reservations
                .Where(x => x.Id == hotelDb.Hotels.ToList()[listBoxReservationHotel.SelectedIndex].Id);
            var hotelName = hotelDb.Hotels.ToList()[listBoxReservationHotel.SelectedIndex].Name;
            foreach (var item in reservationInHotel)
            {
                listBoxReservation.Items.Add($"{item.Id} - {hotelName}({item.Bed}) ({item.Date}) - ({item.Name} - {item.Email} - {item.Tel}");
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (textBoxReserveName.Text == "" || textBoxEmail.Text == "" || textBoxTel.Text == "")
                MessageBox.Show("Valami nincs kitöltve!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            // szabad hely csekkolása

        }
    }
}
