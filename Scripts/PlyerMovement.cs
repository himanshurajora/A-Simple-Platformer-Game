using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlyerMovement : MonoBehaviour {

	private float direction;
	private Rigidbody2D rb;
	private Transform t;
	public float mspeed;
	public Animator animator;
	private bool movrig;
	public bool isGrounded;
	public GameObject groundcheck;
	public float jumpforce;
	public int extrajumps;
	// Use this for initialization
	public float health;
	
	public bool isPlayerDied;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Ground") {
			isGrounded = true;
			extrajumps = 1;
		}
		if(other.tag == "Bullet"){
			health = health - 5;
			if(health <= 0){
				isPlayerDied = true;
				GameObject.Destroy(gameObject);	
			}
		}
		else {
			isGrounded = false;
		}
	}
	// Update is called once per frame
	void FixedUpdate ()
	{
		direction = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (direction * mspeed, rb.velocity.y);
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.LeftArrow)) {
			animator.SetBool ("right", true);
		} 
		else if(Input.GetKey(KeyCode.A) || Input.GetKey (KeyCode.RightArrow)){
			animator.SetBool ("left", true);
		}
		else {
			animator.SetBool ("right", false);
			animator.SetBool ("left", false);
		}
	}
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.W) && extrajumps >= 1) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpforce);
			extrajumps--;
		}
	
	}

	}
