using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace ujikom.Scene
{
    public class PackScene : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI DisplayCoin;
        Currency.Currency Instance;

        private void Start()
        {
            Instance = GameObject.Find("GlobalLayer").GetComponent<Currency.Currency>();
        }
        private void Update()
        {
            DisplayCoin.text = Instance.CurrentCoin + " G";
        }
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

