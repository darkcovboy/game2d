using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	public bool ground = false;
	private static readonly string Ground = "Ground";

	private void OnCollisionEnter2D(Collision2D other) {
		if (other.collider.CompareTag(Ground)) ground = true;
	}

	private void OnCollisionExit2D(Collision2D other) {
		if (other.collider.CompareTag(Ground)) ground = false;
	}
}
