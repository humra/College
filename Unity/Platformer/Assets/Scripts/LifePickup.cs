using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : MonoBehaviour {

    public static int pointsWorth = 50;

    private AudioSource audioSourceLife;

	// Use this for initialization
	void Start () {
        audioSourceLife = GameObject.Find("AudioSourceLifePickup").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            audioSourceLife.Play();
            ScoreManager.addPoints(pointsWorth);
            ScoreManager.addLife(1);
            Destroy(gameObject);
        }
    }
}
