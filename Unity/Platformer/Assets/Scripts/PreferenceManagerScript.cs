using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PreferenceManagerScript : MonoBehaviour {

    public Toggle sound;

    private void Start()
    {
        sound = GameObject.Find("Sound").GetComponent<Toggle>();
    }

    public void changeSoundSettings()
    {
        if (sound.isOn)
        {
            PlayerPreferences.soundEnabled = true;
        }
        else
        {
            PlayerPreferences.soundEnabled = false;
        }
    }
}
