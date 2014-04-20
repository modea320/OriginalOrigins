using UnityEngine;
using System.Collections;

public class ShotMoveScript : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(1, 1);

    private Vector2 movement;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("FacingRight") == 0)
        {
            movement = new Vector2(speed.x * direction.x * -1, speed.y * direction.y);
        }

        else
        {
            movement = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y);
        }
    }

    // Update is called once per frame
    void Update()
    {



    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}
