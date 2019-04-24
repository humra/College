using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemyScript : MonoBehaviour {

    public float movementSpeed;
    public SpriteRenderer myRenderer;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(movementSpeed, 0, 0) * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Terrain"))
        {
            movementSpeed *= -1;
            myRenderer.flipX = !myRenderer.flipX;
        }
    }
}
