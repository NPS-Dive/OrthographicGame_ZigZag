using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
    {
    public float Gem;
    public TMP_Text GemText;
    public float Score;
    public TMP_Text ScoreText;
    public float LastScore;
    public TMP_Text LastScoreText;
    public TMP_Text GameOverScoreText;


    // Start is called before the first frame update
    void Start ()
        {
        Gem = PlayerPrefs.GetFloat("Gem");
        Score = PlayerPrefs.GetFloat("Score");
        LastScore = PlayerPrefs.GetFloat("LastScore");
        GameOverScoreText.text = Score.ToString();
        }

    // Update is called once per frame
    void Update ()
        {
        GemText.text = Gem.ToString();
        ScoreText.text = Score.ToString();
        LastScoreText.text = LastScore.ToString();
        }

    #region Custom Functions

    public void SaveGems ()
        {
        PlayerPrefs.SetFloat("Gem", Gem);
        }

    public void SaveScore ()
        {
        PlayerPrefs.SetFloat("Score", Score);
        PlayerPrefs.SetFloat("LastScore", Score);
        }

    #endregion Custom Functions
    }
