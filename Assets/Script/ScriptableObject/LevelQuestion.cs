using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.Question
{
    [CreateAssetMenu(fileName = "Question", menuName = "ScriptableObject/Question List")]
    public class LevelQuestion : ScriptableObject
    {
        public string ID;
        public string Question;
        public string Hint;
        public string[] Choice;
        public int Answer;

    }
}


