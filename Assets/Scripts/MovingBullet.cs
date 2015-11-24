using UnityEngine;
using System.Collections;

public class MovingBullet : MonoBehaviour {

    public float direction = 1.0f;
    public float speed = 1.0f;

	void Start () { }
	
	void Update () {
        transform.Translate(transform.up * direction * speed, Space.World);
	}
}
