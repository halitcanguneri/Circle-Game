using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject deathScreen; // Inspector'dan sürükleyip býrakarak atayýn
    public Animation GozUstAnim;
    public Animation GozAltAnim;

    public AudioSource backgroundMusic;




    private void Start()
    {
        deathScreen.SetActive(false); // Baþlangýçta deathScreen kapalý
    }

    public void EndGame()
    {
        deathScreen.SetActive(true); // Oyun sonlandýðýnda deathScreen açýlýr
        HandleDeath();
        Time.timeScale = 0; // Oyunu durdurur
    }
    public void StartGame()
    {
        // Oyunun baþlamasý için ana sahneyi yükleyin. Sahne adýnýzý buraya girin.
        SceneManager.LoadScene("MainScene");
    }
    public void RestartGame()
    {
        // Mevcut sahneyi yeniden yükleyerek oyunu yeniden baþlatýr
        Time.timeScale = 1; // Zamaný normale çevir
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void HandleDeath()
    {
        backgroundMusic.Stop();  // Müziði durdurur
        // Diðer ölüm iþlemleri
    }



    public void BlinkEffect()
    {
        GozUstAnim.Play("DeathGozAltAnim"); // Animator içindeki Blink animasyonunu tetikler
        GozAltAnim.Play("DeathGozAnim"); // Animator içindeki Blink animasyonunu tetikler
    }


}
