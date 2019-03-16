using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenuButtons : MonoBehaviour {
    public Transform buttonsRoot;
    public Button levelButtonPrefab;

    void Start() {
        var levelsCount = SceneManager.sceneCountInBuildSettings - 1;
        for (int i = 0; i < levelsCount; i++) {
            var button = Instantiate(levelButtonPrefab, buttonsRoot);
            int levelIndex = i + 1;
            button.GetComponentInChildren<Text>().text += levelIndex;
            button.onClick.AddListener(() => StartLevel(levelIndex));
        }
    }

    public void StartLevel(int index) {
        SceneManager.LoadScene(index);
    }
}