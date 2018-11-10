using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	
	void Update ()
    {
        if (transform.position.y < -4.5f)
        {
           Destroy(gameObject);
        }
	}
}
