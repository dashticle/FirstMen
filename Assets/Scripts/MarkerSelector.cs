using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerSelector : MonoBehaviour {

    private MarkerPlacer markerPlacer;

    public GameObject[] markerPrefabs;

    void Start()
    {
        markerPlacer = GetComponent<MarkerPlacer>();
    }




}
