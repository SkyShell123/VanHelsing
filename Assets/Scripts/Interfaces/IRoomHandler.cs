using System.Threading.Tasks;
using BeastHunterHubUI;

namespace BeastHunter
{
    public interface IRoomHandler
    {
        Task MoveTo(WorkRoomType room);
    }
}