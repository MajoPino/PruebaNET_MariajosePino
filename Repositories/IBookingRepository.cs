using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Repositories;

public interface IBookingRepository
{
    //Get all bookings under an specific identification number
    Task<IEnumerable<Booking>> GetBookingsByIdentificationNumber (string identificationNumber);
    //Create an new Booking
    Task<Booking> CreateBooking (Booking booking);
    //Get a booking with its id
    Task<Booking> GetBookingById (int id);
    //Delete a booking
    Task DeleteBooking (int id);
}
