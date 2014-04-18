using UnityEngine;


/// Launch projectile
public class WeaponScript : MonoBehaviour
{
    
    /// Projectile prefab for shooting    
    public Transform shotPrefab;
    public GUITexture shotButton;
    

    
    /// Cooldown in seconds between two shots   
    public float shootingRate = 0.25f;
    
    // 2 - Cooldown

    private float shootCooldown;

    void Start()
    {
        shootCooldown = 0f;
        
        

    }

    void Update()
    {
        

        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }

        foreach (Touch touch in Input.touches)
        {
            if (shotButton.HitTest(touch.position) && touch.phase == TouchPhase.Began)
            {
                if (CanAttack)
                {
                    shootCooldown = shootingRate;

                    // Create a new shot
                    var shotTransform = Instantiate(shotPrefab) as Transform;

                    // Assign position
                    //shotTransform.position = transform.position;
                    if(PlayerPrefs.GetInt("FacingRight") == 1)
                    {
                        shotTransform.position = new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z);
                    }
                    else if (PlayerPrefs.GetInt("FacingRight") == 0)
                    {
                        shotTransform.position = new Vector3(transform.position.x - 1, transform.position.y + 1, transform.position.z);
                        //shotTransform.Rotate(Vector3.up, Mathf.PI);
                    }
                    

                    /*
                    // The is enemy property
                    ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();

                    if (shot != null)
                    {
                        shot.isEnemyShot = isEnemy;
                    }
                    */

                    /*
                    // Make the weapon shot always towards it
                    MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
                    if (move != null)
                    {
                        move.direction = this.transform.right; // towards in 2D space is the right of the sprite
                    }
                    */
                }
            }
        }
    }

    
    // 3 - Shooting from another script

    /*
    /// Create a new projectile if possible    
    public void Attack(bool isEnemy)
    {
        
    }
    */

    
    /// Is the weapon ready to create a new projectile?    
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0.0f;
        }
    }
}