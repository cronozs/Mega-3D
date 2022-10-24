using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshPerimeter : MonoBehaviour
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
            new Vector3 (0,1,0), //1
            new Vector3 (9,0,0), //2
            new Vector3 (9,1,0), //3
            new Vector3 (0,0,0), //4
            new Vector3 (0,2,0), //5
            new Vector3 (1,1,0), //6
            new Vector3 (1,2,0), //7
            new Vector3 (8,1,0), //8
            new Vector3 (8,3,0), //9
            new Vector3 (9,3,0), //10
            new Vector3 (1,3,0), //11
            new Vector3 (3,2,0), //12
            new Vector3 (3,3,0), //13
            new Vector3 (3,4,0), //14
            new Vector3 (4,4,0), //15
            new Vector3 (4,5,0), //16
            new Vector3 (5,5,0), //17
            new Vector3 (5,4,0), //18
            new Vector3 (5,3,0), //19
            new Vector3 (5,6,0), //20
            new Vector3 (6,5,0), //21
            new Vector3 (6,6,0), //22
            new Vector3 (9,4,0), //23
            new Vector3 (10,3,0), //24
            new Vector3 (10,4,0), //25
            new Vector3 (8,2,0), //26
            new Vector3 (10,5,0), //27
            new Vector3 (11,4,0), //28
            new Vector3 (11,5,0), //29
            new Vector3 (8,4,0), //30
            new Vector3 (7,5,0), //31
            new Vector3 (7,4,0), //32
            new Vector3 (8,5,0), //33
            new Vector3 (8,6,0), //34

            //Pierna derecha
            new Vector3 (11,3,0), //35
            new Vector3 (12,4,0), //36
            new Vector3 (12,3,0), //37
            new Vector3 (12,1,0), //38
            new Vector3 (13,3,0), //39
            new Vector3 (13,1,0), //40
            new Vector3 (12,0,0), //41
            new Vector3 (21,1,0), //42
            new Vector3 (21,0,0), //43
            new Vector3 (20,1,0), //44
            new Vector3 (20,2,0), //45
            new Vector3 (21,2,0), //46
            new Vector3 (20,3,0), //47
            new Vector3 (18,2,0), //48
            new Vector3 (18,3,0), //49
            new Vector3 (18,4,0), //50
            new Vector3 (16,3,0), //51
            new Vector3 (16,4,0), //52
            new Vector3 (16,5,0), //53
            new Vector3 (17,4,0), //54
            new Vector3 (17,5,0), //55
            new Vector3 (15,5,0), //56
            new Vector3 (15,6,0), //57
            new Vector3 (16,6,0), //58
            new Vector3 (13,2,0), //59
            new Vector3 (13,4,0), //60
            new Vector3 (15,4,0), //61
            new Vector3 (12,5,0), //62
            new Vector3 (12,6,0), //63

            //Brazo derecho
            new Vector3 (14,6,0), //64
            new Vector3 (14,7,0), //65
            new Vector3 (15,7,0), //66
            new Vector3 (14,10,0), //67
            new Vector3 (16,10,0), //68
            new Vector3 (16,7,0), //69
            new Vector3 (14,11,0), //70
            new Vector3 (15,11,0), //71
            new Vector3 (15,10,0), //72
            new Vector3 (16,9,0), //73
            new Vector3 (17,9,0), //74
            new Vector3 (17,10,0), //75
            new Vector3 (16,7,0), //76
            new Vector3 (19,6,0), //77
            new Vector3 (19,7,0), //78
            new Vector3 (20,7,0), //79
            new Vector3 (19,11,0), //80
            new Vector3 (20,11,0), //81
            new Vector3 (19,13,0), //82
            new Vector3 (18,13,0), //83
            new Vector3 (18,11,0), //84
            new Vector3 (18,14,0), //85
            new Vector3 (15,13,0), //86
            new Vector3 (15,14,0), //87
            new Vector3 (15,12,0), //88
            new Vector3 (14,12,0), //89
            new Vector3 (14,13,0), //90
            new Vector3 (19,9,0), //91
            new Vector3 (17,11,0), //92
            new Vector3 (16,11,0), //93
            new Vector3 (16,12,0), //94
            new Vector3 (18,12,0), //95
            new Vector3 (17,12,0), //96
            new Vector3 (17,13,0), //97


            //Brazo Izquierdo
            new Vector3 (6,7,0), //98
            new Vector3 (7,7,0), //99
            new Vector3 (7,6,0), //100
            new Vector3 (5,7,0), //101
            new Vector3 (5,10,0), //102
            new Vector3 (7,10,0), //103
            new Vector3 (6,10,0), //104
            new Vector3 (6,11,0), //105
            new Vector3 (7,11,0), //106
            new Vector3 (5,9,0), //107
            new Vector3 (4,9,0), //108
            new Vector3 (4,10,0), //109
            new Vector3 (2,6,0), //110
            new Vector3 (2,7,0), //111
            new Vector3 (1,7,0), //112
            new Vector3 (1,11,0), //113
            new Vector3 (2,11,0), //114
            new Vector3 (2,13,0), //115
            new Vector3 (3,13,0), //116
            new Vector3 (3,11,0), //117
            new Vector3 (3,14,0), //118
            new Vector3 (5,14,0), //119
            new Vector3 (5,13,0), //120

        };

        mesh.vertices = vertices;

        triangles = new int[]
        {
             // pierna izquierda
            0,1,2, //t1
            1,3,2, //t2
            1,5,6, //t3
            5,7,6, //t4
            8,9,3, //t5
            9,10,3, //t6
            7,11,12, //t7
            11,13,12, //t8
            13,14,19, //t9
            14,18,19, //t10
            15,16,18, //t11
            16,17,18, //t12
            17,20,21, //t13
            20,22,21, //t14
            10,23,24, //t15
            23,25,24, //t16
            25,27,28, //t17

            // Pierna derecha
            27,29,28, //t18
            35,28,37, //t19
            28,36,37, //t20
            38,37,40, //t21
            37,39,40, //t22
            41,38,43, //t23
            38,42,43, //t24
            44,45,42, //t25
            45,46,42, //t26
            48,49,45, //t27
            49,47,45, //t28
            51,52,49, //t29
            52,50,49, //t30
            52,53,54, //t31
            53,55,54, //t32
            56,57,53, //t33
            57,58,53, //t34

            //Brazo derecho
            64,65,57, //t35
            65,66,57, //t36
            65,67,69, //t37
            67,68,69, //t38
            67,70,72, //t39
            70,71,72, //t40
            73,68,74, //t41
            68,75,74, //t42
            58,76,77, //t43
            76,78,77, //t44
            78,80,79, //t45
            80,81,79, //t46
            84,83,80, //t47
            83,82,80, //t48
            86,87,83, //t49
            87,85,83, //t50
            89,90,88, //t51
            90,86,88, //t52

            //Brazo Derecho
            22,98,100, //t53
            98,99,100, //t54
            101,102,99, //t55
            102,103,99, //t56
            104,105,103, //t57
            105,106,103, //t58
            108,109,107, //t59
            109,102,107, //t60
            110,111,20, //t61
            111,101,20, //t62
            112,113,111, //t63
            113,114,111, //t64
            114,115,117, //t65
            115,116,117, //t66
            116,118,120, //t67
            118,119,120, //t68

        };

        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
