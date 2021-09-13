using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Command.Second
{
    internal sealed class UserInterface : MonoBehaviour
    {
        [SerializeField] private PanelOne _panelOne;
        [SerializeField] private PanelTwo _panelTwo;
        private BaseUi _currentWindow;

        private void Start()
        {
            _panelOne.Cancel();
            _panelTwo.Cancel();
        }

        private void Execute(StateUI stateUI)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Cancel();
            }

            switch (stateUI)
            {
                case StateUI.PanelOne:
                    _currentWindow = _panelOne;
                    break;

                case StateUI.PanelTwo:
                    _currentWindow =_panelTwo;
                    break;

                default:
                    break;
            }

            _currentWindow.Execute();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (_panelTwo.gameObject.activeInHierarchy)
                {
                    return;
                }
                Execute(StateUI.PanelOne);
            }
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_panelTwo.gameObject.activeInHierarchy)
                {
                    _panelTwo.Cancel();
                    Time.timeScale = 1f;
                }
                else
                {
                    Execute(StateUI.PanelTwo);
                    Time.timeScale = 0f;
                }
            }

            if (Input.GetKeyUp(KeyCode.Tab))
            {
                _panelOne.Cancel();
            }

           
        }
    }
}