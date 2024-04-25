using UnityEngine;
using TMPro; // TextMeshPro i�in gerekli

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI timeText; // S�re i�in Text eleman�
    public TextMeshProUGUI circleCountText; // Daire say�s� i�in Text eleman�
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
        // CircleManager ad�nda bir script varsay�yoruz. Bu script, aktif daire say�s�n� tutuyor.
        int circleCount = FindObjectsOfType<Bullet>().Length; // Scene'deki t�m Circle objelerini say
        currentScore = circleCount;
        circleCountText.text = circleCount.ToString();
        UpdateHighScore();
    }
    void UpdateHighScore()
    {
        // PlayerPrefs'ten mevcut y�ksek skoru �ek
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        // E�er mevcut skor, kay�tl� y�ksek skordan b�y�kse, yeni de�eri kaydet
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            PlayerPrefs.Save();
        }
    }

}
