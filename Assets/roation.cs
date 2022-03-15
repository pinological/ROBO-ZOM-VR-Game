using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roation : MonoBehaviour
{
    public float rotationspeed = 2f;

    public GameObject mainbody;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(mainbody.transform.position, new Vector3(0, 1, 0), Time.deltaTime*rotationspeed);
    }
}
