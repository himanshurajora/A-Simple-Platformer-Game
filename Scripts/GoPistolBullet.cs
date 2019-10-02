using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoPistolBullet : MonoBehaviour {

	// Use this for initialization
	
	private Rigidbody2D rigidbody;
	public float pbulletspeed;
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.velocity = Vector2.left * pbulletspeed;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player" || other.tag == "Ground" || other.tag == "Wall"){
			GameObject.Destroy(gameObject);
		}
	}
	// Update is called once per frame
	
}
