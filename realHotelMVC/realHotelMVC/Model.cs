using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realHotelMVC
{
    public class Model
    {
        private Controller controller;

        public Controller Controller { get => controller; set => controller = value; }
        public void ProcessBooking(Booking booking)
        {
            if(booking.ArriveeHotel.Month == 12 && booking.NumberOfDays <3)
            {
                MessageBox.Show("Veuillez reservez plus de 2 jours");
                
            }
            else
            {
                MessageBox.Show("chambre réservée");
            }
        }
    }
}
