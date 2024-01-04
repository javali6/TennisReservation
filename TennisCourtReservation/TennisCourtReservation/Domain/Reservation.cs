using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtReservation.Domain
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int TennisCourtId { get; set; }
        public DateTime ReservationTime { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPlayers { get; set; }

        public virtual User User { get; set; }
        public virtual TennisCourt TennisCourt { get; set; }

    }
}
