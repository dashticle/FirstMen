using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/MarkerLook")]
public class MarkerLookDecision : Decision
{

    public override bool Decide(StateController controller)
    {
        bool targetVisible = Look(controller);
        return targetVisible;
    }

    private bool Look(StateController controller)
    {
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.lookRadius, Color.green);

        if (Physics.SphereCast(controller.eyes.position, controller.lookRadius, controller.eyes.forward, out hit, controller.lookRadius)
            && hit.collider.CompareTag("Marker"))
        {
            controller.currentMarker = hit.collider.gameObject.GetComponent<Marker>();
            return true;
        }
        else
        {
            return false;
        }
    }
}