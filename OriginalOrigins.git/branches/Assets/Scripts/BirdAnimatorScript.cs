using UnityEngine;
using System.Collections;

public class BirdAnimatorScript : MonoBehaviour {
    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetInteger("Attacking", PlayerPrefs.GetInt("BirdAttack"));
	}
}
