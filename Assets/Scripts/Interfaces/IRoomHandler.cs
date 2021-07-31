using System.Threading.Tasks;

namespace BeastHunter
{
    public interface IRoomHandler
    {
        Task MoveTo(RoomType room);
    }
}