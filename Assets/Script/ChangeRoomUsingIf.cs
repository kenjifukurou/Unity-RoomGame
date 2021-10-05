using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRoomUsingIf : MonoBehaviour
{
    [SerializeField]
    Text text_room;

    enum Rooms
    {
        Room_01,
        Room_02,
        Room_03,
        Room_04,
        Room_05,
        Room_06,
        Room_07,
        Room_08,
        Room_09,
        Room_10,
        Room_11,
        Room_12,
        Room_13,
        Room_14,
        Room_15,
        Room_16,
        Room_17,
        Room_end
    }

    Rooms currentRoom;

    // Start is called before the first frame update
    void Start()
    {
        text_room.text = "You now at Room 1. \n enter direction to go next room:";
        currentRoom = Rooms.Room_01;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentRoom == Rooms.Room_01)
        {
            Room_01();
        }
        else if (currentRoom == Rooms.Room_02)
        {
            Room_02();
        }
        else if (currentRoom == Rooms.Room_03)
        {
            Room_03();
        }
    }

    void Room_01()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            text_room.text = "moving to next room... \n You're now at Room 3";
            currentRoom = Rooms.Room_03;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            text_room.text = "moving to next room...\n You're now at Room 2";
            currentRoom = Rooms.Room_02;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            text_room.text = "there is not way out";
        }
    }
    void Room_02()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            text_room.text = "moving to next room... \n You're now at Room 1";
            currentRoom = Rooms.Room_01;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            text_room.text = "there is not way out";
        }
    }
    void Room_03()
    {
        text_room.text = "You now at Room 3. \n ";
    }
    void Room_04()
    {
        text_room.text = "You now at Room 4. \n ";
    }
    void Room_05()
    {
        text_room.text = "You now at Room 5. \n ";
    }

}
