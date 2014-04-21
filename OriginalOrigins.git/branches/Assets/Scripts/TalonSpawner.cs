using UnityEngine;
using System.Collections;

public class TalonSpawner : MonoBehaviour {

    public Transform talonPrefab;
    public GameObject thePlayer;

    public int distBehind;
    public int distAbove;

    public int attackFrequency;

    private int count;

	// Use this for initialization
	void Start () {
        count = attackFrequency;
	}
	
	// Update is called once per frame
	void Update () {
        count++;

        if (count >= attackFrequency)
        {
            // spawn the bird
            var talonTransform = Instantiate(talonPrefab) as Transform;

            // creates a random number from 0 to 1 (since 2 is not inclusive)
            int placement = Random.Range(0, 2);

            // Spawn behind the character
            if(placement == 0)
            {
                SoundManagerScript.Instance.MakeScreechSound();
                talonTransform.position = new Vector3(thePlayer.transform.position.x - distBehind, thePlayer.transform.position.y +
                    distAbove, transform.position.z);
            }
            // spawn in front of the character
            else
            {
                SoundManagerScript.Instance.MakeScreechSound();
                talonTransform.position = new Vector3(thePlayer.transform.position.x - distBehind/2 , thePlayer.transform.position.y +
                    distAbove, transform.position.z);
            }
            

            count = 0;
        }
	}
}
