using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshOscuro : MonoBehaviour
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
            new Vector3 (10,17,0), //191
            new Vector3 (10,18,0), //192
            new Vector3 (10,14,0), //193
            new Vector3 (10,13,0), //194
            new Vector3 (14,14,0), //195
            new Vector3 (13,14,0), //196
            new Vector3 (13,15,0), //197
            new Vector3 (16,15,0), //198
            new Vector3 (14,15,0), //199
            new Vector3 (14,17,0), //200
            new Vector3 (9,15,0), //201
            new Vector3 (11,15,0), //202
            new Vector3 (11,17,0), //203
            new Vector3 (15,15,0), //204

        };

        mesh.vertices = vertices;

        triangles = new int[]
        {
             // pierna izquierda
            6,7,8, //t1
            7,26,8, //t2
            12,13,26, //t3
            13,9,26, //t4
            19,18,9, //t5
            18,30,9, //t6
            18,17,32, //t7
            17,31,32, //t8

            //pierna derecha
            40,59,44, //t9
            59,45,44, //t10
            59,39,48, //t11
            39,49,48, //t12
            39,60,51, //t13
            60,52,51, //t14
            61,56,52, //t15
            56,53,52, //t16

            //complemento piernas
            33,34,62, //t17
            34,63,62, //t18

            //brazo derecho
            69,73,78, //t19
            73,91,78, //t20
            74,92,91, //t21
            92,80,91, //t22
            68,93,75, //t23
            93,92,75, //t24
            93,94,84, //t25
            94,95,84, //t26
            96,97,95, //t27
            97,83,95, //t28

            //torso
            100,121,64, //t29
            121,122,64, //t30

            //brazoo izquierdo
            111,123,101, //t31
            123,107,101, //t32
            123,114,108, //t33
            114,124,108, //t34
            109,124,102, //t35
            124,125,102, //t36
            117,127,125, //t37
            127,126,125, //t38
            127,116,128, //t39
            116,129,128, //t40

            //cabeza
            150,151,165, //t41
            151,153,165, //t42
            181,148,182, //t43
            148,166,182, //t44
            182,171,174, //t45
            171,172,174, //t46
            183,181,184, //t47
            181,185,184, //t48
            136,183,137, //t49
            183,186,137, //t50
            133,137,134, //t51
            137,187,134, //t52
            175,180,188, //t53
            180,169,188, //t54
            190,174,189, //t55
            174,175,189, //t56

        };

        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
