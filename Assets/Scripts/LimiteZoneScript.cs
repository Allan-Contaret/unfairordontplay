using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteZoneScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 90 || transform.position.x < -90 || transform.position.y < -10 || transform.position.y > 18
                || transform.position.z < -15 || transform.position.z > 15)
        {
            Destroy(gameObject);
        }
	}
}
