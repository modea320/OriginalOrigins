using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

    //public Collider2D otherCollider;
    //public AudioClip lose_sound;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        print(PlayerPrefs.GetInt("IsSafe"));
	}


    // if the player enters this bounds, the current level is reloaded
    // essentailly "respawning" the character
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player")
        {
            if(PlayerPrefs.GetInt("IsSafe") == 1)
            {
                return;
            }
            //audio.PlayOneShot(lose_sound, 1.0f);//sound effect
            SoundManagerScript.Instance.MakeLoseSound();
            Application.LoadLevel(Application.loadedLevel);
            Handheld.Vibrate();
        }
        
        
    }

}
