using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : CheckpointScript {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(PlayerPrefs.GetFloat("CheckpointX"), PlayerPrefs.GetFloat("CheckpointY"), PlayerPrefs.GetFloat("CheckpointZ"));
	}
}
