using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public static int score;
    [SerializeField] Text scoreTxt;
    [SerializeField] GameObject playPanel;
    [SerializeField] GameObject finishPanel;
    [SerializeField] GameObject ground;
    void Start()
    {
        score = 0;
        playPanel.SetActive(true);
    }
    void Update()
    {
        scoreTxt.text = score.ToString();
    }

    //------------------------------------------------------------------------
    public void PlayBtn()
    {
        playPanel.SetActive(false);
        StartCoroutine(StartGame());
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(0.3f);
        BallMoveController.speed = 1;
    }
    public void RetryBtn()
    {
        finishPanel.SetActive(false);
        SceneManager.LoadScene(0);
        finishPanel.SetActive(true);
        BallMoveController.speed = 0;
    }
}
