using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float hp;
    public float speed;
    public Transform shooterPosition;

    public Transform playerBullet;
    public GameObject playerExplosion;
    public GameObject hitFX;

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

        if (horizontal != 0 || vertical != 0)
        {
            rigidBd.velocity = Vector3.zero;  //Retirar a inercia causada pelos impactos das balas.
        }

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, shooterPosition.position, transform.rotation);
        }

        if (hp <= 0)
        {
            GameObject explosion = Instantiate(playerExplosion);
            explosion.transform.position = transform.position;
            Destroy(gameObject);
        }
	}

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            ContactPoint contactPoint = other.contacts[0];

            hp -= 10.0f;
            GameObject hit = Instantiate(hitFX);
            hit.transform.position = contactPoint.point;
            Destroy(other.gameObject);
        }
    }
}
