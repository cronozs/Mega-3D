using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    MeshFilter meshFilter;
    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;

    int[] triangles;

    public Material material;
    // Start is called before the first frame update
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

        };

        mesh.vertices = vertices;

        triangles = new int[]
        {
           4,5,6, //t1
           5,7,6    , //t2
        };
        mesh.triangles = triangles;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
