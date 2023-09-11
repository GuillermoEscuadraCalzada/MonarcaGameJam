using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MSceneManager : MonoBehaviour{
    [SerializeField] private PuzzleRooms _puzzleRooms;
    public void LoadScene(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }

    public void EnableNextRoom() {
        if(_puzzleRooms.CurrentPuzzleRoomIndex + 1 > _puzzleRooms.puzzleRooms.Length - 1) {
         	return; 
		}
        _puzzleRooms.CurrentPuzzleRoom.SetActive(false);
        _puzzleRooms.CurrentPuzzleRoomIndex += 1;
        _puzzleRooms.CurrentPuzzleRoom = _puzzleRooms.puzzleRooms[_puzzleRooms.CurrentPuzzleRoomIndex];
        _puzzleRooms.puzzleRooms[_puzzleRooms.CurrentPuzzleRoomIndex].SetActive(true);
		_puzzleRooms.Arrow.SetActive(false);
    }
}
