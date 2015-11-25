using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public float hp;
    public float speed;
    public float speedFactor; //Altera a velocidade do inimigo para gerar uma velocidade diferente para cada um instanciado.
    public Transform shooterPosition;

    public Transform enemyBullet;

    private GameObject playerReference;

	// Use this for initialization
	void Start () {

        speed *= Random.Range(1.0f, speedFactor);
        playerReference = GameObject.FindGameObjectWithTag("Player"); //Acha o objeto player através da tag Player.

	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(-transform.up * speed, Space.World);
        EnemyBehaviour();


	}

    private void EnemyBehaviour()
    {
        //Lerp apenas de X
    }
}
