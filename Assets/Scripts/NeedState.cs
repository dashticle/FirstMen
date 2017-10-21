using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedState : IAgentState {

    private readonly FirstStatePattern agent;

    public NeedState(FirstStatePattern firstStatePattern)
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
        agent.currentState = agent.workState;
    }

    public void ToNeedState()
    {
        Debug.Log("Can't switch to current state");
    }

    public void OnTriggerEnter(Collider collider)
    {

    }


}
