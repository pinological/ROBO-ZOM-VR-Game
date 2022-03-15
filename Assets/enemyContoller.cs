using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyContoller : MonoBehaviour
{
    public GameObject destroy;

    private NavMeshAgent navMeshAgent;
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 locationPlay = FindObjectOfType<playerInfo>().playerlocation();
        navMeshAgent.destination = locationPlay;
        Debug.Log(locationPlay);
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Touch enemy");

            Instantiate(destroy, transform.position, transform.rotation);

            Destroy(gameObject);

        }

        if(other.gameObject.tag == "finish")
        {
            Destroy(gameObject);
        }
    }
}
