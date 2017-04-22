using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private float cameraHorizontalOffset;

	// Use this for initialization
	void Start () {
        cameraHorizontalOffset = transform.position.x - player.transform.position.x;
	}

    private void FixedUpdate()
    {
        Vector3 calculatedPosition = new Vector3(player.transform.position.x + cameraHorizontalOffset, transform.position.y, -10);
        transform.position = calculatedPosition;
    }
}
