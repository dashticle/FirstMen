using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedScript : MonoBehaviour {

    public float hunger = 100.0f;
    public float metabolism = 0.1f;

    public float acceptableHunger;

	// Use this for initialization
	void Start () {
        StartCoroutine(ReduceHunger());
	}

    IEnumerator ReduceHunger()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            hunger -= metabolism;
        }
    }
}
