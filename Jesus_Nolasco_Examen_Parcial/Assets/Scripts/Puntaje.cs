using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
  public int score;
  public TextMeshProUGUI scoreText;

  private void Start() 
    {
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Manzana")
        {
            score ++;
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);
        }
    }
}
