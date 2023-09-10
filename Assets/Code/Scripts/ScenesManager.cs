using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour{
    [SerializeField] private PuzzleRooms _puzzleRooms;
    public void LoadScene(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }

    public void EnableNextRoom() {
        _puzzleRooms.CurrentPuzzleRoomIndex += 1;
        if(_puzzleRooms.CurrentPuzzleRoomIndex > _puzzleRooms.puzzleRooms.Length - 1) Debug.LogError("No more puzzle rooms");
        _puzzleRooms.CurrentPuzzleRoom.SetActive(false);
        _puzzleRooms.puzzleRooms[_puzzleRooms.CurrentPuzzleRoomIndex].SetActive(true);
    }
}
