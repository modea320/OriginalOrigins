using UnityEngine;
using System.Collections;

public class BossMoveScript : MonoBehaviour {

    public GameObject theObject;

    public float xScale = 1.0F;
    public float yScale = 1.0F;

    

    public float widthScale = 1.0F;
    public float heightScale = 1.0F;

    //private int xSeed;
    //private int ySeed;

	// Use this for initialization
	void Start () {
        //xSeed = Random.Range(1, 50);
        //ySeed = Random.Range(1, 20);
	}
	
	// Update is called once per frame
	void Update () {

        //print(theObject.transform.position);
        
        float newX = widthScale * Mathf.PerlinNoise(Time.time * xScale, 0.0F);
        float newY = heightScale * Mathf.PerlinNoise(0.0F, Time.time * yScale);

        //float newX = widthScale * Mathf.PerlinNoise(xSeed * xScale, 0.0F);
        //float newY = heightScale * Mathf.PerlinNoise(0.0F, ySeed * yScale);

        Vector3 newPos = theObject.transform.position;
        newPos.x = newX;
        newPos.y = newY;

        theObject.transform.position = newPos;
        

        /*
        Vector3 newerPos = theObject.transform.position;
        newerPos.x += 1.0F;
        newerPos.y += 1.0F;

        print(newerPos);

        theObject.transform.position = newerPos;
        */
        //print(theObject.transform.position);
        
	}
}
