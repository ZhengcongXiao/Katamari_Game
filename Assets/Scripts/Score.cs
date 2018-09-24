using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int currentScore;
    int internalScore;
    public GameObject scoreText;
	// Update is called once per frame
	void Update () {
        internalScore = currentScore;
        scoreText.GetComponent<Text>().text = "" + internalScore;
	}
}
