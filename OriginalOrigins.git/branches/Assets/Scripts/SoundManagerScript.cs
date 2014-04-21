using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour {

    public static SoundManagerScript Instance;

    public AudioClip jump_sound;
    public AudioClip lose_sound;
   // public AudioClip screech_sound;
    public Camera theCamera;

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

    public void MakeScreechSound()
    {
        
        //MakeSound(screech_sound);
    }

    public void MakeSound(AudioClip theClip)
    {
        if (PlayerPrefs.GetInt("SFX") == 1)
        {
            AudioSource.PlayClipAtPoint(theClip, transform.position);
        }
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //print(PlayerPrefs.GetInt("BGM"));

	    if(PlayerPrefs.GetInt("BGM") == 0)
        {
            //theCamera.GetComponent<AudioListener>().enabled = false;
            //Camera.main.GetComponent<AudioListener>().enabled = false;
            //theCamera.audio.Pause();
            //AudioListener.pause = true;
            if (Application.platform == RuntimePlatform.Android)
            {
                AudioListener.volume = 0;
                audio.Stop();
            }
        }
        
        else if(PlayerPrefs.GetInt("BGM") == 1)
        {
            //theCamera.GetComponent<AudioListener>().enabled = true;
            //Camera.main.GetComponent<AudioListener>().enabled = true;
            //theCamera.audio.Play();
            //AudioListener.pause = false;
            if (Application.platform == RuntimePlatform.Android)
            {
                AudioListener.volume = 100;
                audio.Play();
            }
        }
        
	}
}
