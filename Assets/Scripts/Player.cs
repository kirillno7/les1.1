using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Maze
{
    public class Player : Unit, ICloneable
    {
        public override void Awake()
        {
            base.Awake();
        }
        public object Clone()
        {
            Player unit = new Player();
            return unit;
        }
        public override void Move(float x, float y, float z)
        {
            if (_rb)
            {
                _rb.AddForce(new Vector3 (x,y,z)* _speed);
            }
        }
    }
}
