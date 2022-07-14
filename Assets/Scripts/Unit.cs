using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Transform _tr;
        public Rigidbody _rb;

        public float _speed = 5f;
        public int health = 100;
        public bool IsDead;

        public virtual void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _tr = GetComponent<Transform>();
        }
        public abstract void Move(float x, float y, float z);
    }
}
