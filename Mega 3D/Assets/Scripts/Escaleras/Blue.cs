using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    MeshFilter meshFilter;
    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;

    int[] triangles;

    public Material material;
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;


        vertices = new Vector3[]
        {
            // pierna izquierda 
            new Vector3 (0,0,0), //0
            new Vector3 (0,8,0), //1
            new Vector3 (23,0,0), //2
            new Vector3 (23,8,0), //3
            new Vector3 (2,0,0), //4
            new Vector3 (2,8,0), //5
            new Vector3 (21,0,0), //6
            new Vector3 (21,8,0), //7
            new Vector3 (2,2,-0.12f), //8
            new Vector3 (2,3,-0.12f), //9
            new Vector3 (21,2,-0.12f), //10
            new Vector3 (21,3,-0.12f), //11
            new Vector3 (2,3,0), //12
            new Vector3 (2,4,0), //13
            new Vector3 (21,3,0), //14
            new Vector3 (21,4,0), //15

        };

        mesh.vertices = vertices;

        triangles = new int[]
        {
           12,13,14, //t1
           13,15,14, //t2
        };
        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
