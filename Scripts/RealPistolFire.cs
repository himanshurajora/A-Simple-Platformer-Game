using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealPistolFire : MonoBehaviour
{
//THIS IS NOT FOR PISTOL ACTUALLY THIS IS FOR THE AKM OR A ASUALT RIFLE;
    public GameObject bullet;
    public Transform fireposition;
	public float WOSBeforeFire;
	public Collider2D collider2D;
	void Start()
	{
		collider2D = GetComponent<Collider2D>();
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
        
		StartCoroutine(firethebullet());
        }
}
IEnumerator firethebullet(){
		Instantiate(bullet, fireposition);
		yield return new WaitForSeconds(WOSBeforeFire);
		GameObject.Destroy(gameObject);
	}
}
