using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{

    public State currentState;
    public Transform eyes;
    public State remainState;
    public float lookRadius = 20.0f;

    [HideInInspector]
    public NavMeshAgent navMeshAgent;
    [HideInInspector]
    public List<Transform> wayPointList;
    [HideInInspector]
    public int nextWayPoint;
    [HideInInspector]
    public Transform chaseTarget;
    [HideInInspector]
    public float stateTimeElapsed;

    public Marker currentMarker;
    public KnowlegeScript knowlegeScript;
    public NeedScript needScript;
    private AgentManager agentManager;
    private bool aiActive;


    void Awake()
    {
        knowlegeScript = GetComponent<KnowlegeScript>();
        knowlegeScript.eyes = eyes;
        knowlegeScript.lookRadius = lookRadius;
        needScript = GetComponent<NeedScript>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        agentManager = GameObject.Find("AgentManager").GetComponent<AgentManager>();
        agentManager.AddAgent(gameObject);
    }

    public void SetupAI(bool aiActivationFromAgentManager, List<Transform> wayPointsFromAgentManager)
    {
        wayPointList = wayPointsFromAgentManager;
        aiActive = aiActivationFromAgentManager;
        if (aiActive)
        {
            navMeshAgent.enabled = true;
        }
        else
        {
            navMeshAgent.enabled = false;
        }
    }

    void Update()
    {
        if (!aiActive)
            return;
        currentState.UpdateState(this);
    }

    void OnDrawGizmos()
    {
        if (currentState != null && eyes != null)
        {
            Gizmos.color = currentState.sceneGizmoColor;
            Gizmos.DrawWireSphere(eyes.position, lookRadius);
        }
    }

    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
            OnExitState();
        }
    }

    public bool CheckIfCountDownElapsed(float duration)
    {
        stateTimeElapsed += Time.deltaTime;
        return (stateTimeElapsed >= duration);
    }

    private void OnExitState()
    {
        stateTimeElapsed = 0;
    }
}