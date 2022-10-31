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

            //Torso
            new Vector3 (7,8,0), //121
            new Vector3 (14,8,0), //122

            //brazo izquierdo color
            new Vector3 (2,9,0), //123
            new Vector3 (4,11,0), //124
            new Vector3 (5,11,0), //125
            new Vector3 (5,12,0), //126
            new Vector3 (3,12,0), //127
            new Vector3 (4,12,0), //128
            new Vector3 (4,13,0), //129

            //cabezaza
            new Vector3 (9,11,0), //130
            new Vector3 (9,12,0), //131
            new Vector3 (8,12,0), //132
            new Vector3 (8,13,0), //133
            new Vector3 (9,13,0), //134
            new Vector3 (7,13,0), //135
            new Vector3 (7,14,0), //136
            new Vector3 (8,14,0), //137
            new Vector3 (7,15,0), //138
            new Vector3 (5,15,0), //139
            new Vector3 (6,15,0), //140
            new Vector3 (6,16,0), //141
            new Vector3 (7,16,0), //142
            new Vector3 (5,16,0), //143
            new Vector3 (5,19,0), //144
            new Vector3 (6,19,0), //145
            new Vector3 (6,21,0), //146
            new Vector3 (7,19,0), //147
            new Vector3 (7,21,0), //148
            new Vector3 (7,22,0), //149
            new Vector3 (8,21,0), //150
            new Vector3 (8,22,0), //151
            new Vector3 (8,23,0), //152
            new Vector3 (11,22,0), //153
            new Vector3 (11,23,0), //154
            new Vector3 (10,23,0), //155
            new Vector3 (10,24,0), //156
            new Vector3 (13,23,0), //157
            new Vector3 (13,24,0), //158
            new Vector3 (13,22,0), //159
            new Vector3 (14,22,0), //160
            new Vector3 (14,23,0), //161
            new Vector3 (14,21,0), //162
            new Vector3 (15,21,0), //163
            new Vector3 (15,22,0), //164
            new Vector3 (11,21,0), //165
            new Vector3 (12,21,0), //166
            new Vector3 (12,22,0), //167
            new Vector3 (12,20,0), //168
            new Vector3 (16,20,0), //169
            new Vector3 (16,21,0), //170
            new Vector3 (12,19,0), //171
            new Vector3 (13,19,0), //172
            new Vector3 (13,20,0), //173
            new Vector3 (13,18,0), //174
            new Vector3 (15,18,0), //175
            new Vector3 (15,19,0), //176
            new Vector3 (16,14,0), //177
            new Vector3 (17,14,0), //178
            new Vector3 (17,20,0), //179
            new Vector3 (15,20,0), //180
            new Vector3 (7,18,0),  //181
            new Vector3 (12,18,0), //182
            new Vector3 (7,17,0), //183
            new Vector3 (9,17,0), //184
            new Vector3 (9,18,0), //185
            new Vector3 (8,17,0), //186
            new Vector3 (9,14,0), //187
            new Vector3 (16,18,0), //188
            new Vector3 (15,17,0), //189
            new Vector3 (13,17,0), //190

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

            //Cabeza
            130,131,70, //t69
            131,89,70,  //t70
            132,133,131, //t71
            133,134,131, //t72
            135,136,133, //t73
            136,137,133, //t74
            119,139,136, //t75
            139,138,136, //t76
            140,141,138, //t77
            141,142,138, //t78
            143,144,141, //t79
            144,145,141, //t80
            145,146,147, //t81
            146,148,147, //t82
            148,149,150, //t83
            149,151,150, //t84
            151,152,153, //t85
            152,154,153, //t86
            155,156,157, //t87
            156,158,157, //t88
            159,157,160, //t89
            157,161,160, //t90
            162,160,163, //t91
            160,164,163, //t92
            165,153,166, //t93
            153,167,166, //t94
            168,166,169, //t95
            166,170,169, //t96
            171,168,172, //t97
            168,173,172, //t98
            174,172,175, //t99
            172,176,175, //t100
            177,169,178, //t101
            169,179,178, //t102

        };

        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
