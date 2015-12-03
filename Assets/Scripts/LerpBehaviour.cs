using UnityEngine;
using System.Collections;

public class LerpBehaviour : MonoBehaviour {

    private GameObject playerReference;
    private Vector3 playerPosition;
    public float speed;

	// Use this for initialization
	void Start () {

        playerReference = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
        playerPosition = playerReference.transform.position;

        Vector3 newPosition = transform.position;

        newPosition.x = Mathf.Lerp(newPosition.x, playerPosition.x, speed / 8);

        transform.position = newPosition;
	}
}
