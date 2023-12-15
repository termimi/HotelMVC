using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Controller
    {
        private View _view;
        private Model _model;

      
        public Model Model { get => _model; set => _model = value; }
        public View View { get => _view; set => _view = value; }
    }
}
