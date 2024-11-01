using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeathOnCollision : MonoBehaviour 
{
   [SerializeField] GameObject gameOverScreen;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Death();
    }

    private void Death()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }
}

