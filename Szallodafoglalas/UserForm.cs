using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szallodafoglalas.AutoDir;
using Szallodafoglalas.Models;

namespace Szallodafoglalas
{
    public partial class UserForm : Form
    {
        private HotelDb hotelDb;
        public UserForm()
        {
            InitializeComponent();
            hotelDb = new HotelDb();
            RefreshListBoxHotel();
            dateTimePickerReserveDateFrom.MinDate = DateTime.Now;
        }

        private void RefreshListBoxHotel()
        {
            listBoxHotel.Items.Clear();

            foreach (var item in hotelDb.Hotels)
            {
                listBoxHotel.Items.Add(item.ToString());
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxTel.Text == "")
                MessageBox.Show("Valami nincs kitöltve!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (listBoxHotel.SelectedIndex == -1)
                MessageBox.Show("Nincs kiválasztva hotel!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(textBoxEmail.Text))
                MessageBox.Show("Helytelen e-mail cím!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$").IsMatch(textBoxTel.Text))
                MessageBox.Show("Helytelen telefonszám!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var roomInHotel = hotelDb.Hotels.Where(x => x.Id == hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id)
                    .Select(x => numericUpDownBed.Value == 1 ? x.OneBed : x.TwoBed).First();

                bool isFree = true;
                var dateIterator = dateTimePickerReserveDateFrom.Value.Date;
                while (dateIterator != dateTimePickerReserveDateTo.Value.Date && isFree)
                {
                    int reserved = hotelDb.Reservations.Where(x => x.HotelId == hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id && x.Bed == numericUpDownBed.Value && x.FromDate <= dateIterator && x.ToDate > dateIterator).Count();
                    if (reserved == roomInHotel)
                        isFree = false;
                    dateIterator = dateIterator.AddDays(1);
                }

                if (!isFree)
                    MessageBox.Show("Nincs szabad hely a megadott paraméterekkel!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var reservation = new Reservation(hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id,
                        (int)numericUpDownBed.Value, textBoxName.Text, textBoxEmail.Text, textBoxTel.Text, dateTimePickerReserveDateFrom.Value, dateTimePickerReserveDateTo.Value);
                    hotelDb.Reservations.Add(reservation);
                    hotelDb.SaveChanges();
                    numericUpDownBed.Value = 1;
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxTel.Text = "";
                    dateTimePickerReserveDateFrom.Value = DateTime.Now;
                    dateTimePickerReserveDateTo.Value = dateTimePickerReserveDateFrom.Value.AddDays(1);
                    MessageBox.Show($"Jó utat! A foglalási azonosítója: [{reservation.Id}]. Kérjük jegyezze meg jól!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
                MessageBox.Show("Nincs megadva azonosító!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    var reservation = hotelDb.Reservations.Where(x => x.Id == textBoxId.Text).First();
                    new ReservationForm(reservation).ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem létezik ilyen azonosítóval foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dateTimePickerReserveDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerReserveDateTo.MinDate = dateTimePickerReserveDateFrom.Value.AddDays(1);
            if (dateTimePickerReserveDateTo.Value < dateTimePickerReserveDateFrom.Value)
                dateTimePickerReserveDateTo.Value = dateTimePickerReserveDateFrom.Value;
        }
    }
}
