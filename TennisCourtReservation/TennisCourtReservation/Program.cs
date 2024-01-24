using Microsoft.EntityFrameworkCore;
using TennisCourtReservation.Domain;

namespace TennisCourtReservation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (!TennisCourtReservationContext.Instance.Database.CanConnect())
                throw new Exception("Can't connect to Database");
            
            TennisCourtReservationContext context = TennisCourtReservationContext.Instance;
            Application.Run(new Form1(context));

        }
    }
}