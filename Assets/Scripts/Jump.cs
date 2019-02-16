using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
            var JumpForce = 15;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.GetComponent<Rigidbody>().AddForce(transform.up * JumpForce, ForceMode.Impulse);
            }
           
    }
    


    
}
