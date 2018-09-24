using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerFallen : MonoBehaviour {

    public GameObject player;

    private void Update()
    {
        if (player.transform.position.y <= 0)
        {
            player.transform.position = new Vector3(Random.Range(-20f, 20f), 1.1f, Random.Range(-20f, 20f));
        }
    }

}
