using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour {

    private void OnMouseDown()
    {
        GetComponent<Rigidbody2D>().gravityScale = -0.1f;
    }

    private void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * Random.Range(-0.1f, 0.1f) * Time.deltaTime);
    }
}
