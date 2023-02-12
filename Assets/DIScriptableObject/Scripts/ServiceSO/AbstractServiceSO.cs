using DIScriptableObject.ConstructorSO;
using UnityEngine;

namespace DIScriptableObject
{
    public abstract class AbstractServiceSO<T> : ScriptableObject
    {
        protected T _service = default;

        public T Service => _service;

        public virtual void Construct(IGetServiceSO<T> getServiceService) =>
            _service = getServiceService.GetServiceProvider();
        
        public abstract T Get();
    }
}
