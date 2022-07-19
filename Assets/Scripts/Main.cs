using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour, IExecute
    {
        private InputController _inputController;
        private ListExecuteObject _interactiveObject;
        private GoodBonus _gbonus;
        private BadBonus _badBonus;

        [SerializeField] private Unit _player;

        private void Awake()
        {
            _inputController = new InputController(_player);
            _interactiveObject = new ListExecuteObject();
            _interactiveObject.AddExecuteObject(_inputController);
            _gbonus = new GoodBonus();
            _interactiveObject.AddExecuteObject(_gbonus);
            _badBonus = new BadBonus();
            _interactiveObject.AddExecuteObject(_badBonus);
        }
        public void Update()
        {
            for (int i =0; i< _interactiveObject.Length; i++)
            {
                if (_interactiveObject[i] == null)
                {
                    continue;
                }
                _interactiveObject[i].Update();
            }
        }
    }
}
