using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Transform target;

    public bool isPhysical = false;
    public bool isShooter = false;
    public float AttackSpeed = 20f;

    public GameObject firePoint;
    public GameObject bulletPrefab;

    public Animator anim;

    public void Awake()
    {

        if (isPhysical && isShooter)
        {
            Debug.LogWarning(transform.name + "has been marked as both a physical and distanced attacker. Please fix this.");
        }

    }
    
    void Start()
    {
        target = PlayerManager.InstancePlayer.player.transform;

    }

    public void Attack()
    {
        if (isPhysical)
        {
            DiveAttack();
        }
        else if (isShooter)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        firePoint.transform.LookAt(target);
        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
    }

    private void DiveAttack()
    {
        firePoint.transform.LookAt(target);

        //anim.SetTrigger("attack");
    }
}
