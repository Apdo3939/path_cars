using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public bool startScore = false;
    public Text txtShownCurrentScore;
    public Text txtShowMaxScore;

    [Space(10)]
    public float scoreMultiplier = 0.5f;

    private float maxScore = 0.0f;
    private float currentScore = 0.0f;

    void Start()
    {
        if (PlayerPrefs.HasKey("maxScore") && txtShowMaxScore)
        {
            float.TryParse(PlayerPrefs.GetString("maxScore"), out maxScore);
            txtShowMaxScore.text = string.Format("MAX SCORE: <color=\"green\">{0}</color>", Mathf.Round(maxScore).ToString());

        }
    }

    void Update()
    {
        if (startScore)
        {
            SetScore();
        }
    }

    void SetScore()
    {
        currentScore += (1 * scoreMultiplier) * Time.deltaTime;

        if (txtShownCurrentScore)
        {
            txtShownCurrentScore.text = string.Format("SCORE: {0}",Mathf.Round(currentScore));
        }


        if (currentScore > maxScore)
        {
            maxScore = currentScore;
            PlayerPrefs.SetString("maxScore", maxScore.ToString());
        }

    }
}
