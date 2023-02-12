using DIScriptableObject.Provider;

namespace DIScriptableObject.Example.Provider
{
    public class ServiceSingleProvider : AbstractSingleProvider<IServiceExample>
    {
        protected override void ConstructService()
        {
            _service = new ServiceExample(15, "ServiceName");
        }
    }
}   