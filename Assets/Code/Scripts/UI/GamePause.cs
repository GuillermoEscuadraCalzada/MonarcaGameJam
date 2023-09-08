using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GamePause : MonoBehaviour{
    [SerializeField] private GameObject pausePrefab;
    private GameObject pauseRef;
    public static bool isGamePaused = false;

    void Awake() {
        pauseRef = Instantiate(pausePrefab);
        pauseRef.SetActive(false);

    }
    private void Update() {
        PauseGame();
    }

    void PauseGame() {
        if (!Input.GetKeyDown(KeyCode.I)) return;
        if (!isGamePaused){
            Time.timeScale = 0;
            isGamePaused = !isGamePaused;
            pauseRef.SetActive(true);
        }
        else{
            Time.timeScale = 1;
            isGamePaused = !isGamePaused;
            pauseRef.SetActive(false);
        }
    }
}
