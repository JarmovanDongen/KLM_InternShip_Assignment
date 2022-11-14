using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public PlaneScriptableObject planeSO;
    public NavMeshAgent agent;
    [Range(0, 100)] public float speed;
    [Range(1, 500)] public float flyRadius;

    private bool isParking = false;

    private Transform hangar;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        agent.GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = speed;
            agent.SetDestination(RandomNavMeshLocation());
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Fly around in random direction
        if (agent != null && agent.remainingDistance <= agent.stoppingDistance && !isParking)
        {
            agent.SetDestination(RandomNavMeshLocation());
        }

    }

    //Calculate where to fly
    public Vector3 RandomNavMeshLocation()
    {
        Vector3 finalPosition = Vector3.zero;
        Vector3 randomPosition = Random.insideUnitSphere * flyRadius;
        randomPosition += transform.position;
        if (NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, flyRadius, 1))
        {
            finalPosition = hit.position;
        }
        Debug.Log(finalPosition);
        return finalPosition;
    }

    //Set the destination for agent to go to hangar
    public void GoToHangar()
    {
        agent.SetDestination(hangar.position);
        isParking = true;
    }

    //Set correct hangar
    public void SetHangar(Transform hangar)
    {
        this.hangar = hangar;
    }

    //Turn Lights on
    public void TurnLightsOn()
    {
        light.SetActive(true);
    }


}
