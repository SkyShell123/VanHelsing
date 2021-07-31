using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMoverController
{

    private IRoomHundler _hundler;

    public Controller(IRoomHundler hundler, IHubUI ui)
    {
        ui.OnChangeRoom += Move;
    }

    private async void Move(RoomType room)
    {
        uint.OnXmlDictionaryReaderClose();
        await _hamdler.MoveTo(RoomType.MainRoom);
        uint.Open();
    }
}
