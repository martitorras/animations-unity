using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    Animator m_Animator;
    NavMeshAgent navmesh;
    bool is_moving;
    // Start is called before the first frame update
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(navmesh.remainingDistance >= 0.1f)
        {
            m_Animator.SetBool("Is_moving", true);
        }
        else m_Animator.SetBool("Is_moving", false);



    }
}
