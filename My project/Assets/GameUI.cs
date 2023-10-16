using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
   

    public AudioSource bgAudio,clickAudio;
    
    public void AddAudio()
    {
        bgAudio.volume += 0.1f;
        clickAudio.volume += 0.1f;
    }
    public void DeAudio()
    {
        bgAudio.volume -= 0.1f;
        clickAudio.volume -= 0.1f;
    }

    public void NextPage()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 >= 6)
            SceneManager.LoadScene(0);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LastPage()
    {
        if (SceneManager.GetActiveScene().buildIndex - 1 < 0)
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ChanegeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
