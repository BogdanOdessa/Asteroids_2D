using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Command.Second
{
    internal sealed class PanelTwo : BaseUi
    {
        [SerializeField] private Text _text;
        
        public override void Execute()
        {
            _text.text =  "Pause";
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}