using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realHotelMVC
{
    public class Booking
    {
        private int numberOfRoom;
        private DateTime arriveeHotel;
        private DateTime departHotel;
        private string demandeSpecial;
        private int numberOfDays;

        public string DemandeSpecial { get => demandeSpecial; set => demandeSpecial = value; }
        public DateTime DepartHotel { get => departHotel; set => departHotel = value; }
        public DateTime ArriveeHotel { get => arriveeHotel; set => arriveeHotel = value; }
        public int NumberOfRoom { get => numberOfRoom; set => numberOfRoom = value; }
        public int NumberOfDays { get => numberOfDays; set => numberOfDays = value; }
    }
}
