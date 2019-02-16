using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float JumpForce = 15;
    public GameObject player;
    public GroundCheck groundCheck
	    ;

   
	
	// Update is called once per frame
	void Update () {
       
            
            if (Input.GetKeyDown(KeyCode.Space)) {
	            if (groundCheck.ground == true) Jump1();
            }
           
    }

	private void Jump1() {
		player.GetComponent<Rigidbody2D>().AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
	}
}
