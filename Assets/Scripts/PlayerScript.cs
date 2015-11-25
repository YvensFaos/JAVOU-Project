using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float hp;
    public float speed;
    public Transform shooterPosition;

    public Transform playerBullet;

    private Rigidbody rigidBd;
	void Start () 
    {
        hp = 100.0f;
        speed = 0.25f;

        rigidBd = GetComponent<Rigidbody>();

	}
	
	void Update () 
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(transform.right * horizontal * speed, Space.World);
        transform.Translate(transform.up * vertical * speed, Space.World);

        //rigidBd.AddForce(transform.right * horizontal * speed, ForceMode.VelocityChange);
        //rigidBd.AddForce(transform.up * vertical * speed, ForceMode.VelocityChange);

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, shooterPosition.position, transform.rotation);
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            hp -= 10.0f;
            Destroy(other.gameObject);
        }
    }
}
