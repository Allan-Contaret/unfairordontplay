using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapScript : MonoBehaviour
{
    public bool IsCheckpointActivated = false;
    private Vector3 StartPosition;
    private Vector3 EndPosition;

    private float timer = 0;

    void Start()
    {
        StartPosition = transform.localPosition;
        EndPosition = StartPosition + new Vector3(0, 2f, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsCheckpointActivated = true;
            timer = 0;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCheckpointActivated)
            timer += 4 * Time.deltaTime;
        else
            timer -= Time.deltaTime;

        transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, timer);
    }
}
