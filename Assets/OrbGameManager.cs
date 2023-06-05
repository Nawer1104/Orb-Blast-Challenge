using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrbGameManager : Singleton<OrbGameManager>
{
    public List<Ball> balls;

    public void RemoveBall(Ball ball)
    {
        balls.Remove(ball);
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (balls.Count <= 0)
        {
            ReSetGame();
        }
    }

    private void ReSetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
