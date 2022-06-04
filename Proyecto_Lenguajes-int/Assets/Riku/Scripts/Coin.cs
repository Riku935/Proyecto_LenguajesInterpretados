using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
//[SerializeField] private GameObject efecto;
[SerializeField] private float cantidadPuntos;
[SerializeField] private puntaje puntaje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            /*
              Destroy(gameObject);
            GameManager.obj.addScore(scoreGive);     
            AudioManager.obj.playCoin();
            //UIManager.obj.updateScore();
            FXManager.obj.showPop(transform.position);
            gameObject.SetActive(false);
            */
           puntaje.SumarPuntos(cantidadPuntos);
         //  Instantiate(efecto, transform.position, Quaternion.identity);
           Destroy (gameObject);
            
        }
       
    }
}
