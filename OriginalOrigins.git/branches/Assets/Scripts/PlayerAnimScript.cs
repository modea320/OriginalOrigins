using UnityEngine;
using System.Collections;

public class PlayerAnimScript : MonoBehaviour {

    private Animator animator;
    public GUITexture rightButton;
    public GUITexture leftButton;

    

	// Use this for initialization
	void Start () {

        animator = this.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
	    foreach(Touch touch in Input.touches)
        {
            //for right button press
            if(rightButton.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                animator.SetInteger("Direction", 1);
                animator.SetFloat("Speed", 1.0f);
            }

            //for left button press
            else if (leftButton.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                animator.SetInteger("Direction", 0);
                animator.SetFloat("Speed", 1.0f);
            }

            //for no button press
            else
            {
                animator.SetFloat("Speed", 0.0f);
            }
        }
	}
}
