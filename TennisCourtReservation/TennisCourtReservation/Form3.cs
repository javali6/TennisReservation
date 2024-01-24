using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisCourtReservation.Domain;
using TennisCourtReservation.Repository;

namespace TennisCourtReservation
{
    public partial class Form3 : Form
    {
        private TennisCourtReservationContext context;
        private ITennisRepository tennisRepository;

        public Form3(TennisCourtReservationContext tennisCourtReservationContext)
        {
            context = tennisCourtReservationContext;
            tennisRepository = new TennisRepository(context);
            InitializeComponent();
            ReadData();
        }

        private void ReadData()
        {
            // List<TennisCourt> courts = tennisRepository.GetAllCourts();
            var reservationsList = tennisRepository.GetAllReservations();    
            foreach (var court in reservationsList)
            {
                // courtsList.Items.Add(court.CourtName);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
