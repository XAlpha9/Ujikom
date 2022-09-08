using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ujikom.Currency;

namespace ujikom.UnlockPack
{
    public class PackUnlock : MonoBehaviour
    {
        [SerializeField]
        private int unlockAmount;
        private Currency.Currency Instance;
        private Analytic.Analytic AnalyticServer;

        private void Start()
        {
            Instance = GameObject.Find("GlobalLayer").GetComponent<Currency.Currency>();
            AnalyticServer = GameObject.Find("GlobalLayer").GetComponent<Analytic.Analytic>();
        }
        public void UnlockPack(string packID)
        {
            if (Instance.CurrentCoin >= unlockAmount)
            {
                Instance.SpendCoin(unlockAmount);
                AnalyticServer.TrackUnlockPack(packID);
                if (Instance.CurrentCoin < 0)
                {
                    Instance.CurrentCoin = 0;
                }
            }
            else if (Instance.CurrentCoin < unlockAmount)
            {
                Debug.Log("Not enough Gold");
                if (Instance.CurrentCoin < 0)
                {
                    Instance.CurrentCoin = 0;
                }
            }
            
        }
    }
}

