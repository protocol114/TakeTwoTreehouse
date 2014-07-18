﻿using System;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    public float moveSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        if (rigidbody2D.velocity != new Vector2(moveHorizontal * moveSpeed, moveVertical * moveSpeed))

            rigidbody2D.velocity = Vector2.Lerp(rigidbody2D.velocity, new Vector2(moveHorizontal * moveSpeed, moveVertical * moveSpeed), 1);

	}
}