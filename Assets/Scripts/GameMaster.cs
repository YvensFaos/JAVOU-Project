using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

    public static GameMaster GM;

    public float score = 0;

    void Awake()
    {
        if (GM != null)
            GameObject.Destroy(GM);
        else
            GM = this;

        DontDestroyOnLoad(this);

    }

}
