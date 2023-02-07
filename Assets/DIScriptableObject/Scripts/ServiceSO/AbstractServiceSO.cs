using DIScriptableObject.ConstructorSO;
using UnityEngine;

namespace DIScriptableObject
{
    public abstract class AbstractServiceSO<T> : ScriptableObject
    {
        protected T _service = default;

        public T Service => _service;

        public void Construct(IGetServiceSO<T> getServiceService)
        {
            if (_service == null)
            {
                _service = getServiceService.GetServiceProvider();
            }
            else
            {
               Debug.LogError("Service is inited. Check SO where init service"); 
            }
        }
        
        public abstract T Get();
    }
}
