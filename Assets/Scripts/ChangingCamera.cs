using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCamera : MonoBehaviour {
    public GameObject MainCamera;
    public GameObject TopCamera;
    int count = 0;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M) && count%2 == 0)
        {
            count++;
            MainCamera.SetActive(false);
            TopCamera.SetActive(true);
        }else if (Input.GetKeyDown(KeyCode.M) && count % 2 != 0)
        {
            count++;
            MainCamera.SetActive(true);
            TopCamera.SetActive(false);
        }
	}
}
