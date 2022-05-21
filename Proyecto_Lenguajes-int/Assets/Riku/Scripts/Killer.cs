using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Game.obj.gameOver();      Se comunica con el GameManager para reiniciar la escena pero lo tengo que consultar contigo Juan 
        }
    }
}
