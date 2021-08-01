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
    public class RoomMoverBehaviour: MonoBehaviour, IRoomHandler
    {
        [SerializeField] private Room[] _rooms;
        [SerializeField] private Camera _camera;
        private Vector3 _currentRoomPosition;
        private Quaternion _currentRoomRotation;
        private bool _isStop;

        private void Start()
        {
            _currentRoomPosition = _camera.transform.position;
        }

        public async Task MoveTo(WorkRoomType room)
        {
            AbstractRoom initialRoom = _rooms.FirstOrDefault(x => x.Type == room).room;
            if (initialRoom != null)
            {
                _currentRoomPosition = initialRoom.Position;
            }
            _isStop = false;
            while (!_isStop)
            {
                await Task.Yield();
            }
        }

        public void Update()
        {
            if (_camera.transform.position != _currentRoomPosition)
            {
                _camera.transform.position = 
                    Vector3.MoveTowards(_camera.transform.position, _currentRoomPosition, 2.0f * Time.deltaTime);
                /*_camera.transform.rotation = Quaternion.Lerp(_camera.transform.rotation, _currentRoomRotation, )*/
            }
            else if (!_isStop)
            {
                _isStop = true;
            }
        }
    }
}