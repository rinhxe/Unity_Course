using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public int Score;
    public Text ScoreText;
    public GameObject ReplayButton;
    public GameObject gameOver;
    public GameObject getReady;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        getReady.SetActive(true);
        Pause();
    }
    
    public void Play()
    {
        getReady.SetActive(false);
        player.transform.position = new Vector3(0, 0, 0);
        Score = 0;
        ScoreText.text =Score.ToString();
        gameOver.SetActive(false);
        ReplayButton.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        PipeMove[] pipes = FindObjectsOfType<PipeMove>();

        for(int i = 0; i< pipes.Length; i++) {
            Destroy(pipes[i].gameObject) ;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        ReplayButton.SetActive(true);
        Pause();
    }

    public void InscreaseScore()
    {
        Score ++;
        ScoreText.text = Score.ToString();
    }
}
