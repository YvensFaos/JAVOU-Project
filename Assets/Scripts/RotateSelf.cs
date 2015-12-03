using UnityEngine;
using System.Collections;

public class RotateSelf : MonoBehaviour {

    public float intensity = 2.0f;

	void Start () {
	
	}
	
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * intensity, Space.Self);
	}
}
