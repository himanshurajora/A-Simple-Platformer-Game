using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
//THIS IS NOT FOR PISTOL ACTUALLY THIS IS FOR THE AKM OR A ASUALT RIFLE;
    public GameObject bullet;
    public Transform fireposition;
	public float WOSBeforeFire;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(firethebullet());
            
        }
    }
	IEnumerator firethebullet(){
		int a = 0;
		while(a <= 4){
        Instantiate(bullet, fireposition);
		yield return new WaitForSeconds(WOSBeforeFire);
		a++;}
	}

}