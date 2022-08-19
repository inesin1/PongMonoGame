using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongMonoGame
{
    class Bat : GameObject
    {
        private float _speed = 100.0f;              // Скорость
        private string _side = "none";              // Сторона

        /// <summary>
        /// Конструктор ракетки
        /// </summary>
        /// <param name="side">Сторона ракетки (left/right)</param>
        public Bat(string side) {
            _side = side;
        }
    }
}
