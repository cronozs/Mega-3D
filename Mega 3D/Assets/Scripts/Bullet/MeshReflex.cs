using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshReflex : MonoBehaviour
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
            new Vector3 (0,2,0), //0
            new Vector3 (0,4,0), //1
            new Vector3 (1,2,0), //2
            new Vector3 (1,4,0), //3
            new Vector3 (1,1,0), //4
            new Vector3 (2,1,0), //5
            new Vector3 (2,2,0), //6
            new Vector3 (2,0,0), //7
            new Vector3 (6,0,0), //8
            new Vector3 (6,1,0), //9
            new Vector3 (6,2,0), //10
            new Vector3 (7,1,0), //11
            new Vector3 (7,2,0), //12
            new Vector3 (7,4,0), //13
            new Vector3 (8,2,0), //14
            new Vector3 (8,4,0), //15
            new Vector3 (7,5,0), //16
            new Vector3 (6,4,0), //17
            new Vector3 (6,5,0), //18
            new Vector3 (6,6,0), //19
            new Vector3 (2,5,0), //20
            new Vector3 (2,6,0), //21
            new Vector3 (1,5,0), //22
            new Vector3 (2,4,0), //23
            new Vector3 (5,2,0), //24
            new Vector3 (5,4,0), //25
            new Vector3 (4,3,0), //26
            new Vector3 (4,4,0), //27
            new Vector3 (5,3,0), //28
        };

        mesh.vertices = vertices;

        triangles = new int[]
        {
             // Body
            24,25,10, //t1
            25,17,10, //t2
            26,27,28, //t3
            27,25,28, //t4
        };
        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
