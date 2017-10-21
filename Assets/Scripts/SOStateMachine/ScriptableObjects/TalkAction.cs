using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Talk")]
public class TalkAction : Action
{
    public override void Act(StateController controller)
    {
        Talk(controller);
    }

    private void Talk(StateController controller)
    {
        Debug.Log("Talking now");
    }
}