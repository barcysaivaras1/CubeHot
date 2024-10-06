using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Rigidbody rb;
    public Transform obstacle;
    public float explosionForce = 1000f;
    public ParticleSystem collisionParticleSystem;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {

            rb.AddExplosionForce(explosionForce,obstacle.position,10);// Makes the cube blow back

            //Create a particle effect on collision
            var em = collisionParticleSystem.emission;
            em.enabled = true;
            collisionParticleSystem.Play();



            movement.enabled = false;// Disable player movement
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

}
