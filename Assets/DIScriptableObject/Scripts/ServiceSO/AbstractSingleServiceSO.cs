

namespace DIScriptableObject
{
    public abstract class AbstractSingleServiceSO<T> : AbstractServiceSO<T>
    {
        public override T Get() => _service;
    }
}