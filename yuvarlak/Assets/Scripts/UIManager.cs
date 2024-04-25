using UnityEngine;
using TMPro; // TextMeshPro için gerekli

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI timeText; // Süre için Text elemaný
    public TextMeshProUGUI circleCountText; // Daire sayýsý için Text elemaný
    int circleCount;

    private float startTime;
    private int currentScore = 0;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        UpdateTime();
        UpdateCircleCount();
    }



    void UpdateTime()
    {
        float timeSinceStart = Time.time - startTime;
        timeText.text = Mathf.FloorToInt(timeSinceStart).ToString();
    }

    void UpdateCircleCount()
    {
        // CircleManager adýnda bir script varsayýyoruz. Bu script, aktif daire sayýsýný tutuyor.
        int circleCount = FindObjectsOfType<Bullet>().Length; // Scene'deki tüm Circle objelerini say
        currentScore = circleCount;
        circleCountText.text = circleCount.ToString();
        UpdateHighScore();
    }
    void UpdateHighScore()
    {
        // PlayerPrefs'ten mevcut yüksek skoru çek
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        // Eðer mevcut skor, kayýtlý yüksek skordan büyükse, yeni deðeri kaydet
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            PlayerPrefs.Save();
        }
    }

}
