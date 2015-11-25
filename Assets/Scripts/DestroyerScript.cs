using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }


    //public void OnColliderEnter(Collision other)
    //{
    //    Destroy(other.gameObject);
    //}
}
