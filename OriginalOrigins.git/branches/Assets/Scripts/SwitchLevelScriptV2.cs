using UnityEngine;
using System.Collections;

public class SwitchLevelScriptV2 : MonoBehaviour
{

    public Texture2D button1;
    //public Texture2D button2;
    public int level;



    // Use this for initialization
    void Start()
    {
        guiTexture.texture = button1;

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                //guiTexture.texture = button2;
                Application.LoadLevel(level);

            }

        }

    }
}
