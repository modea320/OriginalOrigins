using UnityEngine;
using System.Collections;

public class NextLevelScriptV2 : MonoBehaviour {

    public int level;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // loads the level indicated by the public string level
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Application.LoadLevel(level);
    }
}
