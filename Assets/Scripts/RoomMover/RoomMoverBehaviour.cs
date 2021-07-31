using System;
using System.Threading.Tasks;
using BeastHunter;
using UnityEngine;


namespace RoomMover
{
    public class RoomMoverBehaviour: IRoomHandler
    {
        [Serializable]
        public struct Room
        {
            public AbstractRoom room;
            public RoomType Type;
        }
        [SerializeField] private Room[] _rooms;

        public Task MoveTo(RoomType room)
        {
            
        }
    }
}