using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOrReStart : MonoBehaviour
{

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void RePlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
