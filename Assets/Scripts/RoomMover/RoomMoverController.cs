using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using BeastHunter;
using BeastHunterHubUI;

public class RoomMoverController
{

    private IRoomHandler _hundler;

    public Controller(IRoomHandler hundler, IHubUI ui)
    {
        ui.OnChangeRoom += MoveTo;
        return new Task();
    }

    private async void MoveTo(WorkRoomType room)
    {
        uint.OnXmlDictionaryReaderClose();
        await _hundler.MoveTo(room);
        uint.Open();
    }
}
