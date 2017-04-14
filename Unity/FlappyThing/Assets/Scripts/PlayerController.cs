using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Gravity;
    public float FlapPower;
    public float PlayerSpeed;
    public int targetFramerate;

    public Vector3 movementVector = Vector3.zero;

    private bool didFlap;

	// Use this for initialization
	void Start () {
        movementVector.x = PlayerSpeed / targetFramerate;
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            didFlap = true;
        }
	}

    private void FixedUpdate()
    {
        if (didFlap)
        {
            movementVector.y = 0;
            movementVector.y += FlapPower * Time.deltaTime;
            didFlap = false;
        }

        movementVector.y += Gravity * Time.deltaTime;
        transform.position += movementVector;
    }
}
