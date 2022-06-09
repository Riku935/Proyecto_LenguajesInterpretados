using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioLogIn : MonoBehaviour
{
    public GameObject registro;
    public GameObject inicio_sesion;
    public GameObject eleccion;
    public GameObject error;

    public void registroAparece()
    {
        registro.SetActive(true);
        eleccion.SetActive(false);
    }
    public void logInAparece()
    {
        inicio_sesion.SetActive(true);
        eleccion.SetActive(false);
    }
    public void eleccionAparece()
    {
        eleccion.SetActive(true);
        registro.SetActive(false);
        inicio_sesion.SetActive(false);
    }
    public void LogIn()
    {
        if (GameManager.obj.LogUser == "usuario" && GameManager.obj.LogPass == "contraseña")
        {
            SceneManager.LoadScene("Player");
        }
        else
        {
            SceneManager.LoadScene("Splash");
            error.SetActive(true);
        }
    }
    public void Register()
    {

    }
}
