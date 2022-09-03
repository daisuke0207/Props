using UnityEngine;

namespace Props.Domains.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PropObject", menuName = "ScriptableObject/Props", order = 0)]
    public class PropObject : ScriptableObject
    {
        public GameObject prop;
        public string code;
    }
}