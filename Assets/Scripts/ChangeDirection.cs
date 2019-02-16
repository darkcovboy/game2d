using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	private void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            var localScale = player.transform.localScale;
            localScale.x = -localScale.x;
            player.transform.localScale = localScale;
        }
		
	}
}
