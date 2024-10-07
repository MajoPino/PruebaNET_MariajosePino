using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Repositories;
public interface IRoomTypeRepository
{
     //Get all room types
    Task<IEnumerable<RoomType>> GetRoomTypes ();
    //Get a room type with its id
    Task<RoomType> GetRoomTypeById (int id);
}
