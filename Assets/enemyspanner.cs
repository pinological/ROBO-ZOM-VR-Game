using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspanner : MonoBehaviour
{
    public Transform prefab;
    public GameObject player;
    void Start()
    {
        StartCoroutine(spanner());
    }

    IEnumerator spanner() {

        if (GameObject.FindGameObjectsWithTag("zom").Length < 2)
        {
            Debug.Log("i am working");
            Instantiate(prefab, new Vector3(Random.Range(player.transform.position.x + 9, player.transform.position.x - 9), 0, Random.Range(player.transform.position.z + 9, player.transform.position.z - 9)), Quaternion.identity);
        }
        yield return new WaitForSeconds(1f);
        
        StartCoroutine(spanner());

    }


    
}
