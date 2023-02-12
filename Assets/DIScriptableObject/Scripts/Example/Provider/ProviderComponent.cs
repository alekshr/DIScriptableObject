using DIScriptableObject.Provider;
using UnityEngine;

namespace DIScriptableObject.Example.Provider
{

    public class ProviderComponent : AbstractComponentProvider<ComponentServiceExample>
    {

        [SerializeField] private int _value = default;
        [SerializeField] private string _name = default;

        
        protected override void Awake()
        {
            _component.Constructor(_value, _name);
            base.Awake();
        }
    }
}