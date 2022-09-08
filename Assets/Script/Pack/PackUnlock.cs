using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ujikom.Currency;

namespace ujikom.UnlockPack
{
    public class PackUnlock : MonoBehaviour
    {
        private Currency.Currency Instance;

        private void Start()
        {
            Instance = GameObject.Find("GlobalLayer").GetComponent<Currency.Currency>();
        }
        public void UnlockPack(string packID)
        {
            if ()
            {

            }
        }
    }
}

