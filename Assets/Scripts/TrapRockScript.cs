using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRockScript : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightShift))
		{
			Destroy (Player);
		}
		
	}
}
