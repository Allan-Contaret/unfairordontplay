using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapScript : MonoBehaviour {
    public bool IsTrapActivated = false;
    private Vector3 StartPosition;
    private Vector3 EndPosition;

    private float timer = 0;

    void Start()
    {
        StartPosition = transform.localPosition;
        EndPosition = StartPosition + new Vector3(0, 5f, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsTrapActivated = true;
            timer = 0;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTrapActivated)
            timer += 4*Time.deltaTime;

        transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, timer);
    }
}
