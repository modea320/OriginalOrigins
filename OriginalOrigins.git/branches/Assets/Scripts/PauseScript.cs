using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {


    public Texture2D buttonImage;
    //public bool paused = false;

	// Use this for initialization
	void Start () {
        guiTexture.texture = buttonImage;
	}
	
	// Update is called once per frame
	void Update () {

	    foreach(Touch touch in Input.touches)
        {
            if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Began && Time.timeScale == 1)
            {
                Time.timeScale = 0;
                //paused = true;
            }

            /*
            else if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Began && Time.timeScale == 0)
            {
                Time.timeScale = 1;
                //paused = false;
            }
            */

        }
	}


}
