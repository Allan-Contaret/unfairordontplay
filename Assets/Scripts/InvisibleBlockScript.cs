using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBlockScript : MonoBehaviour {
    private void OnCollisionEnter (Collision collision) {
        if(collision.gameObject.tag == "Rock")
            GetComponent<MeshRenderer>().enabled = true;		
    }
}
