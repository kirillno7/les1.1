using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class GoodBonus : Bonus
    {
        private float acceleration;
        private Maze.Player player;
        private float _speed;

        private void Awake()
        {
            acceleration = 1.5f;
            player = GetComponent<Player>();
            _speed = player._speed;
        }
        void Acceleration()
        {
            _speed = _speed * acceleration;
        }
        private void Update()
        {
            Acceleration();
        }
    }
}