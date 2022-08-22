using System;
using System.Collections.Generic;
using System.Text;

namespace PongMonoGame
{
    public class Ball : GameObject
    {
        private float _speed = 100.0f;              // Скорость

        public Ball(Pong context) : base(context) { }

        private void CheckCollision() { 
            
        }
    }
}
