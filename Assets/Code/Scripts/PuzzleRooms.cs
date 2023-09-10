using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRooms : MonoBehaviour{
    public GameObject[] puzzleRooms;

    private void Awake() {
        CurrentPuzzleRoom = puzzleRooms[CurrentPuzzleRoomIndex];
    }
    
    public GameObject CurrentPuzzleRoom { get; set; }
    public int CurrentPuzzleRoomIndex { get; set; }

}
