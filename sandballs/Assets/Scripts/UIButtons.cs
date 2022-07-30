using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    private GameManager gameManager;

    private void Start() {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    public void startGame() {
        gameManager.startGame();
    }

    public void restartGame() {
        gameManager.restartGame();
    }
    public void nextGame()
    {
        gameManager.nextGame();
    }

    public void endGame() {
        gameManager.showGameOver();
    }

    
}
