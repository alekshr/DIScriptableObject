using UnityEngine;
using UnityEngine.UI;

namespace DIScriptableObject.Example.Provider
{
    public class ControllerSingleExample : MonoBehaviour
    {
        [SerializeField] 
        private Text _valueText = default;
        
        [SerializeField] 
        private Text _nameText = default;

        [SerializeField] private AbstractServiceSO<IServiceExample> _serviceSo = default;

        private void Awake()
        {
            _valueText.text = _serviceSo.Service.Value.ToString();
            _nameText.text = _serviceSo.Service.Name;
        }
    }
}