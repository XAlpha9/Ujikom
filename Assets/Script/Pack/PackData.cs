using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ujikom.PackData
{
    public class PackData : MonoBehaviour
    {
        private TextMeshProUGUI PackNameLabel;
        private TextMeshProUGUI UnlockCostLabel;
        private Button SelectButton;
        private Button UnlockButton;
        private Image CompleteImage;

        public void LoadPackList()
        {

        }

        public PackDataModel[] GetpackList()
        {

            return GetpackList();
        }

        public void InitPackList(PackDataModel[] packs)
        {

        }
    }
    public struct PackDataModel
    {
        string PackID;
        string PackName;
        bool IsCompleted;
        bool isUnlocked;
        int UnlockCost;

        public PackDataModel(string packID, string packName, bool isCompleted, bool isUnlocked, int unlockCost)
        {
            PackID = packID;
            PackName = packName;
            IsCompleted = isCompleted;
            this.isUnlocked = isUnlocked;
            UnlockCost = unlockCost;
        }
    }
}

