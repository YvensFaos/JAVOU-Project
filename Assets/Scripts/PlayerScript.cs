using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float hp;
    public float speed;
    public Transform shooterPosition;

    public Transform playerBullet;

	void Start () 
    {
        hp = 100.0f;
        speed = 0.25f;
	}
	
	void Update () 
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(transform.right * horizontal * speed, Space.World);
        transform.Translate(transform.up * vertical * speed, Space.World);

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, shooterPosition.position, transform.rotation);
        }
	}
}
