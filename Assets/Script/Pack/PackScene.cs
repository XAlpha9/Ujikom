using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ujikom.Scene
{
    public class PackScene : MonoBehaviour
    {
        public void SelectPack()
        {
            SceneManager.LoadScene("Level");

        }
        public void GoBack()
        {
            SceneManager.LoadScene("Home");
        }
    }
}

