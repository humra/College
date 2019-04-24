using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelGemPickup : MonoBehaviour {

    public static int pointsWorth = 10;

    private GameObject audioSourceGemPickup;

	// Use this for initialization
	void Start () {
        audioSourceGemPickup = GameObject.Find("AudioSourceGemPickup");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            audioSourceGemPickup.GetComponent<AudioSource>().Play();

            ScoreManager.addPoints(pointsWorth);
            ScoreManager.addGem(1);
            Destroy(gameObject);
        }
    }
}
