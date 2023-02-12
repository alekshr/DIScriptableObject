
using UnityEngine;
using UnityEngine.UI;

namespace DIScriptableObject.Example.Provider
{
    public class ControllerCloneExample : MonoBehaviour
    {
        [SerializeField] 
        private Text _valueText = default;
        
        [SerializeField] 
        private Text _nameText = default;

        [SerializeField] private AbstractServiceSO<IRefServiceExample> _serviceSo = default;

        private void Awake()
        {
            _valueText.text = _serviceSo.Service.GetService().Value.ToString();
            _nameText.text = _serviceSo.Service.GetService().Name;
        }
    }
}