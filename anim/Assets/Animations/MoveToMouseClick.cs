﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveToMouseClick : MonoBehaviour {

    public GameObject[] SendGoal;
	public LayerMask mask;
	public int mouse_button = 0;
    Animator m_Animator;
    bool is_moving;

    // Update is called once per frame
    void Update () {
		if(Input.GetMouseButton(mouse_button))
		{
			RaycastHit hit;
			Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(r, out hit) == true)
				transform.position = hit.point;
            foreach(GameObject go in SendGoal)
            {
                if(go != null && go.GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
                {
                    go.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = transform.position;
                }
            }
		}
	}

}
