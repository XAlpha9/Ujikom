using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.Analytic
{
    public class Analytic : MonoBehaviour
    {
        public void TrackFinishLevel(string LevelID)
        {
            Debug.Log("[Send to Analytic Server] Finished Level " + LevelID);
        }
        public void TrackUnlockPack(string PackID)
        {
            Debug.Log("[Send to Analytic Server] Unlocked Pack " + PackID);
        }
    }
}

