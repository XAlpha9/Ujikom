using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ujikom.Scene
{
    public class GameplayScene : MonoBehaviour
    {

        public void GoBack()
        {
            SceneManager.LoadScene("Level");
        }
    }
}

