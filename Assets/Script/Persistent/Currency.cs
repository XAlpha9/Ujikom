using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.Currency
{
    public class Currency : MonoBehaviour
    {
        public int CurrentCoin;
        //^Change to private Later
        CurrencyModel _Currency;
        private void Start()
        {
            GetCoin();
        }
        public int GetCoin()
        {
            _Currency.Coin = CurrentCoin;
            return CurrentCoin;
        }

        public void AddCoin(int amount)
        {
            _Currency.Coin += amount;
            CurrentCoin = _Currency.Coin;
            Debug.Log("Current Coin: " + CurrentCoin);
        }

        public bool SpendCoin(int amount)
        {
            _Currency.Coin -= amount;
            CurrentCoin = _Currency.Coin;
            Debug.Log("Current Coin: " + CurrentCoin);
            return true;
        }
    }

    public struct CurrencyModel
    {
        public int Coin;

        public CurrencyModel(int coin)
        {
            Coin = coin;
        }
    }
}

