
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform t;
    public Vector3 dist, edist, qdist;

    void Update()
    {
        transform.position = t.position + dist;
        if (Input.GetKeyDown(KeyCode.E))
        {
            UnityEngine.Debug.Log("Right");
            dist = edist;
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UnityEngine.Debug.Log("Left");
            dist = qdist;
            transform.eulerAngles = new Vector3(0, -90, 0);
        }
    }
}
