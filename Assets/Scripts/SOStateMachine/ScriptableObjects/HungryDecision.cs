using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Hungry")]
public class HungryDecision : Decision
{

    public override bool Decide(StateController controller)
    {
        bool getFood = CheckHunger(controller);
        return getFood;
    }

    public bool CheckHunger(StateController controller)
    {
        if (controller.needScript.hunger < controller.needScript.acceptableHunger)
            return true;
        else return false;
    }
}
