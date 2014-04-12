using UnityEngine;
using System.Collections;

public class AahAnimScript : MonoBehaviour {


    public GameObject master;
    public GameObject follower;
    Transform leader;
    public int delay;
    //public float delay = 0.06f;
    private Animator animator;

    Vector3 offsetPos;
    Vector3 currentPos;
    Vector3 targetPos;

    Vector3[] posArray = new Vector3[10];
    int count;

    //Quaternion startRot;
    //Quaternion leaderRot;


	// Use this for initialization
	void Start () {

        
        leader = master.transform;

        posArray[0] = leader.position;

        //offsetPos = follower.transform.position - leader.position;

        animator = this.GetComponent<Animator>();

        //startRot = transform.rotation;
        //leaderRot = leader.rotation;

	}

    /*
    void LateUpdate()
    {

        
        var targetPos = offsetPos + leader.position;

        //var targetRot = Quaternion.Inverse(leaderRot) * leader.rotation * startRot;

        var dT = Time.deltaTime / delay;
        follower.transform.position = Vector3.Lerp(transform.position, targetPos, dT);

        //follower.transform.position = transform.position;
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, dT);

    }
	*/

	// Update is called once per frame
	void Update () {
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
            follower.transform.position = posArray[posArray.Length - delay];

        }

        else
        {
            follower.transform.position = posArray[count - delay];
        }
        


        animator.SetFloat("Speed", 0.0f);

	}
}
