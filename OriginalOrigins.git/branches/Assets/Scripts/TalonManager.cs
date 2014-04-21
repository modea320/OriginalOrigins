using UnityEngine;
using System.Collections;

public class TalonManager : MonoBehaviour {

    //public GameObject theTalon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        //MoveScript moveScript = coll.gameObject.GetComponent<MoveScript>();
        if(coll.gameObject.tag == "Talons")
        {
            // makes the talong change direction and go to the upper right
            coll.gameObject.GetComponent<MoveScript>().direction = new Vector2(1, 1);
            //moveScript.direction = new Vector2(1, 1);
            //Destroy(coll.gameObject.GetComponent<MoveScript>());
            //coll.gameObject.AddComponent("MoveUpScript");
        }
    }
}
