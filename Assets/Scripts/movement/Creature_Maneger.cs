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

    public bool isMale;
    private float foodDecrease;
    private float hunger;
    private float health;
    public float speed;

    private bool isDead;

}
