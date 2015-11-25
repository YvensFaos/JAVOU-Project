using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public float speed;

	void Update () 
	{

        Vector3 offset = new Vector3(0, Time.time * speed, 0);
        //GetComponent<Renderer>().material.mainTextureOffset = offset;

        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", offset);


	}
}