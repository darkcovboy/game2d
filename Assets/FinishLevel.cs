using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour {
	private GameMenuController GameMenuController;

	private void Start() {
		GameMenuController = FindObjectOfType<GameMenuController>();
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			GameMenuController.Finish();
		}
	}
	
}
