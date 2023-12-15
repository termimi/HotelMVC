namespace realHotelMVC
{
    public partial class View : Form
    {
        private Controller _controller = new Controller();

        public Controller Controller { get => _controller; set => _controller = value; }

        public View()
        {
            InitializeComponent();
        }

        private void Arrivee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void depart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nombrechambre_ValueChanged(object sender, EventArgs e)
        {

        }

        private void demandeSpecial_TextChanged(object sender, EventArgs e)
        {

        }

        private void booker_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ArriveeHotel = this.Arrivee.Value;
            booking.DepartHotel = this.depart.Value;
            booking.NumberOfRoom = (int)this.nombrechambre.Value;
            booking.DemandeSpecial = this.demandeSpecial.Text;
            booking.NumberOfDays = this.depart.Value.DayOfYear - this.Arrivee.Value.DayOfYear;
            this.Controller.ProcessBooking(booking);

        }

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}