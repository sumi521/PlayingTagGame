using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    // Start is called before the first frame update

    void Awake(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
