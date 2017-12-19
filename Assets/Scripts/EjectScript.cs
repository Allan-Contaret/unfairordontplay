using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectScript : MonoBehaviour
{

    private bool CanTake = false;
    private GameObject Eject;
    public int Power;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightShift) && CanTake && Eject != null)
        {
            Eject.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Eject.transform.position = GameObject.Find("EjectPosition").transform.position;
            Eject.gameObject.transform.parent = GameObject.Find("EjectPosition").transform;
        }
        if(Input.GetButtonDown("Fire1") && Eject != null)
        {

            Launch();
        }

    }

    void Launch()
    {

        Eject.gameObject.transform.parent = null;
        Eject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        Eject.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward * Power));
    }
    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Rock")
        {
            Debug.Log("ramasse");
            Eject = collider.gameObject;
            CanTake = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject.tag == "Rock")
        {
            Eject = null;
            CanTake = false;
        }
    }
}
