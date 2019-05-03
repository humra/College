using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ParticleHandler2
{
    void ParticleBecomeInactive(Particle2 particle);
}

public class ParticleEmitter2 : MonoBehaviour, ParticleHandler2
{
    public GameObject particlePrefab;

    private Stack<Particle2> inactiveParticles;
    private List<Particle2> particles = new List<Particle2>();

    public int emissionRate = 60;

    private float emissionInterval = 0f;

    private float emissionTimer = 0f;

    public int burstEmissionRate = 500;

    // Use this for initialization
    void Start()
    {
        inactiveParticles = new Stack<Particle2>();
        emissionInterval = 1f / emissionRate;

        if (burstEmissionRate > 0)
        {
            for (int i = 0; i < burstEmissionRate; i++)
            {
                CreateParticle();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < particles.Count; i++) {
            if (particles[i].isActive)
            {
                particles[i].Update();
            }
        }
    }

    private void FixedUpdate()
    {
        emissionTimer += Time.deltaTime;

        while (emissionTimer >= emissionInterval)
        {
            emissionTimer -= emissionInterval;
            CreateParticle();
        }
    }

    private void CreateParticle()
    {
        if (inactiveParticles.Count > 0)
        {
            var particle = inactiveParticles.Pop();
            particle.isActive = true;

            particle.transform.position = transform.position;
            particle.SetInitialValues();
        }
        else
        {
            var particleObj = Instantiate(particlePrefab.gameObject, transform.position, Quaternion.identity);

            var particle = new Particle2(particleObj);
            particles.Add(particle);

            particle.particleDelegate = this;
            particle.Start();
        }
    }

    public void ParticleBecomeInactive(Particle2 particle)
    {
        particle.isActive = false;
        inactiveParticles.Push(particle);
    }
}
