using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent nm;
    public GameObject Enemy;
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.updateRotation = false;
        nm.updateUpAxis = false;
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        nm.SetDestination(target.position);
        transform.position = Enemy.GetComponent<Transform>().position - new Vector3(0,0.7f,0);
    }
    
}
