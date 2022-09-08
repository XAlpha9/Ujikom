using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ujikom.PackList
{
    [CreateAssetMenu(fileName = "ListPack", menuName = "ScriptableObject/Pack List")]
    public class ListPack : ScriptableObject
    {
        public string[] PackID;
    }
}

