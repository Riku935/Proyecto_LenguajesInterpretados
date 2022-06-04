using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
 private float puntos;
 private TextMeshProUGUI texMesh;
private void Start()
{
    texMesh = GetComponent<TextMeshProUGUI>();
}
private void Update() {
  
    texMesh.text = puntos.ToString("0");
}
public void SumarPuntos(float puntosEntrada)
{
    puntos += puntosEntrada;
}

}
