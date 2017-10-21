using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/MoveTo")]
public class MoveToAction : Action {

    public override void Act(StateController controller)
    {
        MoveToMarker(controller);
    }

    void MoveToMarker (StateController controller) {
        if(controller.currentMarker != null)
            controller.navMeshAgent.destination = controller.currentMarker.transform.position;
    }
}
