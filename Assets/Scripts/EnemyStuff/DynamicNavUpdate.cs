using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DynamicNavUpdate : MonoBehaviour
{
    public NavMeshPlus.Components.NavMeshSurface Surface2D;

    void Start()
    {
        Surface2D = GetComponent<NavMeshPlus.Components.NavMeshSurface>();
    }
    void Update()
    { 
        Surface2D.UpdateNavMesh(Surface2D.navMeshData);
    }
   
    
}
