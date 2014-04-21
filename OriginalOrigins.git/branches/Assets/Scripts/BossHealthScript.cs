using UnityEngine;
using System.Collections;

public class BossHealthScript : MonoBehaviour {

    public GUITexture screenFlash;
    public int flashFrameDuration;

    //public EdgeCollider2D bossCollider;
    public int bossHealth = 10;
    private int flashCounter;

	// Use this for initialization
	void Start () {

        PlayerPrefs.SetInt("BossHealth", bossHealth);
        screenFlash.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //print(PlayerPrefs.GetInt("BossHealth"));
        if(screenFlash.enabled == true)
        {
            flashCounter--;
            if(flashCounter == 0)
            {
                screenFlash.enabled = false;
            }
        }

	    if(PlayerPrefs.GetInt("BossHealth") <= 0)
        {
            //loads the end cutscene
            Application.LoadLevel(17);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        /*
        //if (coll.gameObject.tag == "BossBird")
        if (coll.collider == collid)
        {
            PlayerPrefs.SetInt("BossHealth", PlayerPrefs.GetInt("BossHealth") - damage);
            Destroy(gameObject);
        }
        */

        ShotScript shot = coll.gameObject.GetComponent<ShotScript>();
        if(shot != null && coll.gameObject.tag == "PShot")
        {
            PlayerPrefs.SetInt("BossHealth", PlayerPrefs.GetInt("BossHealth") - shot.damage);
            screenFlash.enabled = true;
            flashCounter = flashFrameDuration;
            Destroy(shot.gameObject);
        }
    }
}
