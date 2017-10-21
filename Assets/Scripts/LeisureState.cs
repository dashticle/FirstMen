using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeisureState : IAgentState
{

    private readonly FirstStatePattern agent;

    public LeisureState(FirstStatePattern firstStatePattern)
    {
        agent = firstStatePattern;
    }

    public void UpdateState()
    {

    }

    public void ToLeisureState()
    {
        Debug.Log("Can't switch to current state");
    }

    public void ToWorkState()
    {
        agent.currentState = agent.workState;
    }

    public void ToNeedState()
    {
        agent.currentState = agent.needState;
    }

    public void OnTriggerEnter(Collider collider)
    {

    }


}
