using UnityEngine;
using System.Collections;

public class PlayerHealthScript : MonoBehaviour {

    public int playerHealth = 1;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("PlayerHealth", playerHealth);
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("PlayerHealth") <= 0)
        {
            // player dies and reloads the current level
            SoundManagerScript.Instance.MakeLoseSound();
            Application.LoadLevel(Application.loadedLevel);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        ShotScript shot = coll.gameObject.GetComponent<ShotScript>();
        if (shot != null && coll.gameObject.tag == "EShot")
        {
            PlayerPrefs.SetInt("PlayerHealth", PlayerPrefs.GetInt("PlayerHealth") - shot.damage);
            Destroy(shot.gameObject);
        }
    }
}
