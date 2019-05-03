using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle2
{
    public bool useGravity = false;

    public float useGravityAterInterval = 1f;

    public float gravityStrenght = 4f;

    private Vector3 movementVector;

    public float initialLifespan = 1f;

    public float lifespanDeviation = 1f;

    private float lifespan;

    public ParticleHandler2 particleDelegate;

    private Vector3 downVector = Vector3.down;

    public GameObject gameObject;

    public Transform transform;

    public bool isActive {
        get {
            return gameObject.activeSelf;
        }

        set {
            gameObject.SetActive(value);
        }
    }


    public Particle2(GameObject gameObject) {
        this.gameObject = gameObject;
    }
    // Use this for initialization
    public void Start()
    {
        transform = gameObject.transform;
        SetInitialValues();
    }

    public void SetInitialValues()
    {
        InitialMovementVector();

        lifespan = initialLifespan + Random.Range(-lifespanDeviation / 2, lifespanDeviation / 2);

        useGravity = false;
        useGravityAterInterval = 1f;

    }

    protected virtual void InitialMovementVector()
    {
        movementVector = Vector3.zero;
        movementVector += Vector3.up * Random.Range(-1f, 1f);
        movementVector += Vector3.left * Random.Range(-1f, 1f);
        movementVector += Vector3.forward * Random.Range(-1f, 1f);

        transform.localScale = Vector3.one * Random.Range(0.5f, 3f);

    }

    // Update is called once per frame
    public void Update()
    {
        if ((useGravityAterInterval -= Time.deltaTime) <= 0)
        {
            useGravity = true;
        }

        if (useGravity)
        {
            movementVector += downVector * gravityStrenght * Time.deltaTime;
        }

        transform.position += movementVector;


        lifespan -= Time.deltaTime;

        if (lifespan <= 0)
        {
            if (particleDelegate != null)
            {
                particleDelegate.ParticleBecomeInactive(this);
            }
        }

    }
}
