using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    public Text scoreNumb;
    private float score;

	// Use this for initialization
	void Start () {
        score = GameMaster.GM.score;
	}
	
	// Update is called once per frame
	void Update () {

        score = GameMaster.GM.score;

        scoreNumb.text = score + "";

	}
}
