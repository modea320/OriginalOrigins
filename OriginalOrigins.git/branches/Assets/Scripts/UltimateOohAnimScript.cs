using UnityEngine;
using System.Collections;

public class UltimateOohAnimScript : MonoBehaviour {

    private Animator animator;
    public GUITexture rightButton;
    public GUITexture leftButton;
    public GUITexture attackButton;

	// Use this for initialization
	void Start () {
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        foreach (Touch touch in Input.touches)
        {
            //for right button press
            if (rightButton.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                animator.SetInteger("Direction", 0);
            }

            //for left button press
            else if (leftButton.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                animator.SetInteger("Direction", 1);
            }

            if(attackButton.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                animator.SetFloat("Attacking", 1);
            }
            else
            {
                animator.SetFloat("Attacking", 0);
            }
        }
	}
}
