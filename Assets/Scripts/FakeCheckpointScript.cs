using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeCheckpointScript : MonoBehaviour {
    private Vector3 StartPosition;
    private Vector3 EndPosition;

    public bool IsFakeCheckpointActivated = false;
    private float timer = 0;
    public GameObject Flag;

    // Use this for initialization
    void Start () {
        StartPosition = Flag.transform.localPosition;
        EndPosition = StartPosition + new Vector3(0, 2f, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (IsFakeCheckpointActivated)
            timer += Time.deltaTime;

        Flag.transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, timer);
    }

    void OnTriggerEnter(Collider other)
    {
        // If the player passes through the checkpoint, we activate it
        if (other.tag == "Player")
        {
            IsFakeCheckpointActivated = true;
        }
    }
}
