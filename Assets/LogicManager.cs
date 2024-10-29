using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Manages the UI
public class LogicManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    
    public int gameTimer = 0; // The Timer
    public Text scoreText;
    public double timerInterval = 1.0;
    public double resetTimer = 0;

    void Update()
    {
        resetTimer += Time.deltaTime;

        if (resetTimer >= timerInterval)
        {
            gameTimer += 1;
            scoreText.text = gameTimer.ToString();

            resetTimer = 0;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}