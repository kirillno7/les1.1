using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class InputController
    {
        private readonly Unit _player;

        public float horizontal;
        public float vertical;

        public InputController(Unit player)
        {
            _player = player;
        }
        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            _player.Move(horizontal,0f,vertical);
        }
    }
}