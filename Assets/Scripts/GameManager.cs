using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    public GameObject player;
    public Text scoreText;
    public int score = 0;
    public bool isPlaying = true;
    public GameObject gameOverCanvas;
    public EntryScore entry;
    public Button enableButton;
    public GameObject directionAuth;
    public GameObject directionButtons;
    public Button playGame;
    void Start()
    {
        instance = this;
        Time.timeScale = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (score >= 335)
        {
            isPlaying = false;
        }
        if (isPlaying)
        {
            scoreText.text = "Score: " + score.ToString();
            enableButton.onClick.AddListener(TaskOnClick);
            playGame.onClick.AddListener(initiateGame);
        }
        else if(isPlaying == false)
        {
            gameOverCanvas.SetActive(true);
            Constants.conScore = score.ToString();
            SceneManager.LoadScene("MainMenu");

        }
        
    }
    void TaskOnClick()
    {
        
        directionAuth.SetActive(false);
        directionButtons.SetActive(true);
        Time.timeScale = 1f;
    }
    void initiateGame()
    {
        directionAuth.SetActive(false);
        Time.timeScale = 1f;
    }
}
