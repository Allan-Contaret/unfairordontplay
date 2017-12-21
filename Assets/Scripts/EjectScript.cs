using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectScript : MonoBehaviour
{

    private bool CanTake = false;
    public int Power;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightShift) && CanTake)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = GameObject.Find("EjectPosition").transform.position;
            transform.parent = GameObject.Find("EjectPosition").transform;
        }
		if(Input.GetButtonDown("Fire1") && CanTake)
        {

            Launch();
        }

    }

    void Launch()
    {

        transform.parent = null;
        GetComponent<Rigidbody>().isKinematic = false;
		GetComponent<Rigidbody>().AddForce(transform.TransformDirection(-Vector3.right * Power));
    }
   
	void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("ramasse");
            CanTake = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            CanTake = false;
        }
    }
}
