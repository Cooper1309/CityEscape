using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    
    public GameObject platformGenerator;
 

    public GameObject GameOverScreen;
    public Text gameOverScoreText;
   

    void Start()
    {
      

        GameOverScreen.SetActive(false);
    }
    public void gameOver()
    {
       

        GameOverScreen.SetActive(true);
        //gameOverScoreText.text = Pickups.score.ToString();
    }
}
