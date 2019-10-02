using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMakeCameraFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject mcam;
	public int dis = 10;//distance of the camera from the player on the z axis;
	void Start () {
		mcam = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		mcam.transform.position = transform.position - new Vector3 (0, 0, dis);
	}
}
