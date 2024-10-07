using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Repositories;
public interface IGuestRepository
{
    //Get all guests
    Task<IEnumerable<Guest>> GetGuests ();
    //Create a new guest
    Task<Guest> CreateGuest (Guest guest);
    //Get a guest by its Id
    Task<Guest> GetGuestById (int id);
    //Update a guest
    Task<Guest> UpdateGuest (Guest guest);
    //Search a guest with a keyword
    Task<IEnumerable<Guest>> SearchGuest (string keyword);
    //Delete a guest
    Task DeleteGuest (int id);
}
