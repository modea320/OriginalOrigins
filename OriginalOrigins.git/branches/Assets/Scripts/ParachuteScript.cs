using UnityEngine;
using System.Collections;

public class ParachuteScript : MonoBehaviour {

    public GameObject theObject;
    //public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //constant downward float
        theObject.transform.Translate(Vector2.up * -1 * 1/20);
        //theObject.transform.position -= Vector2.up * speed;

	
	}
}
