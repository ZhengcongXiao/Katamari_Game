using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour {
    public GameObject minions;
    public GameObject robots;
    public int totalMinions = 20;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < totalMinions; i++)
        {
            Vector3 position = new Vector3(Random.Range(-25, 25), 0.5f, Random.Range(-25, 25));
            Quaternion face = Quaternion.Euler(0,Random.Range(0.0f,360.0f),0);
            Instantiate(minions,position,face);
            Vector3 position1 = new Vector3(Random.Range(-25, 25), 0, Random.Range(-25, 25));
            Quaternion ro = Quaternion.Euler(0, Random.Range(0.0f, 360.0f), 0);
            Instantiate(robots, position1, ro);
        }
	}
	
}
