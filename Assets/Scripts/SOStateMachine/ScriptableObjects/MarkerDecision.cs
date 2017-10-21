using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Marker")]
public class MarkerDecision : Decision
{
    // Use this for initialization
    public override bool Decide(StateController controller) {
        bool MarkerExists = CheckMarkerExists(controller);
        return MarkerExists;
	}
	
    private bool CheckMarkerExists(StateController controller)
    {
        if (controller.currentMarker == null || controller.currentMarker.Equals(null))
        {
            Debug.Log("Chase target is null now");
            return false;
        }
        else
        {
            Debug.Log("Chase target not null");
            return true;
        }
    }
}
