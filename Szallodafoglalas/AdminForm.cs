using System.Data;
using System.Text.RegularExpressions;
using Szallodafoglalas.AutoDir;
using Szallodafoglalas.Models;

namespace Szallodafoglalas
{
    public partial class AdminForm : Form
    {
        private HotelDb hotelDb;
        public AdminForm()
        {
            InitializeComponent();
            hotelDb = new HotelDb();
            RefreshListBoxHotel();
            dateTimePickerReserveDate.MinDate = DateTime.Now.AddDays(1);
        }

        private void RefreshListBoxHotel()
        {
            listBoxHotel.Items.Clear();

            foreach (var item in hotelDb.Hotels)
            {
                listBoxHotel.Items.Add(item.ToString());
            }
        }

        private void RefreshListBoxReservation()
        {
            var reservationInHotel = hotelDb.Reservations
                .Where(x => x.HotelId == hotelDb.Hotels.ToArray()[listBoxHotel.SelectedIndex].Id).OrderBy(x => x.Date);
            var hotelName = hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Name;

            listBoxReservation.Items.Clear();

            foreach (var item in reservationInHotel)
            {
                listBoxReservation.Items.Add($"{item.Id} - {hotelName}({item.Bed}) ({item.Date.ToString("yyyy-MM-dd")}) - ({item.Name} - {item.Email} - {item.Tel}");
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

        private void listBoxReservationHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBoxReservation();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (textBoxReserveName.Text == "" || textBoxEmail.Text == "" || textBoxTel.Text == "")
                MessageBox.Show("Valami nincs kitöltve!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (listBoxHotel.SelectedIndex == -1)
                MessageBox.Show("Nincs kiválasztva hotel!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(textBoxEmail.Text))
                MessageBox.Show("Helytelen e-mail cím!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$").IsMatch(textBoxTel.Text))
                MessageBox.Show("Helytelen telefonszám!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var freeRoomInHotel = hotelDb.Reservations
                    .Where(x => x.Bed == numericUpDownBed.Value && x.HotelId == hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id && x.Date == dateTimePickerReserveDate.Value).Count();

                var roomInHotel = hotelDb.Hotels.Where(x => x.Id == hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id)
                    .Select(x => numericUpDownBed.Value == 1 ? x.OneBed : x.TwoBed).First();
                if (freeRoomInHotel == roomInHotel)
                    MessageBox.Show("Nincs szabad hely a megadott paraméterekkel!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    hotelDb.Reservations.Add(new Reservation(hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id,
                        (int)numericUpDownBed.Value, textBoxReserveName.Text, textBoxEmail.Text, textBoxTel.Text, dateTimePickerReserveDate.Value));
                    hotelDb.SaveChanges();
                    numericUpDownBed.Value = 1;
                    textBoxReserveName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxTel.Text = "";
                    RefreshListBoxReservation();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
                MessageBox.Show("Nincs megadva azonosító!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    var reservation = hotelDb.Reservations.Where(x => x.Id == textBoxId.Text).First();
                    hotelDb.Reservations.Remove((Reservation)reservation);
                    hotelDb.SaveChanges();
                    RefreshListBoxReservation();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem létezik ilyen azonosítóval foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
