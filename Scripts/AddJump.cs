using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AddJump : MonoBehaviour {

	// Use this for initialization
	public GameObject plyr;	
	void Start(){
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Ground") {
					
		}
	}
}
