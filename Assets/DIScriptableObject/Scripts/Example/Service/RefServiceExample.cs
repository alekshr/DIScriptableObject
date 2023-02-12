
namespace DIScriptableObject.Example
{
    public class RefServiceExample : IRefServiceExample
    {

        private IServiceExample service;
        
        public RefServiceExample(int value, string name)
        {
            service = new ServiceExample(value, name);
        }
        
        public object Clone() =>
            new RefServiceExample(10, "IRefService");
        
        public IServiceExample GetService() =>
            service;
    }
}