using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject deathScreen; // Inspector'dan s�r�kleyip b�rakarak atay�n
    public Animation GozUstAnim;
    public Animation GozAltAnim;

    public AudioSource backgroundMusic;




    private void Start()
    {
        deathScreen.SetActive(false); // Ba�lang��ta deathScreen kapal�
    }

    public void EndGame()
    {
        deathScreen.SetActive(true); // Oyun sonland���nda deathScreen a��l�r
        HandleDeath();
        Time.timeScale = 0; // Oyunu durdurur
    }
    public void StartGame()
    {
        // Oyunun ba�lamas� i�in ana sahneyi y�kleyin. Sahne ad�n�z� buraya girin.
        SceneManager.LoadScene("MainScene");
    }
    public void RestartGame()
    {
        // Mevcut sahneyi yeniden y�kleyerek oyunu yeniden ba�lat�r
        Time.timeScale = 1; // Zaman� normale �evir
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void HandleDeath()
    {
        backgroundMusic.Stop();  // M�zi�i durdurur
        // Di�er �l�m i�lemleri
    }



    public void BlinkEffect()
    {
        GozUstAnim.Play("DeathGozAltAnim"); // Animator i�indeki Blink animasyonunu tetikler
        GozAltAnim.Play("DeathGozAnim"); // Animator i�indeki Blink animasyonunu tetikler
    }


}
