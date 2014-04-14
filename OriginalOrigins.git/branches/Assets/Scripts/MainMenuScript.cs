using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    public GUITexture newGameButton;
    public GUITexture resumeGameButton;
    public GUITexture optionsButton;

    //public GUITexture mainMenu;

    public string newLevel;

    


	// Use this for initialization
	void Start () {

        // if there is previously saved progress
        if (PlayerPrefs.GetInt("LastLevel") != 0)
        {
            //newMenu.enabled = false;
            //resumeMenu.enabled = true;

        }

        // if there is no previously saved level
        else 
        {

            //newMenu.enabled = true;
            //resumeMenu.enabled = false;

            GUITexture temp = newGameButton;
            newGameButton = resumeGameButton;
            resumeGameButton = temp;
            
                

            
        }
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (newGameButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                Application.LoadLevel(newLevel);
            }

            if (resumeGameButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {

                Application.LoadLevel(PlayerPrefs.GetInt("LastLevel"));
            }

            if (optionsButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                // will load the options menu when that's added
            }
        }
	}
}
