using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class Enemy : LivingEntity
{
    // Start is called before the first frame update

    NavMeshAgent pathfinder;
    Transform target;

    protected override void Start()
    {
        base.Start();
        pathfinder = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(updatePath());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator updatePath(){
        float refershRate = 0.25f;
        while (target != null){
            Vector3 targetPosition = new Vector3(target.position.x, 0 , target.position.z);
            if(!dead){
                pathfinder.SetDestination(targetPosition);
            }
            yield return new WaitForSeconds(refershRate);
        }
    }
}
