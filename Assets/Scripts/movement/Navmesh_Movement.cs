//this script should be attached to the parent transform
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh_Movement : MonoBehaviour
{

    private Creature_Maneger creature_Maneger;

    private NavMeshAgent agent;

    private Vector3 target;
    private float border;

    private float speed;
    private bool isMale;

    void Awake()
    {
        creature_Maneger = transform.parent.GetComponent<Creature_Maneger>();
        isMale = creature_Maneger.isMale;
        speed = creature_Maneger.speed;
        border = creature_Maneger.border;
    }



}
