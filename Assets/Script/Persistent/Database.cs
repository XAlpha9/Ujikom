using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.Database
{
    public class Database : MonoBehaviour
    {
        public string[] GetPackList()
        {
            return null;
        }
        public string[] GetLevelList(string packID)
        {
            return null;
        }
        public LevelStruct GetLevelData(string levelID)
        {
            return GetLevelData(null);
        }
    }

    public struct LevelStruct
    {
        string LevelID;
        string PackID;
        string Question;
        string Hint;
        string[] Choice;
        int Answer;

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

