using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ujikom.Scene
{
    public class HomeScene : MonoBehaviour
    {
        public void StartPlay()
        {
            SceneManager.LoadScene("Pack");
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void OnApplicationQuit()
        {
            
        }
    }

}
