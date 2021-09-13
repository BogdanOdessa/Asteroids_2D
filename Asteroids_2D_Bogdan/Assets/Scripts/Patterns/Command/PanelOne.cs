using System;
using Asteroids2D;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Command.Second
{
    internal sealed class PanelOne : BaseUi
    {
        [SerializeField] private Text _text;
        [SerializeField] private GameController _gameController;

        private Interpreter _interpreter;

        private void Start()
        {
            _interpreter = new Interpreter();
        }

        public override void Execute()
        {
            _text.text = $"Points: {_interpreter.ShortTheNumber(_gameController.GetPointsAmount())} " +
                         $"\nDestroyed asteroids {_gameController.GetDestroyedAsteroidsAmount()}";
                         
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}