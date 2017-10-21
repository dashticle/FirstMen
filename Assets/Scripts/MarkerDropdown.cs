using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerDropdown : MonoBehaviour {
    private Dropdown markerDropdown;
    private MarkerPlacer markerPlacer;
    public GameObject[] markerPrefabs;

	// Use this for initialization
	void Start () {
        markerDropdown = GetComponent<Dropdown>();
        markerPlacer = Camera.main.GetComponent<MarkerPlacer>();
        markerPrefabs = markerPlacer.markerPrefabs;
        populateMarkerDropdown(markerPrefabs);
	}
	

    void populateMarkerDropdown(GameObject[] spawners)
    {
        markerDropdown.ClearOptions();
        foreach (GameObject marker in markerPrefabs)
        {
            markerDropdown.options.Add(new Dropdown.OptionData(marker.name.ToString()));
        }
        markerDropdown.RefreshShownValue();
    }
}
