using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtReservation.Domain
{
    public class TennisCourt
    {
        public int TennisCourtId { get; set; }
        public string CourtName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
