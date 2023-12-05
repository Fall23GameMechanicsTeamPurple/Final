using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseGame : MonoBehaviour
{ 
    public void LoadLoseScene(string sceneName)
    {
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
