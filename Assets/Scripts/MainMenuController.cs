using UnityEngine;

public class MainMenuController : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject levelMenu;

    private void Start() {
        MainMenuShow();
    }

    public void LevelsMenuShow() {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
    }

    public void MainMenuShow() {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
    }
    
    public void GameExit() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}