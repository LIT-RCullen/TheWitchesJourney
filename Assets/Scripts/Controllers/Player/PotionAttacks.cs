using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionAttacks : MonoBehaviour
{
    EnemyStats target = null;

    private PlayerStats player;

    public float AttackSpeed = 20f;

    public GameObject firePoint;
    public GameObject firePrefab;
    public GameObject explosivePrefab;

    void Awake()
    {
        player = GetComponent<PlayerStats>();
    }

    private void Update()
    {
        FindTarget();
    }

    void FindTarget()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        EnemyStats[] allEnemies = GameObject.FindObjectsOfType<EnemyStats>();

        foreach (EnemyStats currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if ((distanceToEnemy < distanceToClosestEnemy) && (distanceToEnemy < 150))
            {
                distanceToClosestEnemy = distanceToEnemy;
                target = currentEnemy;
            }
        }
        if (target)
        {
            Debug.DrawLine(this.transform.position, target.transform.position);
        }
        
    }

    public void firePotion()
    {
        if(target)
        {
            firePoint.transform.LookAt(target.transform);
            Instantiate(firePrefab, firePoint.transform.position, firePoint.transform.rotation);
            firePoint.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        
    }

    public void ExplosivePotion()
    {
        if(target)
        {
            firePoint.transform.LookAt(target.transform);
            Instantiate(explosivePrefab, firePoint.transform.position, firePoint.transform.rotation);
            firePoint.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
       
    }
}
