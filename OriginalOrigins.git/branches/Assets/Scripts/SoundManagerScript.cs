using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour {

    public static SoundManagerScript Instance;

    public AudioClip jump_sound;
    public AudioClip lose_sound;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Multiple Instances of SoundManagerScript");
        }
        Instance = this;
    }

    public void MakeLoseSound()
    {
        MakeSound(lose_sound);
    }

    public void MakeJumpSound()
    {
        MakeSound(jump_sound);
    }

    public void MakeSound(AudioClip theClip)
    {
        AudioSource.PlayClipAtPoint(theClip, transform.position);


    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
