using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FirstStatePattern : MonoBehaviour {

    [HideInInspector]
    public Transform chaseTarget;
    [HideInInspector]
    public IAgentState currentState;
    [HideInInspector]
    public WorkState workState;
    [HideInInspector]
    public LeisureState leisureState;
    [HideInInspector]
    public NeedState needState;
    [HideInInspector]
    public NavMeshAgent navMeshAgent;

    // Use this for initialization
    void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();

        workState = new WorkState(this);
        leisureState = new LeisureState(this);
        needState = new NeedState(this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
