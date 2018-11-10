using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	void Update ()
    {
        if (Input.touchCount > 0)
        {
            transform.position = Vector3.Lerp(transform.position, Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 10)), Time.deltaTime * 10);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit");
        if (other.gameObject.tag != "Player")
        {
            Debug.Log("dead");
        }
    }

}
