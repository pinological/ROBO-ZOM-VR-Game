using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthCountUpdate : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    
    public TextMeshProUGUI numkill;

    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI.text = "Health : " + FindObjectOfType<playerInfo>().getHealth();
        numkill.text = "Score : " + FindObjectOfType<score>().getScore().ToString();
    }

    // Update is called once per frame
    public void UpdateHealthText()
    {
        textMeshProUGUI.text = "Health : " + FindObjectOfType<playerInfo>().getHealth().ToString();
    }

    public void UpdateKillText()
    {
        numkill.text = "Score : "+FindObjectOfType<score>().getScore().ToString();
    }
}
