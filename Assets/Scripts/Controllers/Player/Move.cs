using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float dirX, moveSpeed, dirZ;
    public float dashSpeed, dashTime;
    public GameObject shadow;

    public Animator ChAnim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = -10f;
    }

    void Update()
    {
        
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        dirZ = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;

        ChAnim.SetFloat("Horizontal", dirX);
        ChAnim.SetFloat("Vertical", dirZ);
        
        if((dirX != 0) && (dirZ != 0))
        {
            ChAnim.SetFloat("Speed", 1);
        }
        else if((dirX == 0) && (dirZ == 0))
        {
            ChAnim.SetFloat("Speed", 0);
        }
        

        if (dirX < 0)
        {
            transform.localEulerAngles = new Vector3(-30, 0, 0);
            shadow.transform.localEulerAngles = new Vector3(-60, 0, 0);
        }
        else if (dirX > 0)
        {
            transform.localEulerAngles = new Vector3(30, 180, 0);
            shadow.transform.localEulerAngles = new Vector3(60, 0, 0);
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

    public void Dash()
    {
        StartCoroutine(CDash());
    }

    IEnumerator CDash()
    {
        float startTime = Time.time;

        while(Time.time < startTime + dashTime)
        {
            dirX = dirX * dashSpeed * Time.deltaTime;
            dirZ = dirZ * dashSpeed * Time.deltaTime;

            yield return null;
        }
    }
}
