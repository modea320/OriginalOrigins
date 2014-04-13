using UnityEngine;
using System.Collections;

public class AahAnimScript : MonoBehaviour {


    public GameObject master;
    public GameObject follower;
    Transform leader;
    public float delay;
    public float threshold;
    


    //public float delay = 0.06f;
    private Animator animator;

    Vector3 offsetPos;
    Vector3 currentPos;
    Vector3 targetPos;

    Vector3[] posArray = new Vector3[2];
    int count = 0;
    bool isMoving;
    bool movingLeft;
    bool movingRight;

    


	// Use this for initialization
	void Start () {

        
        leader = master.transform;

        posArray[0] = follower.transform.position;

        offsetPos = follower.transform.position - leader.position;

        animator = this.GetComponent<Animator>();

      

	}

    
    void LateUpdate()
    {
        // toggle between 0 and 1 for each frame
        if(count == 0)
        {
            count = 1;
        }
        else
        {
            count = 0;
        }

        // add current position to array
        posArray[count] = follower.transform.position;

        // check posArray[1] - posArray[0]
        if (count == 0)
        {
            // if the current and previous position are equal, the object isn't moving
            if (posArray[1] - posArray[0] == new Vector3(0, 0, 0) || Mathf.Abs(posArray[1].x - posArray[0].x) < threshold)
            {
                isMoving = false;
            }
            else
            {
                isMoving = true;

                // if current minus past position is negative, is moving to the left
                if(posArray[1].x - posArray[0].x < 0)
                {
                    movingLeft = true;
                    movingRight = false;

                }

                // otherwise moving to the right
                else
                {
                    movingLeft = false;
                    movingRight = true;
                }
                
            }
        }
        
        // check posArray[0] - posArray[1]
        else
        {
            if (posArray[1] - posArray[0] == new Vector3(0, 0, 0) || Mathf.Abs(posArray[1].x - posArray[0].x) < threshold)
            {
                isMoving = false;
            }
            else
            {
                isMoving = true;

                // if current minus past position is positive, is moving to the left
                // since now the positions are swapped, so the subtractions directions are
                // opposite.. sorry that this is confusing
                if(posArray[1].x - posArray[0].x > 0)
                {
                    movingLeft = true;
                    movingRight = false;

                }

                // otherwise moving to the right
                else
                {
                    movingLeft = false;
                    movingRight = true;
                }
            }
        }


        var targetPos = offsetPos + leader.position;

        float dT = Time.deltaTime / delay;

        float updatePos = Mathf.Abs(follower.transform.position.x - leader.position.x);

        if(updatePos > offsetPos.x * 1.5)
        {
            dT *= 1.0f;
        }

        

        follower.transform.position = Vector3.Lerp(transform.position, targetPos, dT);

        

        if(isMoving == false)
        {
            animator.SetFloat("Speed", 0.0f);
        }
        // moving to the left, left animation
        else if(movingLeft)
        {
            animator.SetInteger("Direction", 0);
            animator.SetFloat("Speed", 1.0f);
        }
        
        // moving to the right, right animation
        else if (movingRight)
        {
            animator.SetInteger("Direction", 1);
            animator.SetFloat("Speed", 1.0f);
        }

        // if not moving, no animation
        
       

    }
	

	// Update is called once per frame
	void Update () {
        /*
        // block that updates the array storing the positions of the master
        if (count < 10)
        {
            posArray[count] = leader.position;
            count++;
        }
        else
        {
            count = 0;
            posArray[count] = leader.position;
            count++;
        }

        if(count-delay < 0)
        {
            follower.transform.position = posArray[posArray.Length - delay] - gap;

        }

        else
        {
            follower.transform.position = posArray[count - delay];
        }
        


        animator.SetFloat("Speed", 0.0f);
        */
	}
}
