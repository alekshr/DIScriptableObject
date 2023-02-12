using UnityEngine;

namespace DIScriptableObject.Example
{
    public class ComponentServiceExample : MonoBehaviour, IServiceExample
    {
        
        public int Value { get; private set; }
        
        public string Name { get; private set; }
        
        public void Constructor(int value, string nameService)
        {
            Value = value;
            Name = nameService;
        }
    }
}