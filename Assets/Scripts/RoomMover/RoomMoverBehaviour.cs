using System;
using System.Linq;
using System.Threading.Tasks;
using BeastHunter;
using BeastHunterHubUI;
using UnityEngine;


namespace RoomMover
{
    [Serializable]
    public struct Room
    {
        public AbstractRoom room;
        public WorkRoomType Type;
    }
    public class RoomMoverBehaviour: MonoBehaviour, IRoomHandler, IUpdate
    {
        [SerializeField] private Room[] _rooms;
        [SerializeField] private Camera _camera;
        private Vector3 _currentRoomPosition;
        private bool _isStop;

        public async Task MoveTo(WorkRoomType room)
        {
            Debug.Log(room);
            Room initialRoom = _rooms.FirstOrDefault(x => x.Type == room);
            if (initialRoom.room != null)
            {
                _currentRoomPosition = initialRoom.room.Position;
            }
            _isStop = false;
            while (_camera.transform.position != _currentRoomPosition)
            {
                await Task.Yield();
            }
        }

        public void Updating()
        {
            if (_camera.transform.position != _currentRoomPosition)
            {
                _camera.transform.position =
                    Vector3.LerpUnclamped(_camera.transform.position, _currentRoomPosition, 10);
            }
            else if (!_isStop)
            {
                _isStop = true;
            }
        }
    }
}