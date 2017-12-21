using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : CheckpointScript {

	// Use this for initialization
	void Start () {
        transform.position = GetActiveCheckPointPosition();
	}
}
