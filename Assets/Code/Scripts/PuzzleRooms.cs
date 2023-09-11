using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRooms : MonoBehaviour{
    public GameObject[] puzzleRooms;
    public GameObject Arrow;

    private void Awake() {
        CurrentPuzzleRoom = puzzleRooms[CurrentPuzzleRoomIndex];
        Arrow.SetActive(false);
    }
    
    public GameObject CurrentPuzzleRoom { get; set; }
    public int CurrentPuzzleRoomIndex { get; set; }

}
