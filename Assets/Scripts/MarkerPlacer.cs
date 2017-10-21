using UnityEngine;
using System.Collections;

public class MarkerPlacer : MonoBehaviour
{

    public GameObject[] markerPrefabs;
    private GameObject selectedMarker;
    public LayerMask groundLayer;
    private GameObject currentObject;
    private Transform currentObjectTransform;
    public bool hasPlaced;

    // Use this for initialization
    void Start()
    {
        selectedMarker = markerPrefabs[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentObject != null && !hasPlaced)
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 9999.0F, groundLayer))
            {
                currentObjectTransform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                if (Input.GetMouseButtonDown(0))
                {
                    hasPlaced = true;
                    currentObject.GetComponent<MoveMarker>().enabled = true;
                }
            }
        }
    }

    public void SelectMarker(int dropDownSelection)
    {
        Debug.Log(dropDownSelection + " , which is " + markerPrefabs[dropDownSelection]);
        selectedMarker = markerPrefabs[dropDownSelection];
    }

    public void MarkerAction()
    {
        SetMarker(selectedMarker);
    }

    public void SetMarker(GameObject b)
    {
        hasPlaced = false;
        currentObject = (GameObject)Instantiate(b);
        switch (currentObject.tag)
        {
            case "MoveMarker":
                MoveMarker moveMarker = currentObject.GetComponent<MoveMarker>();
                break;
        }
        currentObjectTransform = currentObject.transform;
    }
}
