﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

	public bool leftHand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!leftHand) {
//			transform.localPosition = OVRInput.GetLocalControllerPosition ();
//			transform.localRotation = GetLocalControllerRotation ();
		}
	}
}
