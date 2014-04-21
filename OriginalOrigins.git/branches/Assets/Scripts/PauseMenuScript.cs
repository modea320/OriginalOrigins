using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour {


    public GUITexture homeButton;
    public GUITexture optionsButton;
    public GUITexture restartButton;    
    public GUITexture resumeButton;
    public GUITexture background;
    public GUITexture pauseText;

	// Use this for initialization
	void Start () {

        //homeButton.pixelInset = (Screen.width / 10) * 2;
        PlayerPrefs.SetInt("IsSafe", 0);

	}
	
	// Update is called once per frame
	void Update () {

	    if(Time.timeScale == 0)
        {
            homeButton.enabled = true;
            optionsButton.enabled = true;
            restartButton.enabled = true;
            resumeButton.enabled = true;
            pauseText.enabled = true;
            background.enabled = true;
            

            foreach (Touch touch in Input.touches)
            {
                if (homeButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
                {
                    homeButton.enabled = false;
                    optionsButton.enabled = false;
                    restartButton.enabled = false;
                    resumeButton.enabled = false;
                    background.enabled = false;
                    pauseText.enabled = false;
                    Time.timeScale = 1;

                    //temporarily the main menu
                    Application.LoadLevel("0TitleScreen");
                }
                
                if (optionsButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
                {
                    homeButton.enabled = false;
                    optionsButton.enabled = false;
                    restartButton.enabled = false;
                    resumeButton.enabled = false;
                    background.enabled = false;
                    pauseText.enabled = false;
                    Time.timeScale = 1;
                    //load the options menu
                    Application.LoadLevel(19);
                }
                
                if (restartButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
                {
                    Application.LoadLevel(Application.loadedLevel);
                    homeButton.enabled = false;
                    optionsButton.enabled = false;
                    restartButton.enabled = false;
                    resumeButton.enabled = false;
                    background.enabled = false;
                    pauseText.enabled = false;
                    Time.timeScale = 1;
                }

                if (resumeButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
                {
                    homeButton.enabled = false;
                    optionsButton.enabled = false;
                    restartButton.enabled = false;
                    resumeButton.enabled = false;
                    background.enabled = false;
                    pauseText.enabled = false;
                    Time.timeScale = 1;
                }
                
                
            }
        }
        else
        {
            homeButton.enabled = false;
            optionsButton.enabled = false;
            restartButton.enabled = false;
            resumeButton.enabled = false;
            background.enabled = false;
            pauseText.enabled = false;
        }
	}
}
