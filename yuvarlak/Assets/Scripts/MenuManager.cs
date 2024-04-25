using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
    public void LoadGameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/your-profile");
    }

    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/yourusername");
    }
    public void LoadSocialLinksScene()
    {
        SceneManager.LoadScene("SocialLinks");
    }

}
