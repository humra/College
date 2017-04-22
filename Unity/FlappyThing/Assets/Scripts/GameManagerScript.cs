using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

	public GameObject backgroundTile;
    private float initialOffset = -2.1f;
    private float nextTilePosition;
    float tileWidth;

	// Use this for initialization
	void Start () {
        tileWidth = backgroundTile.GetComponentInChildren<Renderer>().bounds.size.x - 0.02f;
        
        nextTilePosition = initialOffset;
        for(var i = 0; i < 6; i++)
        {
            Instantiate(backgroundTile, new Vector3(nextTilePosition, 0, 0), Quaternion.identity);
            nextTilePosition += tileWidth;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        collider.transform.position = new Vector3(nextTilePosition, 0, 0);
        nextTilePosition += tileWidth;
    }
}
