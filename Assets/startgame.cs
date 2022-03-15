using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class startgame : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }

    private void Start()
    {
        scoreText.text = "Score : " + PlayerPrefs.GetInt("score").ToString();
    }

}
