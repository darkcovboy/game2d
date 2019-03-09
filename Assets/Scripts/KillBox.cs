using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {
    private GameMenuController GameMenuController;

    private void Start() {
        GameMenuController = FindObjectOfType<GameMenuController>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Ground")) {
            GameMenuController.Fail();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        OnTriggerEnter2D(other.collider);
    }
}