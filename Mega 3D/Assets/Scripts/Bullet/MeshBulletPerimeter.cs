using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshBulletPerimeter : MonoBehaviour
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
             // Contorno
            0,1,2, //t1
            1,3,2, //t2
            4,2,5, //t3
            2,6,5, //t4
            7,5,8, //t5
            5,9,8, //t6
            9,10,11, //t7
            10,12,11, //t8
            12,13,14, //t9
            13,15,14, //t10
            17,18,13, //t11
            18,16,13, //t12
            20,21,18, //t13
            21,19,18, //t14
            3,22,23, //t15
            22,20,23, //t16
        };
        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
