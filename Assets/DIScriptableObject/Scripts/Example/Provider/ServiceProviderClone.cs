using DIScriptableObject.Provider;

namespace DIScriptableObject.Example.Provider
{
    public class ServiceProviderClone : AbstractCloneProvider<IRefServiceExample>
    {
        protected override void ConstructService()
        {
            _service = new RefServiceExample(22, "RefExampleService");
        }
    }
}