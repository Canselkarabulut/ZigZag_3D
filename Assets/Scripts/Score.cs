using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    [SerializeField] Text scoreTxt;
    [SerializeField] GameObject playPanel;
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        scoreTxt.text = score.ToString();
    }
    public void PlayBtn()
    {
        playPanel.SetActive(false);
        StartCoroutine(StartGame());
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(0.5f);
        BallMoveController.speed = 1;

    }
}
