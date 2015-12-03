using UnityEngine;
using System.Collections;

public class MoveForwardScript : MonoBehaviour {

    public float speed = 0.2f;
    public float speedFactor = 1.0f;

	// Use this for initialization
	void Start () {
        speed *= Random.Range(1.0f, speedFactor);
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(transform.up * speed, Space.World);

	}
}
