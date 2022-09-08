using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.Database
{
    public class Database : MonoBehaviour
    {
        public int TotalPack;
        public Question.LevelQuestion[] QuestionList;
        public PackList.ListPack _ListPackID;

        LevelStruct _Level;
        [HideInInspector]
        public string[] _packLists, _levelLists;

        private void Awake()
        {
            GameObject[] obj = GameObject.FindGameObjectsWithTag("Global");
            if (obj.Length > 1)
            {
                Destroy(this.gameObject);
            }

            DontDestroyOnLoad(this.gameObject);
        }
        public string[] GetPackList()
        {
            _packLists = new string[TotalPack];
            for (int i = 0; i < TotalPack; i++)
            {
                _packLists[i] = "Pack" + _ListPackID.PackID[i];
                Debug.Log("added "+_packLists);
            }
            return _packLists;
        }
        public string[] GetLevelList(string packID)
        {
            _levelLists = new string[5];
            for (int i = 0; i < 5; i++)
            {
                _levelLists[i] = packID + "-" + (i + 1);
                Debug.Log("added " + _levelLists);
            }
            return _levelLists;
        }
        public LevelStruct GetLevelData(string levelID)
        {

            return GetLevelData(null);
        }
    }

    public struct LevelStruct
    {
        public string LevelID;
        public string PackID;
        public string Question;
        public string Hint;
        public string[] Choice;
        public int Answer;

        public LevelStruct(string levelID, string packID, string question, string hint, string[] choice, int answer)
        {
            LevelID = levelID;
            PackID = packID;
            Question = question;
            Hint = hint;
            Choice = choice;
            Answer = answer;
        }
    }
}

