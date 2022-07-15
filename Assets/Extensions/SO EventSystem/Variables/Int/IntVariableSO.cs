using UnityEngine;
using UnityEngine.Events;

namespace KasperDev.ModularComponents
{
    [CreateAssetMenu(fileName = "Int Variable", menuName = "Variable/Int Variable", order = 1)]
    public class IntVariableSO : ScriptableObject
    {
        [HideInInspector]
        public UnityEvent OnUpdate;
#if UNITY_EDITOR
#pragma warning disable CS0414
        [Multiline]
        [SerializeField] private string _developerDescription = "";
#pragma warning restore CS0414
#endif
        [SerializeField] private int _value;

        public int Value { get => _value; set { this._value = value; OnUpdate?.Invoke(); } }
    
            public void SetValue(int value)
        {
            Value = value;
        }

        public void SetValue(IntVariableSO value)
        {
            Value = value.Value;
        }

        public void Add(int amount)
        {
            Value += amount;
        }

        public void Subtract(int amount)
        {
            Value -= amount;
        }


        public void Divide(int amount)
        {
            Value /= amount;
        }

        public void Multiply(int amount)
        {
            Value *= amount;
        }
    }
}