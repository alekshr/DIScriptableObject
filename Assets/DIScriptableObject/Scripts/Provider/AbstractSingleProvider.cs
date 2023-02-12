using DIScriptableObject.ConstructorSO;
using UnityEngine;

namespace DIScriptableObject.Provider
{
    [DefaultExecutionOrder(-5000)]
    public abstract class AbstractSingleProvider<T> :  MonoBehaviour, IGetServiceSO<T>
    {
        [SerializeField] 
        protected AbstractServiceSO<T> _serviceComponent = default;
        
        protected T _service = default;

        protected virtual void Awake()
        {
            ConstructService();
            _serviceComponent.Construct(this);
        }


        protected abstract void ConstructService();
        
        public T GetServiceProvider() 
            => _service;
    }
}