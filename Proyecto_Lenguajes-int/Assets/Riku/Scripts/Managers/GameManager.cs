using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class GameManager : MonoBehaviour
{
    public static GameManager obj;
    public GameObject winText;
    public int maxLives = 3;
    public bool gamePaused = false;
    public bool gameWin = false;
    public int score = 0;
    public string nombre;
    public string RegisterUser;
    public string RegisterPass;
    public string LogUser;
    public string LogPass;
    
    [DllImport("__Internal")]
    private static extern string Usuario(string user, string pass);
    [DllImport("__Internal")]
    private static extern string UsuarioLogin(string userLog, string passLog);

    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        gamePaused = false;
        
    }

    public void sendToPHP()
    {
        Usuario(RegisterUser, RegisterPass);
    }
    public void sendToPHPLogin()
    {
        UsuarioLogin(LogUser, LogPass);
    }

    public void Login()
    {
        if (LogUser == "usuario" && LogPass == "contraseña")
        {
            SceneManager.LoadScene("Player");
        }
        else
        {
            SceneManager.LoadScene("Splash");
        }
    }

    public void addScore(int scoreGive)
    {
        score += scoreGive;
    }

    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void win()
    {
        winText.SetActive(true);
        //Usuario();
    }

    public void addText(string nombreGive)
    {
        nombre = nombreGive;
    }

    public void addRegUser(string userReg)
    {
        RegisterUser = userReg;
    }
    public void addRegPass(string PassReg)
    {
        RegisterPass = PassReg;
    }
    public void addLogUser(string userLog)
    {
        LogUser = userLog;
    }
    public void addLogPass(string PassLog)
    {
        LogPass = PassLog;
    }

    private void OnDestroy()
    {
        obj = null;
    }
}
