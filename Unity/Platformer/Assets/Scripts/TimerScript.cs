using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    private float time;
    private Text timer;

	// Use this for initialization
	void Start () {
        timer = GameObject.Find("Timer").GetComponent<Text>();
        time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        timer.text = time.ToString("F2");
	}
}
