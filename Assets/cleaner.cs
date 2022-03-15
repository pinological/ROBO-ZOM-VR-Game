using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cleanerBody());
    }

    IEnumerator cleanerBody()
    {
        FindObjectOfType<score>().CountAdder();
        FindObjectOfType<healthCountUpdate>().UpdateKillText();
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
