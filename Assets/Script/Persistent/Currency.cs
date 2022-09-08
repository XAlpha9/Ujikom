using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.Currency
{
    public class Currency : MonoBehaviour
    {
        public int GetCoin()
        {
            return 0 ;
        }

        public void AddCoin(int amount)
        {

        }

        public bool SpendCoin(int amount)
        {
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

