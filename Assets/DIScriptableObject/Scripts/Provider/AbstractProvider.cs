using DIScriptableObject.ConstructorSO;
using UnityEngine;

namespace DIScriptableObject.Provider
{
    [DefaultExecutionOrder(-5000)]
    public abstract class AbstractProvider<T> :  MonoBehaviour, IGetServiceSO<T>
    {
        [SerializeField] 
        protected AbstractServiceSO<T> _serviceComponent = default;
        
        protected T _service = default;
        
        protected void Awake() =>
            _serviceComponent.Construct(this);

        public T GetServiceProvider() 
            => _service;
    }
}