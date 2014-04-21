using UnityEngine;
using System.Collections;

public class SafetyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            PlayerPrefs.SetInt("IsSafe", 1);
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            PlayerPrefs.SetInt("IsSafe", 0);
        }

    }
}
