using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeading: MonoBehaviour {
    public float rotationRate = 20.0f;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * rotationRate * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationRate * Time.deltaTime);
        }
    }
}
