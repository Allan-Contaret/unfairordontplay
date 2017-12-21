using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpikesScript : MonoBehaviour
{
    public GameObject Player;
    public Transform PlayersPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.GetComponent<Rigidbody>().AddForce(PlayersPosition.right * 250);
            Player.GetComponent<Rigidbody>().AddForce(PlayersPosition.up * 250);
        }
    }
}