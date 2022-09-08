using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ujikom.Scene
{
    public class LevelScene : MonoBehaviour
    {
        public void SelectLevel()
        {
            SceneManager.LoadScene("Gameplay");
        }
        public void GoBack()
        {
            SceneManager.LoadScene("Home");
        }
    }
}

