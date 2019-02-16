using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {

    public UnityEngine.Events.UnityEvent onPlayerHit;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            onPlayerHit.Invoke();
        }
    }
}
