using System;
using BeastHunter;
using BeastHunterHubUI;


public class RoomMoverController: IDisposable
{
    private IRoomHandler _hundler;
    private IHubUI _ui;

    public RoomMoverController(IRoomHandler hundler, IHubUI ui)
    {
        ui.OnChangeRoom += MoveTo;
        _hundler = hundler;
        _ui = ui;
    }

    private async void MoveTo(WorkRoomType room)
    {
        _ui.Close();
        await _hundler.MoveTo(room);
        _ui.Open();
    }

    public void Dispose()
    {
        _ui.OnChangeRoom -= MoveTo;
    }
}