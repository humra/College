using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {

    public Vector3 currentCheckpoint;
    private PlayerController player;
    public GameObject deathParticle;
    public GameObject respawnParticle;
    private static AudioSource backGroundSound;
    private static AudioSource audioSourceDeath;
    private static AudioSource audioSourceGameOver;

    private Canvas menuCanvas;
    private Canvas statsCanvas;

	void Start () {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        currentCheckpoint = GameObject.Find("DefaultCheckpoint").transform.position;
        backGroundSound = GameObject.Find("BackgroundSound").GetComponent<AudioSource>();
        audioSourceDeath = GameObject.Find("AudioSourcePlayerDeath").GetComponent<AudioSource>();
        audioSourceGameOver = GameObject.Find("AudioSourceGameOver").GetComponent<AudioSource>();

        setSound();

        menuCanvas = GameObject.Find("MenuCanvas").GetComponent<Canvas>();
        statsCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();

        disableMenuCanvas();
    }

    private void disableMenuCanvas()
    {
        menuCanvas.enabled = false;
    }

    public void setSound()
    {

        AudioSource[] audioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

        if (PlayerPreferences.soundEnabled)
        {
            foreach(AudioSource audio in audioSources)
            {
                audio.enabled = true;
            }
        }
        else
        {
            foreach (AudioSource audio in audioSources)
            {
                audio.enabled = false;
            }
        }
    }

    void Update () {
		
	}

    public void RespawnPlayer()
    {
        backGroundSound.GetComponent<AudioSource>().Stop();
        audioSourceDeath.Play();
        StartCoroutine("respawnPlayerCo");
    }

    public IEnumerator respawnPlayerCo()
    {
        deathAnimation();
        yield return new WaitForSeconds(audioSourceDeath.clip.length);
        respawnAnimation();
        
        backGroundSound.GetComponent<AudioSource>().Play();
    }

    private void deathAnimation()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.gameObject.SetActive(false);
    }

    private void respawnAnimation()
    {
        player.transform.position = currentCheckpoint;
        Instantiate(respawnParticle, currentCheckpoint, player.transform.rotation);
        player.gameObject.SetActive(true);
    }

    internal void gameOver()
    {
        backGroundSound.Stop();
        StartCoroutine("gameOverCo");
    }

    public IEnumerator gameOverCo()
    {
        deathAnimation();
        audioSourceGameOver.Play();
        yield return new WaitForSeconds(audioSourceGameOver.clip.length + 1);
        SceneManager.LoadScene("MainMenu");
    }

    public void setCustomCheckpoint()
    {
        currentCheckpoint = player.transform.position;
    }

    public void nextLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void gameCompleted()
    {
        SceneManager.LoadScene("GameCompleted");
    }
}
