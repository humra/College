using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool triggered;

    public float movementSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidbody;
    private SpriteRenderer myRenderer;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool jump;

    public Animator animator;
    public LevelManager levelManger;

    private bool menuOpen;
    private MenuManagerScript menuManager;

	// Use this for initialization
	void Start () {
        levelManger = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        myRigidbody = GetComponent<Rigidbody2D>();
        myRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        menuOpen = false;
        menuManager = GameObject.Find("MenuManager").GetComponent<MenuManagerScript>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuOpen = !menuOpen;
            updateMenus();
        }

        if (!menuOpen)
        {
            if (Input.GetKeyDown(KeyCode.Space) && grounded)
            {
                jump = true;
            }
            if (Input.GetKeyDown(KeyCode.C) && grounded && ScoreManager.getGems() >= 5)
            {
                levelManger.setCustomCheckpoint();
                ScoreManager.addGem(-5);
            }

            float horizontalMovement = Input.GetAxis("Horizontal");

            transform.Translate(horizontalMovement * movementSpeed, 0, 0);

            animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
            animator.SetBool("Grounded", grounded);

            if (horizontalMovement != 0)
            {
                if (horizontalMovement < 0)
                {
                    myRenderer.flipX = true;
                }
                else
                {
                    myRenderer.flipX = false;
                }
            }
        }        
    }

    private void updateMenus()
    {
        menuManager.updateCanvases(menuOpen);
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);     

        if(jump)
        {
            myRigidbody.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }
}
