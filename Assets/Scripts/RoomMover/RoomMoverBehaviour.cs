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
    public class RoomMoverBehaviour: MonoBehaviour, IRoomHandler//, IUpdate, IStart
    {
        [SerializeField] private Room[] _rooms;
        [SerializeField] private AbstractRoom _startRoom;
        [SerializeField] private Transform _camera;
        [SerializeField] private float _cameraMoveSpeed;
        [SerializeField] private float _cameraRotateSpeed;
        private Vector3 _currentRoomPosition;
        private Quaternion _currentRoomRotation;
        private bool _isStop = true;

        public async Task MoveTo(WorkRoomType room, Vector3[] positions)
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                _rooms[i].room.gameObject.SetActive(true);
            }
            _isStop = false;
            for (int i = 0; i < positions.Length; i++)
            {
                _currentRoomRotation = Quaternion.LookRotation(positions[i] - _currentRoomPosition);
                _currentRoomPosition = positions[i];
                while (_camera.position != _currentRoomPosition || _camera.rotation != _currentRoomRotation)
                {
                    await Task.Yield();
                }
            }
            _isStop = true;
            for (int i = 0; i < _rooms.Length; i++)
            {
                if(_rooms[i].Type == room) continue;
                _rooms[i].room.gameObject.SetActive(false);
            }
        }

        public void Update()//Updating() какая-то беда, он не вызывается.
                            //я не буду с этим разбираться, пусть воюет тот, кто это вообще писал
        {
            if (!_isStop)
            {
                _camera.transform.position = 
                    Vector3.MoveTowards(_camera.position, _currentRoomPosition, _cameraMoveSpeed * Time.deltaTime);
                _camera.transform.rotation = Quaternion.RotateTowards(_camera.rotation, _currentRoomRotation,
                    _cameraRotateSpeed * Time.deltaTime);
            }
        }

        public void Start()//Starting(HubUIContext context) тоже самое
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                if (_rooms[i].room != _startRoom)
                {
                    _rooms[i].room.gameObject.SetActive(false);
                }
            }
        }
    }
}