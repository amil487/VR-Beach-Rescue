using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker : MonoBehaviour {


    bool mover = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.rotation.x == 0)
        {
            mover = true;
        }

        if (transform.rotation.z > 50 || transform.rotation.x > 50 || transform.rotation.y > 50)
        {
            mover = false;
        }

        if(mover)
        {
            transform.Translate(0, .01f, .01f);
           // transform.Translate(0, Time.deltaTime, 0, Space.World);
        }
            

    }
}
