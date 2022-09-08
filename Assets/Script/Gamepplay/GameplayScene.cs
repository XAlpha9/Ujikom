using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ujikom.Scene
{
    public class GameplayScene : MonoBehaviour
    {
        public void GoToLevelScene()
        {
            SceneManager.LoadScene("Level");
        }
        public void GoToPackScene()
        {
            SceneManager.LoadScene("Pack");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

