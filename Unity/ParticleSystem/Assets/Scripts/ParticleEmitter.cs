using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ParticleHandler {
    void ParticleBecomeInactive(Particle particle);
}

public class ParticleEmitter : MonoBehaviour, ParticleHandler {

    public Particle particlePrefab;

    private Stack<Particle> inactiveParticles;

    public int emissionRate = 60;

    private float emissionInterval = 0f;

    private float emissionTimer = 0f;

    public int burstEmissionRate = 500;

	// Use this for initialization
	void Start () {
        inactiveParticles = new Stack<Particle>();
        emissionInterval = 1f / emissionRate;

        if (burstEmissionRate > 0) {
            for (int i = 0; i < burstEmissionRate; i++) {
                CreateParticle();
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        emissionTimer += Time.deltaTime;

        while (emissionTimer >= emissionInterval) {
            emissionTimer -= emissionInterval;
            CreateParticle();
        }
    }

    private void CreateParticle() {
        if (inactiveParticles.Count > 0)
        {
            var particle = inactiveParticles.Pop();
            particle.gameObject.SetActive(true);

            particle.transform.position = transform.position;
            particle.SetInitialValues();
        }
        else {
            var particle = Instantiate(particlePrefab.gameObject, transform.position, Quaternion.identity).GetComponent<Particle>();

            particle.particleDelegate = this;
        }
    }

    public void ParticleBecomeInactive(Particle particle)
    {
        particle.gameObject.SetActive(false);
        inactiveParticles.Push(particle);
    }
}
