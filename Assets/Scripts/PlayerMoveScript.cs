using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
    public float SpeedMovement;
    public float JumpPower;
    public bool CanJump = false;
    public float MaxSpeed;
    private bool isArrowButtonClicked = false;
	public AudioClip playSound;
	private AudioSource source;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
		source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKey("space")  || Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
        {
            isArrowButtonClicked = true;
            animator.SetBool("IsArrowButtonClicked", isArrowButtonClicked);
        } else
        {
            isArrowButtonClicked = false;
            animator.SetBool("IsArrowButtonClicked", isArrowButtonClicked);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude < MaxSpeed)
        {
            if (Input.GetKey("up"))
            {
                GetComponent<Rigidbody>().AddForce(transform.forward * SpeedMovement);
            }
            if (Input.GetKey("down"))
            {
                GetComponent<Rigidbody>().AddForce(-transform.forward * SpeedMovement);
            }
            if (Input.GetKey("left"))
            {
                GetComponent<Rigidbody>().AddForce(-transform.right * SpeedMovement);
            }
            if (Input.GetKey("right"))
            {
                GetComponent<Rigidbody>().AddForce(transform.right * SpeedMovement);
            }
        } 
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
			source.PlayOneShot(playSound);
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
        }
        CanJump = false;
    }

    private void OnTriggerStay(Collider other)
    {
        CanJump = true;
    }
}
