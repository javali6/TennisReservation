using TennisCourtReservation.Domain;
using TennisCourtReservation.Repository;

namespace TennisCourtReservation
{
    public partial class Form1 : Form
    {
        private static TennisCourtReservationContext context;
        private ITennisRepository tennisRepository = new TennisRepository(context);


        public Form1(TennisCourtReservationContext tennisCourtReservationContext)
        {
            context = tennisCourtReservationContext;
            InitializeComponent();
        }

        //login
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // password
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // reservation
        private void button1_Click(object sender, EventArgs e)
        {
            (new Form3(context)).Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutButton_Click_1(object sender, EventArgs e)
        {
            (new Form2()).Show();
            //this.Close();
        }
    }
}