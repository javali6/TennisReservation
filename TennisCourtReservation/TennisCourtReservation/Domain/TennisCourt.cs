using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtReservation.Domain
{
    public class TennisCourt
    {
        [Key]
        public int TennisCourtId { get; set; }
        public string CourtName { get; set; }
        public string Location { get; set; }

        public List<Reservations> Reservations { get; set; } = new List<Reservations>();
    }
}
