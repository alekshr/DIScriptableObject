using System;

namespace DIScriptableObject.Example
{
    public interface IRefServiceExample : ICloneable
    {
        IServiceExample GetService();
    }
}