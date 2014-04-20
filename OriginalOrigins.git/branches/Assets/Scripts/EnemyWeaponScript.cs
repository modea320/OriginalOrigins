using UnityEngine;
using System.Collections;

public class EnemyWeaponScript : MonoBehaviour {
    /// Projectile prefab for shooting    
    public Transform shotPrefab;
    //public GameObject theObject;
    //public Texture attackImg;

    /// Cooldown in seconds between two shots   
    public float shootingRate = 0.25f;

    private float shootCooldown;

	// Use this for initialization
	void Start () {
        shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {

        
        PlayerPrefs.SetInt("BirdAttack", 1);

        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }

        if (CanAttack)
        {
            shootCooldown = shootingRate;

            // Create a new shot
            var shotTransform = Instantiate(shotPrefab) as Transform;
            
            PlayerPrefs.SetInt("BirdAttack", 0);
            

            shotTransform.position = new Vector3(transform.position.x - 8, transform.position.y + 4, transform.position.z);
            
        }

	}

    /// Is the weapon ready to create a new projectile?    
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0.0f;
        }
    }
}
