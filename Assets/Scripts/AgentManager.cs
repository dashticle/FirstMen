using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour {

    public List<GameObject> allAgents;
    public List<Transform> wayPoints;

	// Use this for initialization
	void Awake () {

	}
	
    public void AddAgent (GameObject agent)
    {
        allAgents.Add(agent);
        agent.GetComponent<StateController>().SetupAI(true, wayPoints);
    }
}
