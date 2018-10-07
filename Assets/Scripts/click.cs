using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour {
    public Text counter;
    int c = 0;
    public GameObject special;
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

            c++;
            counter.text = "Clicks: " + c.ToString();

            if (Physics.Raycast(ray, out hit))
            {
                MeshCollider collision = hit.collider as MeshCollider;
                if (collision != null && collision.gameObject.tag == "trash")
                    Destroy(collision.gameObject);

                if (collision != null && collision.gameObject.tag == "turtle")
                    collision.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);

                if (collision != null && collision.gameObject.tag == "special")
                    special.SetActive(true);
            }
        }
	}
}
