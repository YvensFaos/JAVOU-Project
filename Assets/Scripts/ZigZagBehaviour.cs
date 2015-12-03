using UnityEngine;
using System.Collections;

public class ZigZagBehaviour : MonoBehaviour {

    public float frequency = 20.0f;
    public float magnitude = 50.0f;
    
    public Vector3 pos, axis;
    public Transform player;
 
    void Start () {
        pos = transform.position;
        axis = -transform.right; 
    }
 
    void Update () {
        transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
    }
}
