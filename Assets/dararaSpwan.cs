using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dararaSpwan : MonoBehaviour
{
    public GameObject spwan;

    public void SpwanDha()
    {
        Debug.Log("Interaction Spwaner");
        Instantiate(spwan, new Vector3(Random.Range(transform.position.x + 5, transform.position.x - 5), 1f, Random.Range(transform.position.z + 5, transform.position.z - 5)), Quaternion.identity);
    }
}
