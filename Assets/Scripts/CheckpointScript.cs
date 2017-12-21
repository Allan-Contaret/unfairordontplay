using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private Vector3 StartPosition;
    private Vector3 EndPosition;

    public bool IsCheckpointActivated = false;
    public static GameObject[] CheckPointsList;

    private float timer = 0;
    public GameObject Flag;

    public static Vector3 GetActiveCheckPointPosition()
    {
        // If player die without activate any checkpoint, we will return a default position
        Vector3 result = new Vector3(73, 5, 0);

        if (CheckPointsList != null)
        {
            foreach (GameObject cp in CheckPointsList)
            {
                // We search the IsCheckpointActivated checkpoint to get its position
                if (cp.GetComponent<CheckpointScript>().IsCheckpointActivated)
                {
                    result = cp.transform.position;
                    break;
                }
            }
        }
        return result;
    }

    private void ActivateCheckPoint()
    {
        // We deactive all checkpoints in the scene
        foreach (GameObject cp in CheckPointsList)
        {
            cp.GetComponent<CheckpointScript>().IsCheckpointActivated = false;
        }

        // We IsCheckpointActivated the current checkpoint
        IsCheckpointActivated = true;
    }

    void Start()
    {
        // We search all the checkpoints in the current scene
        CheckPointsList = GameObject.FindGameObjectsWithTag("Checkpoint");

        StartPosition = Flag.transform.localPosition;
        EndPosition = StartPosition + new Vector3(0, 2f, 0);
    }

    void Update()
    {
        if (IsCheckpointActivated)
            timer += 4 * Time.deltaTime;

        Flag.transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, timer);
    }

    void OnTriggerEnter(Collider other)
    {
        // If the player passes through the checkpoint, we activate it
        if (other.tag == "Player")
        {
            ActivateCheckPoint();
        }
    }
}