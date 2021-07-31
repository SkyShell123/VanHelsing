using System;

namespace BeastHunter
{
    public interface IHubUI
    {
        event Action<RoomType> OnChangeRoom;
        void Close();
        void Open();
    }
}