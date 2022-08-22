using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongMonoGame
{
    public class Bat : GameObject
    {
        private float _speed = 100.0f;              // Скорость
        private string _side = "none";              // Сторона

        /// <summary>
        /// Конструктор ракетки
        /// </summary>
        /// <param name="side">Сторона ракетки (left/right)</param>
        public Bat(Pong context, string side) : base(context){
            _side = side;
        }

        public override void Init()
        {
            if (_side == "left") Texture = Context.Content.Load<Texture2D>("s_Bat_L");
            else Texture = Context.Content.Load<Texture2D>("s_Bat_R");

            base.Init();
        }

        public override void Update(float deltaTime) {
            base.Update(deltaTime);
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
