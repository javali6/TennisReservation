using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtReservation.Domain;

namespace TennisCourtReservation.Repository
{
    internal interface ITennisRepository
    {
        List<TennisCourt> GetAllCourts();
        List<Reservations> GetAllReservations();
        List<User> GetAllUsers();
        Reservations SaveReservations(Reservations model);
        User SaveUser(User model);

    }
}
