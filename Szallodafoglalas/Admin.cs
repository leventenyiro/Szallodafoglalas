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

        private void RefreshListBoxReserveHotel()
        {
            listBoxHotel.Items.Clear();
            foreach (var item in hotelDb.Hotels)
            {
                listBoxReserveHotel.Items.Add(item.ToString()); // ez biztos jó? - hány hely van még
                int freeOneBed = hotelDb.Hotels.Where(x =>
                {
                    /*
                     *
                     *  -- az 1-es hotelben hány 1-es ágy van lefoglalva 2022-04-19-én
                            select hotel_id, count(bed)
                            from reservation
                            where bed = 1
	                            and date="2022-04-19"
                            group by hotel_id
                            having hotel_id = 1
                    */
                })
                listBoxReserveHotel.Items.Add($"{item.Name} - Ágyak száma erre a napra: (egyes: {}, kettes: {})")
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


    }
}
