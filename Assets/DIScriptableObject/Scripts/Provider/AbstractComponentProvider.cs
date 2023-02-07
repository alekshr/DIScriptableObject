using DIScriptableObject.ConstructorSO;
using UnityEngine;

namespace DIScriptableObject.Provider
{
    [DefaultExecutionOrder(-5000)]
    public abstract class AbstractComponentProvider<T> : MonoBehaviour, IGetServiceSO<T> where T : Component
    {
        [SerializeField] 
        protected T _component = default;
        
        [SerializeField] 
        protected AbstractServiceSO<T> _serviceComponent = default;

        protected void Awake() =>
            _serviceComponent.Construct(this);

        public T GetServiceProvider() =>
            _component;
    }
}