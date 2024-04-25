using UnityEngine;
using TMPro; // TextMeshPro i�in gerekli namespace

public class DisplayHighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText; // Inspector'dan bu de�i�keni atay�n

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();
    }
}