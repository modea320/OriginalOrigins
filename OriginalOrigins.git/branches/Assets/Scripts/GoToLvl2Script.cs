using UnityEngine;
using System.Collections;

public class GoToLvl2Script : MonoBehaviour
{

    public Texture2D button1;
    public Texture2D button2;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Application.LoadLevel("Level2");
    }

    // Use this for initialization
    void Start()
    {
        guiTexture.texture = button1;


    }

    // Update is called once per frame
    void Update()
    {
     //   foreach (Touch touch in Input.touches)
     //   {
     //       if (guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
      //      {
         //       guiTexture.texture = button2;
//
         //       Application.LoadLevel("Level2");

        //    }
      //      else if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended)
        //    {
       //         guiTexture.texture = button1;
                
  //          }
//        }

    }
}
