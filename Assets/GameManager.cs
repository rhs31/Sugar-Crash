using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public Score score;
	public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            score.timeElapsed = 0;

        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {

    }
}
