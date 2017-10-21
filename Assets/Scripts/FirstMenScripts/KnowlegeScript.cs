using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowlegeScript : MonoBehaviour {

    public Transform eyes;
    public float lookRadius;

    public Collider[] nearbyStuff;

    public List<Marker> relevantMarkers;
    public List<FoodSource> foodSourcesKnown;

    void Awake()
    {
        StartCoroutine("LookAround", 0.3f);
    }

    IEnumerator LookAround()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            nearbyStuff = Physics.OverlapSphere(eyes.position, lookRadius);
            foreach(Collider collider in nearbyStuff)
            {
                switch (collider.gameObject.tag)
                {
                    case "Food": 
                        if (!foodSourcesKnown.Contains(collider.gameObject.GetComponent<FoodSource>()))  {
                            foodSourcesKnown.Add(collider.gameObject.GetComponent<FoodSource>());
                        }
                        break;
                    default:
                        Debug.Log("Unrecognized collider");
                        break;
                }
            }
        }
    }

    

}
