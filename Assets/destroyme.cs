using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyme : MonoBehaviour
{
    public GameObject destroy;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Touch enemy");
            
            Instantiate(destroy, transform.position, transform.rotation);
            Destroy(gameObject);

        }
    }
}
