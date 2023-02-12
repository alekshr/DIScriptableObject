
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace DIScriptableObject.Example
{
    [RequireComponent(typeof(Button))]
    public class NextScene : MonoBehaviour
    {
        [SerializeField] 
        private string _nextScene = default;

        private Button _button = default;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OpenScene);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OpenScene);
        }

        private void OpenScene() =>
            SceneManager.LoadScene(_nextScene);
    }

}

