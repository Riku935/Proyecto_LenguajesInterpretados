using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager obj;
    public GameObject winText;
    public int maxLives = 3;
    public bool gamePaused = false;
    public bool gameWin = false;
    public int score = 0;
    public string nombre;

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

    public void addText(string nombreGive)
    {
        nombre = nombreGive;
    }

    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void win()
    {
        winText.SetActive(true);
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
