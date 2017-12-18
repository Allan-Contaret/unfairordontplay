using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectScript : MonoBehaviour
{

    private bool CanTake = false;
    private GameObject Eject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && CanTake && Eject != null)
        {
            //Eject.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Eject.transform.position = GameObject.Find("EjectPosition").transform.position;
            Eject.gameObject.transform.parent = GameObject.Find("EjectPosition").transform;
        }

    }
    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Rock")
        {
            Eject = collider.gameObject;
            CanTake = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject.tag == "")
        {
            Eject = null;
            CanTake = false;
        }
    }
}
