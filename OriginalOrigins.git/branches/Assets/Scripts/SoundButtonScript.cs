using UnityEngine;
using System.Collections;

public class SoundButtonScript : MonoBehaviour {

    public GUITexture theObject;
    public Texture buttonOn;
    public Texture buttonOff;

    // set to type 0 for SFX, tpye 1 for BGM
    public int type;

	// Use this for initialization
	void Start () {
       

        // if SFX Button
        if(type == 0)
        {
            // if SFX is off
            if(PlayerPrefs.GetInt("SFX") == 0)
            {
                theObject.texture = buttonOff;
            }
            // if SFX is on
            else
            {
                theObject.texture = buttonOn;
            }
        }

        // if BGM button
        else if (type == 1)
        {
            // if BGM is off
            if(PlayerPrefs.GetInt("BGM") == 0)
            {
                theObject.texture = buttonOff;
            }
            // if BGM is on
            else
            {
                theObject.texture = buttonOn;
            }
        }
	    
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (theObject.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                //for SFX button
                if(type == 0)
                {
                    // if SFX is off
                    if(PlayerPrefs.GetInt("SFX") == 0)
                    {
                        // turn on SFX
                        PlayerPrefs.SetInt("SFX", 1);
                        theObject.texture = buttonOn;
                    }
                        // if SFX is on
                    else if(PlayerPrefs.GetInt("SFX") == 1)
                    {
                        // turn off SFX
                        PlayerPrefs.SetInt("SFX", 0);
                        theObject.texture = buttonOff;
                    }
                }

                // for BGM button
                if (type == 1)
                {
                    // if BGM is off
                    if (PlayerPrefs.GetInt("BGM") == 0)
                    {
                        // turn on BGM
                        PlayerPrefs.SetInt("BGM", 1);
                        theObject.texture = buttonOn;
                    }
                    // if BGM is on
                    else if (PlayerPrefs.GetInt("BGM") == 1)
                    {
                        // turn off BGM
                        PlayerPrefs.SetInt("BGM", 0);
                        theObject.texture = buttonOff;
                    }
                }
            }

        }
	}
}
