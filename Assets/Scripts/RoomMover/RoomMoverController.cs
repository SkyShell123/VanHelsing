using System;
using BeastHunter;
using BeastHunterHubUI;


public class RoomMoverController: IDisposable
{
    private IRoomHandler _hundler;
    private IHubUI _ui;
    private IPathHandler _pathHandler;
    private WorkRoomType _currentRoom;

    public RoomMoverController(IRoomHandler hundler, IHubUI ui, IPathHandler pathHandler)
    {
        ui.OnChangeRoom += MoveTo;
        _currentRoom = WorkRoomType.Workshop;
        _pathHandler = pathHandler;
        _hundler = hundler;
        _ui = ui;
    }

    private async void MoveTo(WorkRoomType room)
    {
        _ui.Close();
        await _hundler.MoveTo(room, _pathHandler.GetPositions(_currentRoom, room));
        _currentRoom = room;
        _ui.Open();
    }

    public void Dispose()
    {
        _ui.OnChangeRoom -= MoveTo;
    }
}