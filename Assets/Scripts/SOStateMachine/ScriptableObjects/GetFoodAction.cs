using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/GetFood")]
public class GetFoodAction : Action
{

    public override void Act(StateController controller)
    {
        GetFood(controller);
    }

    public void GetFood(StateController controller)
    {

    }
}
