using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

    public Collider2D otherCollider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    // if the player enters this bounds, the current level is reloaded
    // essentailly "respawning" the character
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
