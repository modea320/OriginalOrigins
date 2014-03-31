using UnityEngine;
using System.Collections;

public class GoToSceneButtonScript : MonoBehaviour {

    public Texture2D button1;
    public Texture2D button2;
    public GameObject Scene;
    

	// Use this for initialization
	void Start () {
        guiTexture.texture = button1;
        
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                guiTexture.texture = button2;

                Application.LoadLevel("Level1");
              
            }
            else if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended)
            {
                guiTexture.texture = button1;
                
            }
        }
	
	}
}
