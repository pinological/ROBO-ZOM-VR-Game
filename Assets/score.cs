using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreCount, phase;
    public int num = 0;

    private void Start()
    {
        scoreCount.text = "Score : "+num;
    }


    public void CountAdder()
    {
        Debug.Log(scoreCount.text);
        num++;
        scoreCount.text = "Score : " + num;
        PlayerPrefs.SetInt("score", num);

    }

    public int getScore()
    {
        return num;
    }

    public void phaseUpdate(string phaseStr)
    {
        phase.text = "Phase : "+phaseStr;
    }

}
