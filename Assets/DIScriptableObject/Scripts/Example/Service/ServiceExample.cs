

namespace DIScriptableObject.Example
{
    public class ServiceExample : IServiceExample
    {
        public int Value { get; private set; }
        
        public string Name { get; private set; }
        
        public ServiceExample(int value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}