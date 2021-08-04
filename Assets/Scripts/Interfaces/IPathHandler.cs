using BeastHunterHubUI;
using UnityEngine;

namespace BeastHunter
{
    public interface IPathHandler
    {
        Vector3[] GetPositions(WorkRoomType from, WorkRoomType to);
        Quaternion[] GetRotations(WorkRoomType from, WorkRoomType to);
    }
}