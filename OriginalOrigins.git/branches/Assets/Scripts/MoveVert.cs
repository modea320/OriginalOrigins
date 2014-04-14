using UnityEngine;
using System.Collections;


public class MoveVert : MonoBehaviour {

    //public AudioClip jump_sound;
	public Texture2D button1;
	public GameObject theObject;
	public int direction;
    public int speed;
    public int divisor;

	// Use this for initialization
	void Start () {
		guiTexture.texture = button1;		 
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
            

			    if(guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended && Time.timeScale != 0)
			    {
				    //guiTexture.texture = buton1;
                    {
                        //audio.PlayOneShot(jump_sound, 1.0f); //added by Matt
                        SoundManagerScript.Instance.MakeJumpSound();
                        theObject.transform.Translate(Vector2.up * speed * direction / divisor);
                        
                    }
			    }
             
            


		}
        
	}
}
