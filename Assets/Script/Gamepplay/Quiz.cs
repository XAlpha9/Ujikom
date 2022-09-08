using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace ujikom.Quiz
{
    public class Quiz : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI QuestionText;
        [SerializeField]
        private Image HintImage;
        [SerializeField]
        private Button[] answerButtons;

        public void InitQuiz(Database.LevelStruct level)
        {

        }
    }
}

