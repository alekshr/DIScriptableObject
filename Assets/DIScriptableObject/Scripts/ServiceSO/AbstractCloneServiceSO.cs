using System;


namespace DIScriptableObject
{
    public abstract class AbstractCloneServiceSO<T> : AbstractServiceSO<T> where T : ICloneable
    {
        public override T Get() => (T)_service.Clone();
    }
}