using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] enemies; //Vetor de inimigos que posso instanciar

    public float spawnCoolDown; //De quanto em quanto tempo que um novo inimigo será instanciado
    private float spawnTimer; //Contador para saber se é hora de instanciar um novo inimigo

    private float spawnerSize; //Variável pra guardar o tamanho do objeto spawner no jogo para poder instanciar os inimigos em locais aleatórios.
    private float minX, maxX;

	// Use this for initialization
	void Start () {

        spawnTimer = spawnCoolDown;

        spawnerSize = GetComponent<Renderer>().bounds.size.x;
        maxX = spawnerSize / 2;
        minX = -maxX; //Isso porque o objeto spawner está localizado no centro do eixo X.
	
	}
	
	// Update is called once per frame
	void Update () {

        spawnTimer -= Time.deltaTime; //O tempo em segundos que levou para renderizar o último frame. (Isso faz o jogo ficar independente do framerate).

        if (spawnTimer <= 0)//Hora de instanciar um novo enemy.
        {
            GameObject newEnemy = Instantiate(enemies[Random.Range(0, enemies.Length)]);

            //Gera uma posição aleatória do inimigo no eixo X, respeitando os limites do objeto spawner
            Vector3 newPosition = new Vector3(Random.Range(minX, maxX), transform.position.y, transform.position.z);

            newEnemy.transform.position = newPosition;
            newEnemy.transform.SetParent(transform);

            spawnTimer = spawnCoolDown;
        }


	}
}
