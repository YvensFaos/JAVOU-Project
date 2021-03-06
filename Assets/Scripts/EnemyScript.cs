﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public float hp;
    //public float speed;
    //public float speedFactor; //Altera a velocidade do inimigo para gerar uma velocidade diferente para cada um instanciado.
    public float shootCooldown;
    private float shootTimer;

    public Transform shooterPosition;

    public Transform enemyBullet;
    public GameObject enemyExplosion;
    public GameObject hitFX;

    private GameObject playerReference;
    private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
        shootTimer = shootCooldown;
        //speed *= Random.Range(1.0f, speedFactor);
        playerReference = GameObject.FindGameObjectWithTag("Player"); //Acha o objeto player através da tag Player.
        playerPosition = playerReference.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0)
        {
            Instantiate(enemyBullet, shooterPosition.position, transform.rotation);
            shootTimer = shootCooldown;
        }

        if (hp <= 0) //Se morrer....morreu
        {
            GameObject explosion = Instantiate(enemyExplosion);
            explosion.transform.position = transform.position;
            GameMaster.GM.score += 20;
            Destroy(gameObject);
        }


	}

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            ContactPoint contactPoint = other.contacts[0];

            hp -= 10.0f;
            GameObject hit = Instantiate(hitFX);
            hit.transform.position = contactPoint.point;
            Destroy(other.gameObject);
        }
    }
}
