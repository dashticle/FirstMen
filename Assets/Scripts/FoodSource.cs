using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSource : MonoBehaviour {

    public float FoodAvailable = 1000.0F;

    public void SupplyFood(NeedScript takerNeeds, float amount)
    {
        FoodAvailable -= amount;
        takerNeeds.hunger += amount;
    }

    public bool hasFood()
    {
        return FoodAvailable > 0;
    }

}
