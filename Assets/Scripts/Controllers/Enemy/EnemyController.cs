using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    private Vector3 lastPos;
    private Vector3 currentPos;
    private float dirX;

    EnemyAttack attack;
    public float CooldownTime = 1f;
    private float lastAttackTime = -999f;
    public float StartY;

    public GameObject shadow;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, StartY, transform.position.z);
        target = PlayerManager.InstancePlayer.player.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateUpAxis = false;
        currentPos = transform.position;
        attack = GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y != StartY)
        {
            transform.position = new Vector3(transform.position.x, StartY, transform.position.z);
        }

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.destination = target.position;
            
            if (distance <= agent.stoppingDistance)
            {
                if (Time.time > lastAttackTime + CooldownTime)
                {
                    lastAttackTime = Time.time;
                    attack.Attack();
                }
            }

        }

        dirX = currentPos.x - lastPos.x;

        if (dirX > 0)
        {
            transform.localEulerAngles = new Vector3(30, 180, 0);
            shadow.transform.localEulerAngles = new Vector3(60, 0, 0);

        }
        else if (dirX < 0)
        {
            transform.localEulerAngles = new Vector3(-30, 0, 0);
            shadow.transform.localEulerAngles = new Vector3(-60, 0, 0);
        }

        if (transform.position != currentPos)
        {
            lastPos = currentPos;
            currentPos = transform.position;
        }

    }

    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
