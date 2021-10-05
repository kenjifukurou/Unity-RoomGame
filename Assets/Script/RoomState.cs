using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Room State Single")]
public class RoomState : ScriptableObject
{
    [TextArea(20,10)] [SerializeField] string story;
    [SerializeField] RoomState[] nextRoomState;
    

    public string GetStory()
    {
        return story;
    }

    public RoomState[] GetNextRoomStateArray()
    {
        return nextRoomState;
    }
}
