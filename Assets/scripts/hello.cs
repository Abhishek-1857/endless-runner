using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hello : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce, mforce, deathheight;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpforce, 0);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0, 0, mforce);
            UnityEngine.Debug.Log("forward");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-mforce, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(0, 0, -mforce);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(mforce, 0, 0);

        }
        /*if (transform.position.y < deathheight)
        {
            SceneManager.LoadScene("1st level");
        }*/

    }
    /*public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            UnityEngine.Debug.Log("Over");
            SceneManager.LoadScene("1st level");
        }
        if (col.gameObject.tag == "Finish")
        {
            UnityEngine.Debug.Log("You Win");
            SceneManager.LoadScene(1);
        }

    }*/
}
