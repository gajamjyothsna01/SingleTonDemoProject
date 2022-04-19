using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkTowardsGoal : MonoBehaviour
{
    //Makes our ethene to walk towards the One of the Goal Points
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] goalPoints;
    NavMeshAgent agent;
    Vector3 lastPoint;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        goalPoints = GameObject.FindGameObjectsWithTag("Goal");
        lastPoint = agent.destination;
        GoToLocation();


    }

    // Update is called once per frame
    void Update()
    {
      
        if(agent.remainingDistance < 1.0f)
        {
            GoToLocation();
        }


    }
    private void GoToLocation()
    {
       
        
        agent.SetDestination(goalPoints[Random.Range(0, goalPoints.Length)].transform.position);
    }
}
