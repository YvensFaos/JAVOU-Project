using UnityEngine;
using System.Collections;

public class RemoveRenderer : MonoBehaviour {
	
    void Start () {
        GetComponent<MeshRenderer>().enabled = false;
        Destroy(this);
	}
	
	void Update () { }
}
