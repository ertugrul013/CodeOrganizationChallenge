using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrianGenerator : MonoBehaviour
{
    [SerializeField] private Mesh mesh;
    [SerializeField] private Vector3[] vertices;
    float detailScale = 25;
    float heighoffset = 20;
    float heightscale = 20;

    // void Update()
    // {
    //     mesh = GetComponent<MeshFilter>().sharedMesh;
    //     vertices = mesh.vertices;
    //     int i = 0;
    //     while (i < vertices.Length)
    //     {
    //         vertices[i] += Vector3.up * Time.deltaTime;
    //         i++;
    //     }
    //     mesh.vertices = vertices;
    //     mesh.RecalculateBounds();
    // }

    void Start()
    {
        mesh = GetComponent<MeshFilter>().sharedMesh;
        vertices = mesh.vertices;
        float seed = (float)Network.time * 10;
        int i = 0;
        while (i < vertices.Length)
        {
            for (int z = 0; z < 20; z++)
            {
                for (int x = 0; x < vertices.Length; x++)
                {
                    float y = (float)(Mathf.PerlinNoise((x + seed) / detailScale, (z + seed) / detailScale) * heightscale) + heighoffset;
                    vertices[i] = new Vector3(x, y, vertices[i].z + z);
                    Debug.Log(z);
                }
            }
            mesh.vertices = vertices;
            mesh.RecalculateBounds();
        }
    }

}
