﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public float hp;
    public float speed;
    public float speedFactor; //Altera a velocidade do inimigo para gerar uma velocidade diferente para cada um instanciado.
    public float shootCooldown;
    private float shootTimer;

    public Transform shooterPosition;

    public Transform enemyBullet;

    private GameObject playerReference;
    private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
        shootTimer = shootCooldown;
        speed *= Random.Range(1.0f, speedFactor);
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

        transform.Translate(transform.up * speed, Space.World);
        EnemyBehaviour();

	}

    private void EnemyBehaviour()
    {
        //Lerp apenas de X
        playerPosition = playerReference.transform.position;

        Vector3 newPosition = transform.position;

        newPosition.x = Mathf.Lerp(newPosition.x, playerPosition.x, speed / 8);

        transform.position = newPosition;
        
    }
}
