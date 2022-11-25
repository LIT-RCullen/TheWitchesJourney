using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float dirX, moveSpeed, dirZ;

    public Animator ChAnim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = -5f;
    }

    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        dirZ = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;

        if (dirX < 0)
        {
            transform.localEulerAngles = new Vector3(-30, 0, 0);
        }
        else if (dirX > 0)
        {
            transform.localEulerAngles = new Vector3(30, 180, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, 0, dirZ);
    }

    public void Attack()
    {
        ChAnim.SetTrigger("Attack");
    }
}
