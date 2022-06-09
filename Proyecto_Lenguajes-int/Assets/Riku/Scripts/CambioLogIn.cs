using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioLogIn : MonoBehaviour
{
    public GameObject registro;
    public GameObject inicio_sesion;
    public GameObject eleccion;

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
}
