using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour
{

    public Collider2D collider;
    public string level;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Application.LoadLevel(level);
    }

}
