using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreGive = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Game.obj.addScore(scoreGive);    Se comunica con el GameManager para reiniciar la escena pero lo tengo que consultar contigo Juan 
            AudioManager.obj.playCoin();
            //UIManager.obj.updateScore();
            FXManager.obj.showPop(transform.position);
            gameObject.SetActive(false);
        }
       
    }
}
