using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenuController : MonoBehaviour {
    public float expectedTime;
    
    public GameObject menuUI;
    public GameObject escape;
    public GameObject finish;

    public Text timer;
    public Text starsCount;

    private bool isFail;
    private float timeStart;

    private void Start() {
        HideMenu();
        finish.SetActive(false);
        escape.SetActive(true);
        timeStart = Time.time;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SwitchMenu();
        }
    }

    private void SwitchMenu() {
        if (finish.activeSelf) return;
        if (isFail) return;
        if (menuUI.activeSelf) {
            HideMenu();
        } else {
            ShowMenu();
        }
    }

    public void Fail() {
        isFail = true;
        ShowMenu();
    }

    public void Finish() {
        finish.SetActive(true);
        escape.SetActive(false);
        var timeleft = Time.time - timeStart;
        timer.text = $"{(int) timeleft}s";
        var minTime = expectedTime;
        float maxTime = minTime * 2;
        float normalizedTime = Mathf.Clamp(timeleft, minTime, maxTime);
        float f = (normalizedTime - minTime) / minTime;
        float stars = Mathf.Lerp(3, 1, f);
        starsCount.text = stars.ToString();
        ShowMenu();
    }

    public void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelExit() {
        SceneManager.LoadScene("Menu");
    }

    public void HideMenu() {
        menuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowMenu() {
        menuUI.SetActive(true);
        Time.timeScale = 0;
    }
}