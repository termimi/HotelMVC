using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realHotelMVC
{
    public class Controller
    {
        private View _view;
        private Model _model = new Model();

        public View View { get => _view; set => _view = value; }
        public Model Model { get => _model; set => _model = value; }

        public void ProcessBooking(Booking booking)
        {
            Model.ProcessBooking(booking);
        }
    }
}
