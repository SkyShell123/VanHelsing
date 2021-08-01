using UnityEngine;

namespace BeastHunter
{
    public interface IRoom
    {
        Vector3[] Positions { get; }
        Quaternion[] Rotations { get; }
    }
}