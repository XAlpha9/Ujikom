using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace ujikom.LevelData
{
    public class LevelData : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI LevelNameLabel;
        [SerializeField]
        private Button SelectButton;
        [SerializeField]
        private Image CompleteIMG;

        public void LoadLevelList()
        {

        }
        public LevelDataModel[] GetLevelList()
        {
            return GetLevelList();
        }
        public void InitLevelList(LevelDataModel[] levels)
        {

        }
    }

    public struct LevelDataModel
    {
        public string LevelID;
        public string LevelName;
        public bool isCompleted;

        public LevelDataModel(string levelID, string levelName, bool isCompleted)
        {
            LevelID = levelID;
            LevelName = levelName;
            this.isCompleted = isCompleted;
        }
    }
}

