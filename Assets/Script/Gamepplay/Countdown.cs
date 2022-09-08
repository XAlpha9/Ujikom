using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ujikom.CountDown
{
    public class Countdown : MonoBehaviour
    {
        [SerializeField]
        private Slider CountdownBar;
        private bool IsStarted = false;
        CountdownModel _countdown;

        private void Start()
        {
            StartCountdown();    
        }

        private void Update()
        {
            if (IsStarted == true) { _countdown.Remaining -= ((long)Time.deltaTime); }
            CountdownBar.value = _countdown.Remaining;
        }

        public void StartCountdown()
        {
            _countdown.Remaining = 30;
            IsStarted = true;
        }
        public void StopCountdown()
        {
            IsStarted = false;
        }
        public void FinishCountdown()
        {
            IsStarted = false;
            _countdown.Remaining = 30;
        }
    }

    public struct CountdownModel
    {
        public long Remaining;

        public CountdownModel(long remaining)
        {
            Remaining = remaining;
        }
    }
}

