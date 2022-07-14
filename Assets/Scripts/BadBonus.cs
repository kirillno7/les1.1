using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class BadBonus : Bonus , IFly, IRotation
    {
        private float highFly;
        private float speedRotation;
        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, highFly),transform.position.z);
        }
       public void Rotate()
        {
            transform.Rotate(Vector3.up*(Time.deltaTime* speedRotation), Space.World);
        }
        private void Awake()
        {
            highFly = Random.Range(1f, 5f);
            speedRotation = Random.Range(13f, 40f);
        }
        private void Update()
        {
            Fly();
            Rotate();

        }
    }
}