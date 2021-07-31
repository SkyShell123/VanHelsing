using BeastHunter;
using UnityEngine;

namespace RoomMover
{
    public abstract class AbstractRoom: MonoBehaviour, IRoom
    {
        public Vector3 Position => transform.position;
    }
}