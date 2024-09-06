using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    public int TotalScore;
    public Text scoreText;

    public GameObject gameOver;

    public static GameController instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText()
    {
        scoreText.text = TotalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);

    }

    public void RestartGame(string lvlMane)
    {
        SceneManager.LoadScene(lvlMane);

    }
}
