using UnityEngine;
using System.Collections;

public class DestroyByTimeScript : MonoBehaviour {
    public float lifetime;

    void Start ()
    {
        Destroy (gameObject, lifetime);
    }
}