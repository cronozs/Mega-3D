using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
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
           new Vector3 (0,0,0), //0
           new Vector3 (0,20,0), //1
           new Vector3 (20,0,0), //2
           new Vector3 (20,20,0), //3
           new Vector3 (20,0,20), //4
           new Vector3 (20,20,20), //5
           new Vector3 (0,0,20), //6
           new Vector3 (0,20,20), //7
        };

        mesh.vertices = vertices;

        triangles = new int[]
        {
            0,1,2, //t1
            1,3,2, //t2
            2,3,4, //t3
            3,5,4, //t4
            4,5,6, //t5
            5,7,6, //t6
            6,7,0, //t7
            7,1,0, //t8
            1,7,3, //t8
            7,5,3, //t8
            6,0,4, //t8
            0,2,4, //t8
        };
        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
