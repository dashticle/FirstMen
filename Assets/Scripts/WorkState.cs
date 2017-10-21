using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : IAgentState
{

    private readonly FirstStatePattern agent;

    public WorkState(FirstStatePattern firstStatePattern)
    {
        agent = firstStatePattern;
    }

    public void UpdateState()
    {

    }

    public void ToLeisureState()
    {
        agent.currentState = agent.leisureState;
    }

    public void ToWorkState()
    {
        Debug.Log("Can't switch to current state");
    }

    public void ToNeedState()
    {
        agent.currentState = agent.needState;
    }

    public void OnTriggerEnter(Collider collider)
    {

    }


}
