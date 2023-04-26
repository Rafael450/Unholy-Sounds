using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class MainAIController : MonoBehaviour
{
    public NavMeshAgent nm;
    Rigidbody2D rb;
    public GameObject AI;
    float angle;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AI.GetComponent<EnemyBehavior>().enabled=true;
    }

    void Update()
    {
        rb.velocity = nm.velocity;
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player") SceneManager.LoadScene("Derrota");
    }
}
