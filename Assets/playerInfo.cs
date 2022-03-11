using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInfo : MonoBehaviour
{
    public int playerhealth = 10;
    public Vector3 playerlocation()
    {
        return new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "zom")
        {
            playerhealth--;
            if (playerhealth < 0)
            {
                SceneManager.LoadScene(2);
            }
            

            FindObjectOfType<healthCountUpdate>().UpdateHealthText();
            
            
        }
    }

    public int getHealth()
    {
        return playerhealth;
    }
}
