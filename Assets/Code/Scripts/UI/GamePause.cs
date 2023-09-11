using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GamePause : MonoBehaviour{
    [SerializeField] GameObject pauseRef;
    private MSceneManager _scenesManager;
    public static bool isGamePaused = false;

    void Awake() {
        pauseRef.SetActive(false);
    }

    private void Start() {
        _scenesManager = GameObject.Find("SceneManager").GetComponent<MSceneManager>();
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

    public void MainMenu() {
        _scenesManager.LoadScene(0);
    }
}
