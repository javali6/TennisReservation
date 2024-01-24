using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TennisCourtReservation.Domain;

namespace TennisCourtReservation.Repository
{
    internal class TennisRepository : ITennisRepository
    {
        private readonly TennisCourtReservationContext _context;

        public TennisRepository(TennisCourtReservationContext context)
        {
            _context = context;
        }


        public List<TennisCourt> GetAllCourts()
        {
            return _context.TennisCourt.Include(x => x.Reservations).ToList();
        }

        public List<Reservations> GetAllReservations()
        {
            return _context.Reservations.ToList();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public Reservations SaveReservations(Reservations model)
        {
            model = _context.Reservations.Add(model).Entity;
            _context.SaveChanges();
            return model;
        }

        public User SaveUser(User model)
        {
            model = _context.Users.Add(model).Entity;
            _context.SaveChanges();
            return model;
        }
    }
}
