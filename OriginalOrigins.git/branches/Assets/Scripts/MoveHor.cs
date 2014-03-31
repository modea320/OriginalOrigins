﻿using UnityEngine;
using System.Collections;

public class MoveHor : MonoBehaviour {
	
	public Texture2D button1;
	public GameObject theObject;
	public int direction;
    public int speed;
	
	// Use this for initialization
	void Start () {
		guiTexture.texture = button1;		 
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if(guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
			{
				//guiTexture.texture = buton1;
				theObject.transform.Translate (Vector2.right * speed * direction * Time.smoothDeltaTime);
				
			}
		}
	}
}