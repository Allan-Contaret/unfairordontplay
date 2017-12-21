using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpikesScript : MonoBehaviour
{
    public GameObject Player;
    public Transform PlayersPosition;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            Player.GetComponent<Rigidbody>().AddForce(-PlayersPosition.forward * 2000);
    }
}
