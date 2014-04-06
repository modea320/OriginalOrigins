using UnityEngine;
using System.Collections;

public class WormScript : MonoBehaviour {

    public GameObject theWorm;
    Transform theTransform;
    Vector3 thePosition;

    

    public float maxDist = 1;
    public float speed = 50;

    float angle = -90;
    float toDegrees = Mathf.PI / 180;
    float startHeight;
    float xPos;
    float zPos;
    float newHeight;

    //set the starting height to equal the worm's current height
    void Start()
    {
        theTransform = theWorm.transform;
        thePosition = transform.position;
        startHeight = thePosition.y;

        xPos = thePosition.x;        
        zPos = thePosition.z;
    }

    void FixedUpdate()
    {
        angle += speed * Time.deltaTime;
        if (angle > 270)
        {
            angle -= 360;
        }

        newHeight = startHeight + maxDist * (1 + Mathf.Sin(angle * toDegrees)) / 2;
        //transform.position = position;
        theWorm.transform.position = new Vector3(xPos, newHeight, zPos);
            
    }

}
