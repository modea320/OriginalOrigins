using UnityEngine;


/// Projectile behavior

public class ShotScript : MonoBehaviour
{
    // 1 - Designer variables
    //public GameObject bossBird;
    //EdgeCollider2D collid;
    
    /// Damage inflicted
    
    public int damage = 1;

    
    /// Projectile damage player or enemies?
    
    public bool isEnemyShot = false;

    void Start()
    {
        //collid = bossBird.GetComponent<EdgeCollider2D>();
        // 2 - Limited time to live to avoid any leak
        Destroy(gameObject, 5); // 5sec
    }

    
    
    
}
