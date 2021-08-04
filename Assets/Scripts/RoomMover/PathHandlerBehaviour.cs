using System;
using System.Linq;
using BeastHunter;
using BeastHunterHubUI;
using UnityEngine;

namespace RoomMover
{
    [Serializable]
    public struct Path
    {
        public WorkRoomType From;
        public WorkRoomType To;
        public Transform[] Transforms;
    }
    public class PathHandlerBehaviour: MonoBehaviour, IPathHandler
    {
        [SerializeField] private Path[] _paths;
            
        public Vector3[] GetPositions(WorkRoomType from, WorkRoomType to)
        {
            Path path = _paths.FirstOrDefault(x => x.From == from && x.To == to);
            if (path.Transforms != null)
            {
                return path.Transforms.Select(x => x.position).ToArray();
            }
            return default;
        }

        public Quaternion[] GetRotations(WorkRoomType from, WorkRoomType to)
        {
            Path path = _paths.FirstOrDefault(x => x.From == from && x.To == to);
            if (path.Transforms != null)
            {
                return path.Transforms.Select(x => x.rotation).ToArray();
            }
            return default;
        }
    }
}