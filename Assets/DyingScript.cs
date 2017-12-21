using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingScript : MonoBehaviour {
    private void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
    }
}
