using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtReservation.Domain
{
    public class Reservations
    {
        [Key]
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("TennisCourt")]
        public int TennisCourtId { get; set; }
        public DateTime ReservationTime { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPlayers { get; set; }

        public User User { get; set; } = new User();
        public TennisCourt TennisCourt { get; set; } = new TennisCourt();

    }
}
