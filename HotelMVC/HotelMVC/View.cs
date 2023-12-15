namespace HotelMVC
{
    public partial class View : Form
    {
        private Controller _controller;

        public Controller Controller { get => _controller; set => _controller = value; }
        public View()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateArrivee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nombreDeChambre_ValueChanged(object sender, EventArgs e)
        {

        }

        private void demandeSpecial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Booker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("salut");
        }
    }
}