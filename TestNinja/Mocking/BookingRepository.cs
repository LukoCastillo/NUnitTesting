using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class BookingRepository : IBookingRepository
    {
        public IQueryable<Booking> GetActiveBookings(int? exclutedBookingId = null)
        {

            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b => b.Status != "Cancelled");
            if (exclutedBookingId.HasValue)
            {
                bookings = bookings.Where(b => b.Id != exclutedBookingId.Value);
            }

            return bookings;
        }
    }

    public interface IBookingRepository
    {
        IQueryable<Booking> GetActiveBookings(int? exclutedBookingId = null);
    }
}
