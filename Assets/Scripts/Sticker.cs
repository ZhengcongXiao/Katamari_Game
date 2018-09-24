using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sticker : MonoBehaviour {
    public GameObject ball;
    Vector3 temp;
    public AudioClip clip;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "stuff")
        {
            temp = transform.localScale;
            
            AudioSource.PlayClipAtPoint(clip, transform.position, 10.0f);
            hit.gameObject.transform.parent = ball.transform;
            hit.gameObject.GetComponent<Collider>().enabled = false;
            hit.gameObject.GetComponent<Rigidbody>().Sleep();

            temp.x -= 0.1f;
            temp.y -= 0.1f;
            temp.z -= 0.1f;
            transform.localScale = temp;


            Score.currentScore -= 1;
        }

        if (hit.gameObject.tag == "robot")
        {
            temp = transform.localScale;

            AudioSource.PlayClipAtPoint(clip, transform.position, 10.0f);
            hit.gameObject.transform.parent = ball.transform;
            hit.gameObject.GetComponent<Collider>().enabled = false;
            hit.gameObject.GetComponent<Rigidbody>().Sleep();

            temp.x += 0.15f;
            temp.y += 0.15f;
            temp.z += 0.15f;
            transform.localScale = temp;


            Score.currentScore += 1;
        }

    }
}
