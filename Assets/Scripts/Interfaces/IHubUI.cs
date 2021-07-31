using System;
using BeastHunterHubUI;

namespace BeastHunter
{
    public interface IHubUI
    {
        event Action<WorkRoomType> OnChangeRoom;
        void Close();
        void Open();
    }
}