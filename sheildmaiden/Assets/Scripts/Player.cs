﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	// Use this for initialization
	protected override void Start () 
	{
		base.Start ();
	}
	
	// Update is called once per frame
	protected override void Update () 
	{
		GetInput ();

		base.Update ();
	}

	private void GetInput()
	{
		direction = Vector2.zero;

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
		{
			direction += Vector2.up;
		}
		else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
		{
			direction += Vector2.down;
		}
		else if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			direction += Vector2.left;
		}
		else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			direction += Vector2.right;
		}
	}
}
