using DIScriptableObject.ConstructorSO;
using UnityEngine;
using UnityEngine.Serialization;

namespace DIScriptableObject.Provider
{
    [DefaultExecutionOrder(-5000)]
    public abstract class AbstractComponentProvider<T> : MonoBehaviour, IGetServiceSO<T> where T : Component
    {
        [SerializeField] 
        protected T _component = default;
        
        [SerializeField] 
        protected AbstractServiceSO<T> _serviceSo = default;

        protected virtual void Awake() =>
            _serviceSo.Construct(this);

        public T GetServiceProvider() =>
            _component;
    }
}