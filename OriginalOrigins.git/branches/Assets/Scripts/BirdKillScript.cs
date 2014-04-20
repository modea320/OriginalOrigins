using UnityEngine;
using System.Collections;

public class BirdKillScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //audio.PlayOneShot(lose_sound, 1.0f);//sound effect
        if(otherCollider.tag == "Player")
        {
            SoundManagerScript.Instance.MakeLoseSound();
            Application.LoadLevel(Application.loadedLevel);
        }
       

    }
}
