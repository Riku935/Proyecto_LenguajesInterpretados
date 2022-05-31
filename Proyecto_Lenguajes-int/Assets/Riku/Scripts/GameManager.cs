using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager obj;
    public int maxLives = 3;
    public bool gamePaused = false;
    public int score = 0;

    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        gamePaused = false;
        //UIManager.obj.startGame();
    }

    public void addScore(int scoreGive)
    {
        score += scoreGive;
    }
    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
