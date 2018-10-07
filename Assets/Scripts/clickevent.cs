using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickevent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void KillUnit()
    {
        Destroy(gameObject);
    }
}
