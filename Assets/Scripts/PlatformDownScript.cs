﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDownScript : MonoBehaviour {

	private void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().mass = 50f;
		}
	}
}
