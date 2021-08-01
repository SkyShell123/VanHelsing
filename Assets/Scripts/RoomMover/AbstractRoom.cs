using System.Linq;
using BeastHunter;
using UnityEngine;

namespace RoomMover
{
    public abstract class AbstractRoom: MonoBehaviour, IRoom
    {
        [SerializeField] private Transform[] _pathToRoom;
        public Vector3[] Positions => _pathToRoom.Select(x => x.position).ToArray();
        public Quaternion[] Rotations => _pathToRoom.Select(x => x.rotation).ToArray();
    }
}