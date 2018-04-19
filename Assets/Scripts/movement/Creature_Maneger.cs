//this script should be attached to the parent transform
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(NavMeshAgent))]

public class Creature_Maneger : MonoBehaviour
{
    //scripts/ classes needed  acces
    private DNA myDna;

    private Material[] GenderMat = new Material[2];
    public GameObject[] bodyTypes;

    public bool isMale;
    public float foodDecrease;
    public float hunger;
    public float health;
    public float speed;

    public bool isDead;
    public float border;

    void Awake()
    {
        border = GameObject.Find("World").GetComponent<World_Maneger>().ReturnBorder();

    }
}
