using UnityEngine;
using UnityEngine.Events;

namespace KasperDev.ModularComponents
{
    [CreateAssetMenu(fileName = "Float Variable", menuName = "Variable/Float Variable", order = 1)]
    public class FloatVariableSO : ScriptableObject
    {
        [HideInInspector]
        public UnityEvent OnUpdate;
#if UNITY_EDITOR
#pragma warning disable CS0414
        [Multiline]
        [SerializeField] private string _developerDescription = "";
#pragma warning restore CS0414
#endif
        [SerializeField] private float _value;

        public float Value { get => _value; set { this._value = value; OnUpdate?.Invoke(); } }

        public void SetValue(float value)
        {
            Value = value;
        }

        public void SetValue(FloatVariableSO value)
        {
            Value = value.Value;
        }

        public void Add(float amount)
        {
            Value += amount;
        }
        
        public void Subtract(float amount)
        {
            Value -= amount;
        }
        
        
        public void Divide(float amount)
        {
            Value /= amount;
        }
        
        public void Multiply(float amount)
        {
            Value *= amount;
        }





      
    }
}