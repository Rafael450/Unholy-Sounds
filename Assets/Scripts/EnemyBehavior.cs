using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent nm;
    public GameObject Enemy;

    private SoundController sound;
    void Start()
    {
        sound = Enemy.GetComponent<SoundController>();

        nm = GetComponent<NavMeshAgent>();
        nm.updateRotation = false;
        nm.updateUpAxis = false;
        target = GameObject.Find("Player").transform;

        Debug.Log(sound);

        sound.PlayStartSound();
    }

    void Update()
    {
        nm.SetDestination(target.position);
        transform.position = Enemy.GetComponent<Transform>().position;
        if((target.position - Enemy.GetComponent<Transform>().position).magnitude >= 100) // distance
        {
            float angle = Random.Range(0f, Mathf.PI * 2);
            Vector3 randomVector = (new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0))*25;
            
            Enemy.GetComponent<Transform>().position = target.position + randomVector;
            sound.PlayAproxSound();
        }
        
    }
    
}
