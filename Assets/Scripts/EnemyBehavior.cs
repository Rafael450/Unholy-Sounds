using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent nm;
    private float time = 0;
    private float nextSecond = 45;

    private bool playerOnce = false;

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

        time += Time.deltaTime;

        if(time >= nextSecond)
        {
            playerOnce = false;
            nextSecond++;
            if(Random.Range(0, 100f) <= 1)
            {
                nextSecond = 45f;
                sound.PlayRandomSound();
                time = 0f;

            }
        }
        if((target.position - Enemy.GetComponent<Transform>().position).magnitude >= 65) // distance
        {
            float angle = Random.Range(0f, Mathf.PI * 2);
            Vector3 randomVector = (new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0))*25;
            
            Enemy.GetComponent<Transform>().position = target.position + randomVector;
            nm.Warp(Enemy.transform.position);

            sound.PlayAproxSound();
        }
        else if((target.position - Enemy.GetComponent<Transform>().position).magnitude <= 22  && !playerOnce)
        {
            playerOnce = true;
            sound.PlayAproxSound();
        }
        
    }
    
}
