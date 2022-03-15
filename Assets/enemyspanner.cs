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

        if(FindObjectOfType<score>().getScore() < 10) { 

        if (GameObject.FindGameObjectsWithTag("zom").Length < 2)
        {
            Instantiate(prefab, new Vector3(Random.Range(player.transform.position.x + 10, player.transform.position.x - 10), 1f, Random.Range(player.transform.position.z + 10, player.transform.position.z - 10)), Quaternion.identity);
        }
            FindObjectOfType<score>().phaseUpdate("warm up");
        }
       else if (FindObjectOfType<score>().getScore() >= 10 && FindObjectOfType<score>().getScore() < 40)
        {

            if (GameObject.FindGameObjectsWithTag("zom").Length < 4)
            {
                Instantiate(prefab, new Vector3(Random.Range(player.transform.position.x + 10, player.transform.position.x - 10), 1f, Random.Range(player.transform.position.z + 10, player.transform.position.z - 10)), Quaternion.identity);
            }
            FindObjectOfType<score>().phaseUpdate("Heated");
        }

        else
        {
            if (GameObject.FindGameObjectsWithTag("zom").Length < 6)
            {
                Instantiate(prefab, new Vector3(Random.Range(player.transform.position.x + 10, player.transform.position.x - 10), 1f, Random.Range(player.transform.position.z + 10, player.transform.position.z - 10)), Quaternion.identity);
            }
            FindObjectOfType<score>().phaseUpdate("Zom Mode");
        }


        yield return new WaitForSeconds(3f);
        
        StartCoroutine(spanner());

    }


    
}
