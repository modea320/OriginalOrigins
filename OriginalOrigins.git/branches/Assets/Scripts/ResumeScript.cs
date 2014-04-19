using UnityEngine;
using System.Collections;

public class ResumeScript : MonoBehaviour {

    public GUITexture theObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    foreach(Touch touch in Input.touches)
        {
            if(theObject.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                Application.LoadLevel(PlayerPrefs.GetInt("LastLevel"));
            }
        }
	}
}
