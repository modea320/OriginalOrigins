using UnityEngine;
using System.Collections;

public class SaveScript : MonoBehaviour {

    int level;
    int isLoaded;

	// Use this for initialization
	void Start () {

        level = PlayerPrefs.GetInt("LastLevel");
        isLoaded = PlayerPrefs.GetInt("Loaded");

        if(isLoaded == 1)
        {
            Application.LoadLevel(level);
            PlayerPrefs.SetInt("Loaded", 0);

        }
	}
	
	// Update is called once per frame
	void Update () {

        //string currentLevel = Application.loadedLevel;
        //Debug.Log(Application.loadedLevel);
        //Save(currentLevel);

	}

    void OnApplicationQuit()
    {
        //Save(Application.loadedLevel);
        PlayerPrefs.SetInt("LastLevel", Application.loadedLevel);

        //set to 1 if a scene is saved, then set this to zero upon resuming the application
        PlayerPrefs.SetInt("Loaded", 1);
    }

    void OnApplicationPause()
    {
        PlayerPrefs.SetInt("LastLevel", Application.loadedLevel);

        //set to 1 if a scene is saved, then set this to zero upon resuming the application
        PlayerPrefs.SetInt("Loaded", 1);

    }

    void Save(int level)
    {
        PlayerPrefs.SetInt("LastLevel", level);
    }

    
}
