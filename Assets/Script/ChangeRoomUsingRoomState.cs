using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRoomUsingRoomState : MonoBehaviour
{
    [SerializeField] Text roomDescription;
    [SerializeField] RoomState currentRoomState;

    // next state is for going next state
    [SerializeField]
    RoomState[] nextRoomStateArray;


    // Start is called before the first frame update
    void Start()
    {
        roomDescription.text = currentRoomState.GetStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageRoomState();
    }


    private void ManageRoomState()
    {
        nextRoomStateArray = currentRoomState.GetNextRoomStateArray();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("1 pressed");
            currentRoomState = nextRoomStateArray[0];
            nextRoomStateArray = currentRoomState.GetNextRoomStateArray();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("2 pressed");
            currentRoomState = nextRoomStateArray[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("3 pressed");
            currentRoomState = nextRoomStateArray[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("4 pressed");
            currentRoomState = nextRoomStateArray[3];
        }

        //update room state text:
        roomDescription.text = currentRoomState.GetStory();

    }
}
