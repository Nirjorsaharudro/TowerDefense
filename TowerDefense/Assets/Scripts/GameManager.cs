using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    public bool gameOver = false;

    void Start(){
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameIsOver)
            return;
            
        if(PlayerStats.Lives <= 0){
            EndGame();
        }
    }

    void EndGame(){
        GameIsOver = true;
        gameOverUI.SetActive(true);   
        gameOver = true;   
    }

    public void winLevel(){
        if(gameOver)
           return;
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
