using UnityEngine;
using TMPro; // TextMeshPro için gerekli namespace

public class DisplayHighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText; // Inspector'dan bu deðiþkeni atayýn

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();
    }
}