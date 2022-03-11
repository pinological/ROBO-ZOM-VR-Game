using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cleanerFun());
    }

    IEnumerator cleanerFun()
    {
        
        FindObjectOfType<score>().CountAdder();
        FindObjectOfType<healthCountUpdate>().UpdateKillText();
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }
}
