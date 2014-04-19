using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    public GUITexture newGameButton;
    public GUITexture resumeGameButton;
    public GUITexture optionsButton;
    public Texture newTexture;
    public Texture resumeTexture;

    //public GUITexture mainMenu;

    public string newLevel;

    


	// Use this for initialization
	void Start () {

        PlayerPrefs.SetInt("BGM", 1);
        PlayerPrefs.SetInt("SFX", 1);

        //print(PlayerPrefs.GetInt("BGM"));
        //print(PlayerPrefs.GetInt("SFX"));
        

        if(PlayerPrefs.GetInt("LastLevel") != 0)
        {
            return;
        }

        PlayerPrefs.SetInt("LastLevel", 0);

        /*
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
            Texture tempTex = newGameButton.texture;
            newGameButton.texture = resumeGameButton.texture;
            resumeGameButton.texture = tempTex;
        }
        */
	}
	
	// Update is called once per frame
	void Update () {
        //print(PlayerPrefs.GetInt("LastLevel"));

        if (PlayerPrefs.GetInt("LastLevel") == 0)
        {
            resumeGameButton.enabled = false;
        }
        else
        {
            resumeGameButton.enabled = true;
            newGameButton.texture = resumeTexture;
            resumeGameButton.texture = newTexture;
        }

        foreach (Touch touch in Input.touches)
        {
            if (newGameButton.HitTest(touch.position) && touch.phase == TouchPhase.Began && PlayerPrefs.GetInt("LastLevel") == 0)
            {
                Application.LoadLevel(newLevel);
            }

            else if (newGameButton.HitTest(touch.position) && touch.phase == TouchPhase.Began && PlayerPrefs.GetInt("LastLevel") != 0)
            {
                Application.LoadLevel(PlayerPrefs.GetInt("LastLevel"));
            }

            if (resumeGameButton.HitTest(touch.position) && touch.phase == TouchPhase.Began && PlayerPrefs.GetInt("LastLevel") != 0)
            {
                Application.LoadLevel(newLevel);
            }

            else if (resumeGameButton.HitTest(touch.position) && touch.phase == TouchPhase.Began && PlayerPrefs.GetInt("LastLevel") == 0)
            {
                
            }

            /*
            if (optionsButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                // will load the options menu when that's added
            }
            */
        }
	}
}
