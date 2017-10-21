using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarker : Marker { 

	// Use this for initialization
	public override void Start () {
		
	}
	
	// Update is called once per frame
	public override void Update () {
        Destroy(this.gameObject, 7.0f);
	}
}
