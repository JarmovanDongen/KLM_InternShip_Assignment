 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlaneController : MonoBehaviour
{
    private NavMeshAgent _navAgent;
    private Bounds _floor;
    private Vector3 _moveTo;
    // Start is called before the first frame update
    void Start()
    {
        _navAgent = this.GetComponent<NavMeshAgent>();

        _floor = GameObject.Find("GroundPlane").GetComponent<Renderer>().bounds;

        SetRandomDestination();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetRandomDestination()
    {
        float rx = Random.Range(_floor.min.x, _floor.max.x);
        float rz = Random.Range(_floor.min.z, _floor.max.z);
        _moveTo = new Vector3(rx, this.transform.position.y, rz);
        _navAgent.SetDestination(_moveTo);
    }
}
