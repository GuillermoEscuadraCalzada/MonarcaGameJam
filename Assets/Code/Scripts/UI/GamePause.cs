using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GamePause : MonoBehaviour{
    [SerializeField] GameObject pauseRef;
    public static bool isGamePaused = false;

    void Awake() {
        pauseRef.SetActive(false);
    }
    private void Update() {
        TryPauseGame();
    }

    void TryPauseGame() {
        if (!Input.GetKeyDown(KeyCode.I)) return;
        if (!isGamePaused){
            PauseGame();
        }
        else{
            ResumeGame();
        }
    }

    public void PauseGame() {
        Time.timeScale = 0;
        isGamePaused = true;
        pauseRef.SetActive(true);
    }

    public void ResumeGame() {
        Time.timeScale = 1;
        isGamePaused = false;
        pauseRef.SetActive(false);
    }
}
