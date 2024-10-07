using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Repositories;
public interface IRoomRepository
{
    //Get all rooms
    Task<IEnumerable<Room>> GetRooms ();
    //Get the rooms according to their availability
    Task<IEnumerable<Room>> FilterRoomsAvailability (bool availability);
    //Get a room with its id
    Task<Room> GetRoomById (int id);
}
