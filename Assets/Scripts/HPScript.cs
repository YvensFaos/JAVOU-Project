using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPScript : MonoBehaviour {

    
    private float alfaCut, HPmax, HPnow;
    private Image imageCol;
    public GameObject player;
    //public Color col;

    // Use this for initialization
    void Start()
    {
        alfaCut = 1.0f;
        imageCol = GetComponent<Image>();
        HPmax = player.GetComponent<PlayerScript>().hp;
        HPnow = HPmax;
    }

    // Update is called once per frame
    void Update()
    {
        HPnow = player.GetComponent<PlayerScript>().hp;
        //GetComponent<SpriteRenderer>().color = Color.yellow;
        alfaCut = HPnow / HPmax;

        imageCol.fillAmount = alfaCut;

        //imageCol.color = Color.Lerp(Color.white, col, 1 - alfaCut);

    }
}
