using System.Threading.Tasks;
using BeastHunterHubUI;
using UnityEngine;

namespace BeastHunter
{
    public interface IRoomHandler
    {
        Task MoveTo(WorkRoomType room, Vector3[] positions);
    }
}