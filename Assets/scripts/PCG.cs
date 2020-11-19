using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCG : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        MakeMesh();
    }

    private void MakeMesh()
    {
        vertices = new Vector3[] {
           new Vector3(0,0,0),
           new Vector3(1,0,0),
           new Vector3(0,0,1),
           new Vector3(1,0,1)
       };
        triangles = new int[] {0,2,1,1,2,3};
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
