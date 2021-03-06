using OxyPlot;
using OxyPlot.Series;
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
            dateTimePickerReserveDateFrom.MinDate = DateTime.Now;
            RefreshComboBoxStatHotel();
            dateTimePickerStatFrom.Value = DateTime.Now;
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
            listBoxReservation.Items.Clear();

            var reservationInHotel = hotelDb.Reservations
            .Where(x => x.HotelId == hotelDb.Hotels.ToArray()[listBoxHotel.SelectedIndex].Id).OrderBy(x => x.FromDate);
                    var hotelName = hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Name;

            foreach (var item in reservationInHotel)
            {
                listBoxReservation.Items.Add($"{item.Id} - {hotelName}({item.Bed}) ({item.FromDate.ToString("yyyy-MM-dd")} - {item.ToDate.ToString("yyyy-MM-dd")}) - ({item.Name} - {item.Email} - {item.Tel}");
            }
        }

        private void RefreshComboBoxStatHotel()
        {
            comboBoxStatHotel.Items.Clear();
            foreach (var item in hotelDb.Hotels)
            {
                comboBoxStatHotel.Items.Add(item.Name);
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
                    MessageBox.Show("Szerverhiba!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshListBoxHotel();
                    RefreshComboBoxStatHotel();
                    
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
                    var reservation = new Reservation(hotelDb.Hotels.ToList()[listBoxHotel.SelectedIndex].Id, (int)numericUpDownBed.Value,
                        textBoxReserveName.Text, textBoxEmail.Text, textBoxTel.Text, dateTimePickerReserveDateFrom.Value, dateTimePickerReserveDateTo.Value);
                    hotelDb.Reservations.Add(reservation);
                    hotelDb.SaveChanges();
                    numericUpDownBed.Value = 1;
                    textBoxReserveName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxTel.Text = "";
                    dateTimePickerReserveDateFrom.Value = DateTime.Now;
                    dateTimePickerReserveDateTo.Value = dateTimePickerReserveDateFrom.Value.AddDays(1);
                    RefreshListBoxReservation();
                    MessageBox.Show($"Sikeres foglalás! Azonosító: {reservation.Id}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    textBoxId.Text = "";
                    MessageBox.Show("Sikeres törlés!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem létezik ilyen azonosítóval foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
            if (comboBoxStatHotel.SelectedIndex == -1)
                MessageBox.Show("Nincs hotel kiválasztva!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var days = (dateTimePickerStatTo.Value.Date - dateTimePickerStatFrom.Value.Date).Days + 1;
                var selectedHotel = hotelDb.Hotels.ToList()[comboBoxStatHotel.SelectedIndex];
                int maxHotel = (int)((selectedHotel.OneBed + selectedHotel.TwoBed) * (days - 1));

                int reserved = 0;
                var dateIterator = dateTimePickerStatFrom.Value.Date;
                while(dateIterator != dateTimePickerStatTo.Value.Date)
                {
                    reserved += hotelDb.Reservations.Where(x => x.HotelId == selectedHotel.Id && x.FromDate <= dateIterator && x.ToDate > dateIterator).Count();
                    dateIterator = dateIterator.AddDays(1);
                }

                var model = new PlotModel { Title = $"{selectedHotel.Name}: Foglalások aránya {dateTimePickerStatFrom.Value.ToString("yyyy.MM.dd")} és {dateTimePickerStatTo.Value.ToString("yyyy.MM.dd")} között" };
                dynamic seriesPlot = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };
                seriesPlot.Slices.Add(new PieSlice("Foglalt", reserved) { IsExploded = true, Fill = OxyColor.FromRgb(254, 154, 62) });
                seriesPlot.Slices.Add(new PieSlice("Szabad", maxHotel - reserved) { IsExploded = true, Fill = OxyColor.FromRgb(95, 173, 86) });
                model.Series.Add(seriesPlot);
                plotViewStat.Model = model;
            }
        }

        private void dateTimePickerStatFrom_ValueChanged(object sender, EventArgs e)
        {
            fromToDateSet(dateTimePickerStatFrom, dateTimePickerStatTo);
        }

        private void dateTimePickerReserveDateFrom_ValueChanged(object sender, EventArgs e)
        {
            fromToDateSet(dateTimePickerReserveDateFrom, dateTimePickerReserveDateTo);
        }

        private void fromToDateSet(DateTimePicker dateFrom, DateTimePicker dateTo)
        {
            dateTo.MinDate = dateFrom.Value.AddDays(1);
            if (dateTo.Value < dateFrom.Value)
                dateTo.Value = dateFrom.Value;
        }
    }
}
