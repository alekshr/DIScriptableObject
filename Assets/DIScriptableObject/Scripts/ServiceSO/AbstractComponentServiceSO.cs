using UnityEngine;

namespace DIScriptableObject
{
    public abstract class AbstractComponentServiceSO<T> : AbstractServiceSO<T> where T : Component
    {
        public override T Get() => _service;
    }
}