﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class World_Maneger : MonoBehaviour
{
    [Header("World Settings")]
    private NavMeshSurface surface;
    private Transform World_Scale;
    [Range(5, 50)] public int WorldSize;

    [Space]
    [Header("Creatur Settings")]
    [SerializeField]
    private GameObject Creatur;
    [Tooltip("how big would should the simulation area be")] [Range(20, 80)] [SerializeField] private int AmountOfCreaturs;

    [Space]
    [Header("Spawnable Objects")]
    public GameObject Food;
    [SerializeField] [Range(5, 40)] private int FoodScale;

    [Space]
    public GameObject Plants;
    [SerializeField] [Range(20, 50)] private int PlantsScale;

    private float borderpos;
    // Use this for initialization
    void Start()
    {
        surface = GetComponent<NavMeshSurface>();
        World_Scale = this.gameObject.transform;
        World_Scale.localScale = new Vector3(WorldSize, WorldSize, WorldSize);
        borderpos = ReturnBorder();

        ObjectSpawn();
        InitSpawn();
        /*the line below should be alwsays on the bottom of the start function
		* the reason for this is. other ways the navmesh would be build without any of the trees of bushes
		* taking into the navmeshs
		*/
        surface.BuildNavMesh();
    }

    //he will spawn all the objects that are not a creature
    //for example foor trees rocks
    void ObjectSpawn()
    {
        for (int i = 0; i < 5 * PlantsScale; i++)
        {
            Instantiate(Plants, new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)), Quaternion.identity);
        }
        for (int i = 0; i < 5 * FoodScale; i++)
        {
            Instantiate(Food, new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)), Quaternion.identity);
        }

    }

    //will calculate the world borders but only if the world object is a plane
    public float ReturnBorder()
    {
        return (WorldSize * 5);
    }

    //this function spawns the creatures in a vertical way brings them down and after comming down the creaturs will move to a random lacation
    void InitSpawn()
    {
        for (int x = 0; x < AmountOfCreaturs; x++)
        {
            Vector3 posx = new Vector3(x, 0, 0.5f);
            Instantiate(Creatur, posx, Quaternion.identity);
        }
    }

    //this will only spawn an object once 
    public void SpawnObject()
    {
        Instantiate(Plants, new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)), Quaternion.identity);
    }
}
